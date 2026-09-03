#### [DiGi\.YOLO\.ONNX](DiGi.YOLO.ONNX.Overview.md 'DiGi\.YOLO\.ONNX\.Overview')

## DiGi\.YOLO\.ONNX\.Constants Namespace
### Classes

<a name='DiGi.YOLO.ONNX.Constants.Count'></a>

## Count Class

Provides the counts the in\-process prediction path is bounded by\.

```csharp
public static class Count
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Count
### Fields

<a name='DiGi.YOLO.ONNX.Constants.Count.MaximumInputElements'></a>

## Count\.MaximumInputElements Field

The largest number of floating point values one inference call is allowed to be handed, which is half a gigabyte of input\.

The batch size is clamped so that the input buffer stays inside this. Without the clamp a large batch is not merely slow: at 640 pixels square the element count passes what an [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32') can hold at around 1 750 images, so the array length wraps negative and the run dies on an arithmetic overflow rather than on anything that names the cause. The pipeline's own options carry a batch size in the thousands, meant for a different stage entirely, so this is a mistake something is very likely to make.

```csharp
public const int MaximumInputElements = 134217728;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.YOLO.ONNX.Constants.Count.MaximumSuppressionCandidates'></a>

## Count\.MaximumSuppressionCandidates Field

The largest number of candidate detections carried into non\-maximum suppression for one image\.

Ultralytics discards everything past this before suppressing anything, so a frame that somehow clears the confidence threshold on most of its anchors cannot turn a quadratic pass loose. Reproduced here because a run that suppressed a longer list would answer differently from the CPython path on exactly the frames that are hardest to explain.

```csharp
public const int MaximumSuppressionCandidates = 30000;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')