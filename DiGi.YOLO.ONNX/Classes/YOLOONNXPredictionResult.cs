using DiGi.Core.Classes;
using DiGi.YOLO.ONNX.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.YOLO.ONNX.Classes
{
    /// <summary>
    /// Represents what one in-process ONNX prediction run did: how many images it scored, what it produced, and anything it has to say about a run that did not finish.
    /// <para>The detections are kept as the raw lines of the bounding box result file rather than as parsed objects, so that a result read back from JSON is the same result that was written, and so that it can be compared line for line against the file the CPython path writes. Parse them with <see cref="Create.BoundingBoxResultFile(YOLOONNXPredictionResult?)"/>.</para>
    /// </summary>
    public class YOLOONNXPredictionResult : SerializableResult, IYOLOONNXSerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(End))]
        private readonly DateTimeOffset? end;

        [JsonInclude, JsonPropertyName(nameof(ImageCount))]
        private readonly int imageCount;

        [JsonInclude, JsonPropertyName(nameof(Messages))]
        private readonly List<string>? messages;

        [JsonInclude, JsonPropertyName(nameof(OutputPath))]
        private readonly string? outputPath;

        [JsonInclude, JsonPropertyName(nameof(Start))]
        private readonly DateTimeOffset? start;

        [JsonInclude, JsonPropertyName(nameof(Values))]
        private readonly List<string>? values;

        /// <summary>
        /// Initializes a new instance of the <see cref="YOLOONNXPredictionResult"/> class.
        /// </summary>
        /// <param name="imageCount">The number of images found in the source directory.</param>
        /// <param name="outputPath">The path of the bounding box result file the run was told to write.</param>
        /// <param name="values">The lines of the bounding box result file the run produced, or <c>null</c> when it produced none.</param>
        /// <param name="messages">What the run has to say about itself, which for a run that finished is nothing.</param>
        /// <param name="start">The moment the run began.</param>
        /// <param name="end">The moment the run ended.</param>
        public YOLOONNXPredictionResult(int imageCount, string? outputPath, IEnumerable<string>? values, IEnumerable<string>? messages, DateTimeOffset? start, DateTimeOffset? end)
        {
            this.imageCount = imageCount;
            this.outputPath = outputPath;
            this.values = values == null ? null : new List<string>(values);
            this.messages = messages == null ? null : new List<string>(messages);
            this.start = start;
            this.end = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YOLOONNXPredictionResult"/> class by copying an existing result.
        /// </summary>
        /// <param name="yOLOONNXPredictionResult">The source result to copy from.</param>
        public YOLOONNXPredictionResult(YOLOONNXPredictionResult? yOLOONNXPredictionResult)
            : base(yOLOONNXPredictionResult)
        {
            if (yOLOONNXPredictionResult != null)
            {
                end = yOLOONNXPredictionResult.end;
                imageCount = yOLOONNXPredictionResult.imageCount;
                messages = yOLOONNXPredictionResult.messages == null ? null : new List<string>(yOLOONNXPredictionResult.messages);
                outputPath = yOLOONNXPredictionResult.outputPath;
                start = yOLOONNXPredictionResult.start;
                values = yOLOONNXPredictionResult.values == null ? null : new List<string>(yOLOONNXPredictionResult.values);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YOLOONNXPredictionResult"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the result data.</param>
        public YOLOONNXPredictionResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets how long the run took, or <c>null</c> when either end of it is unknown.
        /// </summary>
        [JsonIgnore]
        public TimeSpan? Duration
        {
            get
            {
                if (start == null || end == null)
                {
                    return null;
                }

                return end.Value - start.Value;
            }
        }

        /// <summary>
        /// Gets the moment the run ended.
        /// </summary>
        [JsonIgnore]
        public DateTimeOffset? End
        {
            get
            {
                return end;
            }
        }

        /// <summary>
        /// Gets the number of images found in the source directory.
        /// <para>Zero here on a run that succeeded is a run that had nothing to do, which is worth telling apart from a run that scored images and found nothing on them.</para>
        /// </summary>
        [JsonIgnore]
        public int ImageCount
        {
            get
            {
                return imageCount;
            }
        }

        /// <summary>
        /// Gets what the run has to say about itself - a missing source directory, a model that would not load, a cancellation. A run that finished says nothing.
        /// </summary>
        [JsonIgnore]
        public List<string>? Messages
        {
            get
            {
                return messages;
            }
        }

        /// <summary>
        /// Gets the path of the bounding box result file the run was told to write.
        /// </summary>
        [JsonIgnore]
        public string? OutputPath
        {
            get
            {
                return outputPath;
            }
        }

        /// <summary>
        /// Gets the moment the run began.
        /// </summary>
        [JsonIgnore]
        public DateTimeOffset? Start
        {
            get
            {
                return start;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the run completed and produced its result lines.
        /// </summary>
        [JsonIgnore]
        public bool Succeeded
        {
            get
            {
                return values != null;
            }
        }

        /// <summary>
        /// Gets the lines of the bounding box result file the run produced, or <c>null</c> when it produced none.
        /// <para>An empty list is a run that had no images to score; <c>null</c> is a run that did not finish.</para>
        /// </summary>
        [JsonIgnore]
        public List<string>? Values
        {
            get
            {
                return values;
            }
        }
    }
}
