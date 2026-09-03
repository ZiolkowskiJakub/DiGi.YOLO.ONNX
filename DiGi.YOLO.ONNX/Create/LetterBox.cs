using System;

namespace DiGi.YOLO.ONNX
{
    public static partial class Create
    {
        /// <summary>
        /// Works out how a source image of the given size is fitted onto a square canvas of the given side, reproducing ultralytics' own LetterBox transform.
        /// <para>The image is scaled by the smaller of the two ratios so that it fits whole, then centred and padded. The scale is never capped at one, because ultralytics lets a smaller image be enlarged - the images this pipeline scores are 320 pixels square and are enlarged to 640, so a guard against upscaling would silently halve the input the frozen detector was trained to see.</para>
        /// <para>The border widths are rounded the way ultralytics rounds them, away from the half remainder by a tenth of a pixel and to even on a tie, so that the mapping back through <see cref="Query.Detections(float[], int[], int, string, Classes.LetterBox, Classes.YOLOONNXPredictionOptions)"/> undoes exactly what was applied.</para>
        /// </summary>
        /// <param name="sourceWidth">The width of the source image, in pixels.</param>
        /// <param name="sourceHeight">The height of the source image, in pixels.</param>
        /// <param name="size">The side of the square canvas the source image is fitted onto, in pixels.</param>
        /// <returns>The transform, or <c>null</c> when any of the sizes is not a positive number of pixels.</returns>
        public static Classes.LetterBox? LetterBox(int sourceWidth, int sourceHeight, int size)
        {
            if (sourceWidth < 1 || sourceHeight < 1 || size < 1)
            {
                return null;
            }

            double scale = Math.Min((double)size / sourceWidth, (double)size / sourceHeight);

            int width = (int)Math.Round(sourceWidth * scale, MidpointRounding.ToEven);
            int height = (int)Math.Round(sourceHeight * scale, MidpointRounding.ToEven);

            double remainderX = (size - width) / 2d;
            double remainderY = (size - height) / 2d;

            int offsetX = (int)Math.Round(remainderX - 0.1, MidpointRounding.ToEven);
            int offsetY = (int)Math.Round(remainderY - 0.1, MidpointRounding.ToEven);

            return new Classes.LetterBox(sourceWidth, sourceHeight, size, scale, width, height, offsetX, offsetY);
        }
    }
}
