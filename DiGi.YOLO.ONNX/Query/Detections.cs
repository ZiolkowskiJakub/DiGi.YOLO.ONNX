using DiGi.YOLO.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.YOLO.ONNX
{
    public static partial class Query
    {
        /// <summary>
        /// Turns one image's slice of a raw ONNX detection output into the detections the bounding box result file records.
        /// <para>The network answers with one column per anchor holding a centred box in canvas pixels followed by a score for each class, already passed through a sigmoid. This filters those columns by confidence, suppresses overlapping boxes of the same class, keeps the strongest of what is left, and carries the survivors back to source pixels through the transform that put the image on the canvas.</para>
        /// <para>Each step reproduces what ultralytics does after its own forward pass, including the order the detections come out in - descending confidence - and the cap on candidates it applies before suppressing anything. Suppression is done in floating point rather than on rounded rectangles, because a box rounded to whole pixels at canvas scale shifts its overlap enough to flip a suppression that sits near the threshold.</para>
        /// </summary>
        /// <param name="values">The raw output buffer of one inference call, holding the whole batch.</param>
        /// <param name="dimensions">The shape of that buffer: batch, four box values plus one score per class, then anchors.</param>
        /// <param name="index">The position of the image within the batch.</param>
        /// <param name="name">The name recorded against every detection, which is the image's file name without its extension.</param>
        /// <param name="letterBox">The transform that put the image on the canvas, used to carry the detections back to source pixels.</param>
        /// <param name="yOLOONNXPredictionOptions">The settings holding the confidence, overlap and count thresholds to apply.</param>
        /// <returns>The detections, ordered by descending confidence, or <c>null</c> when the buffer, its shape, the transform or the settings are missing or do not describe one another.</returns>
        public static List<BoundingBoxResult>? Detections(float[]? values, int[]? dimensions, int index, string? name, Classes.LetterBox? letterBox, Classes.YOLOONNXPredictionOptions? yOLOONNXPredictionOptions)
        {
            if (values == null || dimensions == null || dimensions.Length != 3 || letterBox == null || yOLOONNXPredictionOptions == null)
            {
                return null;
            }

            //A cap of zero would answer every image with no detections at all, and a run that reported nothing everywhere is
            //indistinguishable from a detector that found nothing - the shape of failure this whole path is meant to avoid
            if (double.IsNaN(yOLOONNXPredictionOptions.Confidence) || double.IsNaN(yOLOONNXPredictionOptions.IoU) || yOLOONNXPredictionOptions.MaxDetections < 1)
            {
                return null;
            }

            int count_Batch = dimensions[0];
            int count_Channel = dimensions[1];
            int count_Anchor = dimensions[2];

            if (index < 0 || index >= count_Batch || count_Channel < 5 || count_Anchor < 1)
            {
                return null;
            }

            if (values.Length < count_Batch * count_Channel * count_Anchor)
            {
                return null;
            }

            int count_Class = count_Channel - 4;
            int offset_Image = index * count_Channel * count_Anchor;

            double confidence_Minimum = yOLOONNXPredictionOptions.Confidence;

            List<(double X1, double Y1, double X2, double Y2, double Confidence, int LabelIndex)> candidates = [];

            for (int i = 0; i < count_Anchor; i++)
            {
                double confidence = double.MinValue;
                int labelIndex = -1;

                for (int j = 0; j < count_Class; j++)
                {
                    double confidence_Class = values[offset_Image + ((4 + j) * count_Anchor) + i];
                    if (confidence_Class > confidence)
                    {
                        confidence = confidence_Class;
                        labelIndex = j;
                    }
                }

                //Ultralytics keeps a candidate only when it is strictly above the threshold, so a run at zero does not report every anchor there is
                if (labelIndex < 0 || confidence <= confidence_Minimum)
                {
                    continue;
                }

                double x = values[offset_Image + (0 * count_Anchor) + i];
                double y = values[offset_Image + (1 * count_Anchor) + i];
                double width = values[offset_Image + (2 * count_Anchor) + i];
                double height = values[offset_Image + (3 * count_Anchor) + i];

                candidates.Add((x - (width / 2d), y - (height / 2d), x + (width / 2d), y + (height / 2d), confidence, labelIndex));
            }

            candidates.Sort((first, second) => second.Confidence.CompareTo(first.Confidence));

            //Ultralytics discards everything past this many candidates before suppressing anything, so that a frame clearing the threshold on most of its anchors cannot turn a quadratic pass loose
            if (candidates.Count > Constants.Count.MaximumSuppressionCandidates)
            {
                candidates.RemoveRange(Constants.Count.MaximumSuppressionCandidates, candidates.Count - Constants.Count.MaximumSuppressionCandidates);
            }

            double IntersectionOverUnion((double X1, double Y1, double X2, double Y2, double Confidence, int LabelIndex) first, (double X1, double Y1, double X2, double Y2, double Confidence, int LabelIndex) second)
            {
                double width = Math.Min(first.X2, second.X2) - Math.Max(first.X1, second.X1);
                double height = Math.Min(first.Y2, second.Y2) - Math.Max(first.Y1, second.Y1);

                if (width <= 0 || height <= 0)
                {
                    return 0;
                }

                double area_Intersection = width * height;
                double area_Union = ((first.X2 - first.X1) * (first.Y2 - first.Y1)) + ((second.X2 - second.X1) * (second.Y2 - second.Y1)) - area_Intersection;

                return area_Union <= 0 ? 0 : area_Intersection / area_Union;
            }

            double iou_Maximum = yOLOONNXPredictionOptions.IoU;
            int count_Maximum = yOLOONNXPredictionOptions.MaxDetections;

            bool[] suppressed = new bool[candidates.Count];

            List<BoundingBoxResult> result = [];

            double scale = letterBox.Scale;
            double offsetX = letterBox.OffsetX;
            double offsetY = letterBox.OffsetY;
            double sourceWidth = letterBox.SourceWidth;
            double sourceHeight = letterBox.SourceHeight;

            for (int i = 0; i < candidates.Count && result.Count < count_Maximum; i++)
            {
                if (suppressed[i])
                {
                    continue;
                }

                for (int j = i + 1; j < candidates.Count; j++)
                {
                    //Boxes of different classes never suppress one another, which is what ultralytics achieves by pushing each class into its own region of the plane first
                    if (suppressed[j] || candidates[j].LabelIndex != candidates[i].LabelIndex)
                    {
                        continue;
                    }

                    if (IntersectionOverUnion(candidates[i], candidates[j]) > iou_Maximum)
                    {
                        suppressed[j] = true;
                    }
                }

                double x1 = Math.Min(Math.Max((candidates[i].X1 - offsetX) / scale, 0), sourceWidth);
                double y1 = Math.Min(Math.Max((candidates[i].Y1 - offsetY) / scale, 0), sourceHeight);
                double x2 = Math.Min(Math.Max((candidates[i].X2 - offsetX) / scale, 0), sourceWidth);
                double y2 = Math.Min(Math.Max((candidates[i].Y2 - offsetY) / scale, 0), sourceHeight);

                result.Add(new BoundingBoxResult(name, candidates[i].LabelIndex, x1, y1, x2 - x1, y2 - y1, candidates[i].Confidence));
            }

            return result;
        }
    }
}
