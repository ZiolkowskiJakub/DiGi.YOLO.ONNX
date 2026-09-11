using DiGi.YOLO.Classes;
using DiGi.YOLO.ONNX.Classes;

namespace DiGi.YOLO.ONNX
{
    public static partial class Create
    {
        /// <summary>
        /// Parses the detections an in-process ONNX prediction run produced into a <see cref="YOLO.Classes.BoundingBoxResultFile"/> collection.
        /// <para>The parsing itself is <see cref="YOLO.Create.BoundingBoxResultFile(System.Collections.Generic.IEnumerable{string}?)"/>, unchanged. Both prediction paths write the same lines, so both are read back by the same reader - if that ever stopped being true, everything downstream would have to learn which path produced its input.</para>
        /// </summary>
        /// <param name="yOLOONNXPredictionResult">The result of the prediction run.</param>
        /// <returns>A <see cref="YOLO.Classes.BoundingBoxResultFile"/> instance containing the parsed results, or <c>null</c> when the run did not complete.</returns>
        public static BoundingBoxResultFile? BoundingBoxResultFile(this YOLOONNXPredictionResult? yOLOONNXPredictionResult)
        {
            if (yOLOONNXPredictionResult == null || !yOLOONNXPredictionResult.Succeeded)
            {
                return null;
            }

            return YOLO.Create.BoundingBoxResultFile(yOLOONNXPredictionResult.Values);
        }
    }
}
