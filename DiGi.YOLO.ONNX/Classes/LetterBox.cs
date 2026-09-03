using DiGi.YOLO.ONNX.Interfaces;

namespace DiGi.YOLO.ONNX.Classes
{
    /// <summary>
    /// Describes how one source image was fitted onto the square canvas the network is fed: the factor it was scaled by, the size it became, and the borders it was padded with.
    /// <para>This is ultralytics' own LetterBox transform, kept as an object because the detections come back in canvas pixels and have to be carried back to source pixels by exactly the inverse of what was applied. The border widths are held as the whole pixels that were actually added rather than as the halved remainder they were computed from, so the inverse cannot drift from the forward pass by a rounding.</para>
    /// <para>Build it with <see cref="Create.LetterBox(int, int, int)"/>.</para>
    /// </summary>
    public class LetterBox : IYOLOONNXObject
    {
        private readonly int height;
        private readonly int offsetX;
        private readonly int offsetY;
        private readonly double scale;
        private readonly int size;
        private readonly int sourceHeight;
        private readonly int sourceWidth;
        private readonly int width;

        /// <summary>
        /// Initializes a new instance of the <see cref="LetterBox"/> class.
        /// </summary>
        /// <param name="sourceWidth">The width of the source image, in pixels.</param>
        /// <param name="sourceHeight">The height of the source image, in pixels.</param>
        /// <param name="size">The side of the square canvas the source image is fitted onto, in pixels.</param>
        /// <param name="scale">The factor the source image is scaled by.</param>
        /// <param name="width">The width the scaled content occupies on the canvas, in pixels.</param>
        /// <param name="height">The height the scaled content occupies on the canvas, in pixels.</param>
        /// <param name="offsetX">The width of the border added on the left of the content, in pixels.</param>
        /// <param name="offsetY">The height of the border added above the content, in pixels.</param>
        public LetterBox(int sourceWidth, int sourceHeight, int size, double scale, int width, int height, int offsetX, int offsetY)
        {
            this.sourceWidth = sourceWidth;
            this.sourceHeight = sourceHeight;
            this.size = size;
            this.scale = scale;
            this.width = width;
            this.height = height;
            this.offsetX = offsetX;
            this.offsetY = offsetY;
        }

        /// <summary>
        /// Gets the height the scaled content occupies on the canvas, in pixels.
        /// </summary>
        public int Height
        {
            get
            {
                return height;
            }
        }

        /// <summary>
        /// Gets the width of the border added on the left of the content, in pixels.
        /// </summary>
        public int OffsetX
        {
            get
            {
                return offsetX;
            }
        }

        /// <summary>
        /// Gets the height of the border added above the content, in pixels.
        /// </summary>
        public int OffsetY
        {
            get
            {
                return offsetY;
            }
        }

        /// <summary>
        /// Gets the factor the source image is scaled by.
        /// </summary>
        public double Scale
        {
            get
            {
                return scale;
            }
        }

        /// <summary>
        /// Gets the side of the square canvas the source image is fitted onto, in pixels.
        /// </summary>
        public int Size
        {
            get
            {
                return size;
            }
        }

        /// <summary>
        /// Gets the height of the source image, in pixels.
        /// </summary>
        public int SourceHeight
        {
            get
            {
                return sourceHeight;
            }
        }

        /// <summary>
        /// Gets the width of the source image, in pixels.
        /// </summary>
        public int SourceWidth
        {
            get
            {
                return sourceWidth;
            }
        }

        /// <summary>
        /// Gets the width the scaled content occupies on the canvas, in pixels.
        /// </summary>
        public int Width
        {
            get
            {
                return width;
            }
        }
    }
}
