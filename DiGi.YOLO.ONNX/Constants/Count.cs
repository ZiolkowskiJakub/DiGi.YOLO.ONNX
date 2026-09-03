namespace DiGi.YOLO.ONNX.Constants
{
    /// <summary>
    /// Provides the counts the in-process prediction path is bounded by.
    /// </summary>
    public static class Count
    {
        /// <summary>
        /// The largest number of candidate detections carried into non-maximum suppression for one image.
        /// <para>Ultralytics discards everything past this before suppressing anything, so a frame that somehow clears the confidence threshold on most of its anchors cannot turn a quadratic pass loose. Reproduced here because a run that suppressed a longer list would answer differently from the CPython path on exactly the frames that are hardest to explain.</para>
        /// </summary>
        public const int MaximumSuppressionCandidates = 30000;

        /// <summary>
        /// The largest number of floating point values one inference call is allowed to be handed, which is half a gigabyte of input.
        /// <para>The batch size is clamped so that the input buffer stays inside this. Without the clamp a large batch is not merely slow: at 640 pixels square the element count passes what an <see cref="int"/> can hold at around 1 750 images, so the array length wraps negative and the run dies on an arithmetic overflow rather than on anything that names the cause. The pipeline's own options carry a batch size in the thousands, meant for a different stage entirely, so this is a mistake something is very likely to make.</para>
        /// </summary>
        public const int MaximumInputElements = 134217728;
    }
}
