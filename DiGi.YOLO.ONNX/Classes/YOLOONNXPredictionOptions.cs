using DiGi.Core.Classes;
using DiGi.YOLO.ONNX.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.YOLO.ONNX.Classes
{
    /// <summary>
    /// Provides the settings one in-process ONNX prediction run needs: which exported model it scores with, which images it reads, where it writes its results, and the thresholds the detections are filtered by.
    /// <para>The constructors only assign. Use <see cref="Create.YOLOONNXPredictionOptions(string?, string?, string?, double, double, int)"/> to tidy the paths and reject a combination that cannot make a run.</para>
    /// <para>Every default here reproduces what ultralytics applies when the matching argument is not passed, because the acceptance bar for this path is agreement with the CPython one rather than a detector of its own. Changing any of them makes the two paths answer differently by design.</para>
    /// </summary>
    public class YOLOONNXPredictionOptions : SerializableOptions, IYOLOONNXSerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="YOLOONNXPredictionOptions"/> class with default values.
        /// </summary>
        public YOLOONNXPredictionOptions()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YOLOONNXPredictionOptions"/> class by copying an existing options instance.
        /// </summary>
        /// <param name="yOLOONNXPredictionOptions">The source options instance to copy from.</param>
        public YOLOONNXPredictionOptions(YOLOONNXPredictionOptions? yOLOONNXPredictionOptions)
            : base(yOLOONNXPredictionOptions)
        {
            if (yOLOONNXPredictionOptions != null)
            {
                BatchSize = yOLOONNXPredictionOptions.BatchSize;
                Confidence = yOLOONNXPredictionOptions.Confidence;
                InputSize = yOLOONNXPredictionOptions.InputSize;
                IoU = yOLOONNXPredictionOptions.IoU;
                MaxDetections = yOLOONNXPredictionOptions.MaxDetections;
                ModelPath = yOLOONNXPredictionOptions.ModelPath;
                OutputPath = yOLOONNXPredictionOptions.OutputPath;
                SourceDirectory = yOLOONNXPredictionOptions.SourceDirectory;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="YOLOONNXPredictionOptions"/> class using a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing the configuration settings.</param>
        public YOLOONNXPredictionOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the number of images handed to the session in a single inference call.
        /// <para>Batching changes nothing about the detections - the network holds no state across images and its normalization is folded into the weights - so this is a throughput knob only. It is clamped to whatever fixed batch dimension the loaded model declares, which a model exported without dynamic axes pins to one.</para>
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(BatchSize))]
        public int BatchSize { get; set; } = 8;

        /// <summary>
        /// Gets or sets the confidence threshold a detection has to reach to be reported.
        /// <para>The default matches predict.py's own default. The weights are frozen, so this is the only knob over how much the detector reports.</para>
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Confidence))]
        public double Confidence { get; set; } = 0.1;

        /// <summary>
        /// Gets or sets the square side, in pixels, the images are letterboxed to before they are scored.
        /// <para>640 is the size the frozen weights were trained at and the size the ONNX export was taken at. A model exported without dynamic axes accepts no other value.</para>
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(InputSize))]
        public int InputSize { get; set; } = 640;

        /// <summary>
        /// Gets or sets the intersection-over-union threshold above which non-maximum suppression discards the weaker of two overlapping detections.
        /// <para>0.7 is ultralytics' own default. The CPython path never had to expose it because ultralytics applied it internally; this path has to state it to reproduce that path.</para>
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(IoU))]
        public double IoU { get; set; } = 0.7;

        /// <summary>
        /// Gets or sets the largest number of detections kept for one image after suppression.
        /// <para>300 is ultralytics' own default, applied after suppression and in descending confidence order.</para>
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(MaxDetections))]
        public int MaxDetections { get; set; } = 300;

        /// <summary>
        /// Gets or sets the path of the exported ONNX model the prediction scores with.
        /// <para>This is the ONNX export of the frozen checkpoint, not the checkpoint itself. Exporting it is a one-off preparation step that still needs ultralytics, which is why removing the Python dependency removes it from the run rather than from the repository.</para>
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(ModelPath))]
        public string? ModelPath { get; set; } = null;

        /// <summary>
        /// Gets or sets the path of the bounding box result file the prediction writes.
        /// <para>The file is opened for writing rather than appending, so re-running a source directory replaces the previous answer instead of doubling it.</para>
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(OutputPath))]
        public string? OutputPath { get; set; } = null;

        /// <summary>
        /// Gets or sets the directory holding the images to score.
        /// <para>The .jpg, .jpeg and .png files directly in the directory are read, in that order, and the directory is not descended into - the same set predict.py globs for, in the same order, so the two paths produce their result lines in the same order.</para>
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(SourceDirectory))]
        public string? SourceDirectory { get; set; } = null;
    }
}
