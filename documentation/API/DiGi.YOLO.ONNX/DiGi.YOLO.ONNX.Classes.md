#### [DiGi\.YOLO\.ONNX](DiGi.YOLO.ONNX.Overview.md 'DiGi\.YOLO\.ONNX\.Overview')

## DiGi\.YOLO\.ONNX\.Classes Namespace
### Classes

<a name='DiGi.YOLO.ONNX.Classes.LetterBox'></a>

## LetterBox Class

Describes how one source image was fitted onto the square canvas the network is fed: the factor it was scaled by, the size it became, and the borders it was padded with\.

This is ultralytics' own LetterBox transform, kept as an object because the detections come back in canvas pixels and have to be carried back to source pixels by exactly the inverse of what was applied. The border widths are held as the whole pixels that were actually added rather than as the halved remainder they were computed from, so the inverse cannot drift from the forward pass by a rounding.

Build it with [LetterBox\(int, int, int\)](DiGi.YOLO.ONNX.md#DiGi.YOLO.ONNX.Create.LetterBox(int,int,int) 'DiGi\.YOLO\.ONNX\.Create\.LetterBox\(int, int, int\)').

```csharp
public class LetterBox : DiGi.YOLO.ONNX.Interfaces.IYOLOONNXObject, DiGi.Core.Interfaces.IObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → LetterBox

Implements [IYOLOONNXObject](DiGi.YOLO.ONNX.Interfaces.md#DiGi.YOLO.ONNX.Interfaces.IYOLOONNXObject 'DiGi\.YOLO\.ONNX\.Interfaces\.IYOLOONNXObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')
### Constructors

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.LetterBox(int,int,int,double,int,int,int,int)'></a>

## LetterBox\(int, int, int, double, int, int, int, int\) Constructor

Initializes a new instance of the [LetterBox](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.LetterBox 'DiGi\.YOLO\.ONNX\.Classes\.LetterBox') class\.

```csharp
public LetterBox(int sourceWidth, int sourceHeight, int size, double scale, int width, int height, int offsetX, int offsetY);
```
#### Parameters

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.LetterBox(int,int,int,double,int,int,int,int).sourceWidth'></a>

`sourceWidth` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The width of the source image, in pixels\.

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.LetterBox(int,int,int,double,int,int,int,int).sourceHeight'></a>

`sourceHeight` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The height of the source image, in pixels\.

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.LetterBox(int,int,int,double,int,int,int,int).size'></a>

`size` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The side of the square canvas the source image is fitted onto, in pixels\.

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.LetterBox(int,int,int,double,int,int,int,int).scale'></a>

`scale` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The factor the source image is scaled by\.

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.LetterBox(int,int,int,double,int,int,int,int).width'></a>

`width` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The width the scaled content occupies on the canvas, in pixels\.

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.LetterBox(int,int,int,double,int,int,int,int).height'></a>

`height` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The height the scaled content occupies on the canvas, in pixels\.

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.LetterBox(int,int,int,double,int,int,int,int).offsetX'></a>

`offsetX` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The width of the border added on the left of the content, in pixels\.

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.LetterBox(int,int,int,double,int,int,int,int).offsetY'></a>

`offsetY` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The height of the border added above the content, in pixels\.
### Properties

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.Height'></a>

## LetterBox\.Height Property

Gets the height the scaled content occupies on the canvas, in pixels\.

```csharp
public int Height { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.OffsetX'></a>

## LetterBox\.OffsetX Property

Gets the width of the border added on the left of the content, in pixels\.

```csharp
public int OffsetX { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.OffsetY'></a>

## LetterBox\.OffsetY Property

Gets the height of the border added above the content, in pixels\.

```csharp
public int OffsetY { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.Scale'></a>

## LetterBox\.Scale Property

Gets the factor the source image is scaled by\.

```csharp
public double Scale { get; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.Size'></a>

## LetterBox\.Size Property

Gets the side of the square canvas the source image is fitted onto, in pixels\.

```csharp
public int Size { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.SourceHeight'></a>

## LetterBox\.SourceHeight Property

Gets the height of the source image, in pixels\.

```csharp
public int SourceHeight { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.SourceWidth'></a>

## LetterBox\.SourceWidth Property

Gets the width of the source image, in pixels\.

```csharp
public int SourceWidth { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.YOLO.ONNX.Classes.LetterBox.Width'></a>

## LetterBox\.Width Property

Gets the width the scaled content occupies on the canvas, in pixels\.

```csharp
public int Width { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions'></a>

## YOLOONNXPredictionOptions Class

Provides the settings one in\-process ONNX prediction run needs: which exported model it scores with, which images it reads, where it writes its results, and the thresholds the detections are filtered by\.

The constructors only assign. Use [YOLOONNXPredictionOptions\(string, string, string, double, double, int\)](DiGi.YOLO.ONNX.md#DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double,double,int) 'DiGi\.YOLO\.ONNX\.Create\.YOLOONNXPredictionOptions\(string, string, string, double, double, int\)') to tidy the paths and reject a combination that cannot make a run.

Every default here reproduces what ultralytics applies when the matching argument is not passed, because the acceptance bar for this path is agreement with the CPython one rather than a detector of its own. Changing any of them makes the two paths answer differently by design.

```csharp
public class YOLOONNXPredictionOptions : DiGi.Core.Classes.SerializableOptions, DiGi.YOLO.ONNX.Interfaces.IYOLOONNXSerializableObject, DiGi.YOLO.ONNX.Interfaces.IYOLOONNXObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → YOLOONNXPredictionOptions

Implements [IYOLOONNXSerializableObject](DiGi.YOLO.ONNX.Interfaces.md#DiGi.YOLO.ONNX.Interfaces.IYOLOONNXSerializableObject 'DiGi\.YOLO\.ONNX\.Interfaces\.IYOLOONNXSerializableObject'), [IYOLOONNXObject](DiGi.YOLO.ONNX.Interfaces.md#DiGi.YOLO.ONNX.Interfaces.IYOLOONNXObject 'DiGi\.YOLO\.ONNX\.Interfaces\.IYOLOONNXObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.YOLOONNXPredictionOptions()'></a>

## YOLOONNXPredictionOptions\(\) Constructor

Initializes a new instance of the [YOLOONNXPredictionOptions](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions') class with default values\.

```csharp
public YOLOONNXPredictionOptions();
```

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.YOLOONNXPredictionOptions(DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions)'></a>

## YOLOONNXPredictionOptions\(YOLOONNXPredictionOptions\) Constructor

Initializes a new instance of the [YOLOONNXPredictionOptions](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions') class by copying an existing options instance\.

```csharp
public YOLOONNXPredictionOptions(DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions? yOLOONNXPredictionOptions);
```
#### Parameters

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.YOLOONNXPredictionOptions(DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions).yOLOONNXPredictionOptions'></a>

`yOLOONNXPredictionOptions` [YOLOONNXPredictionOptions](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions')

The source options instance to copy from\.

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.YOLOONNXPredictionOptions(System.Text.Json.Nodes.JsonObject)'></a>

## YOLOONNXPredictionOptions\(JsonObject\) Constructor

Initializes a new instance of the [YOLOONNXPredictionOptions](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions') class using a JSON object\.

```csharp
public YOLOONNXPredictionOptions(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.YOLOONNXPredictionOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the configuration settings\.
### Properties

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.BatchSize'></a>

## YOLOONNXPredictionOptions\.BatchSize Property

Gets or sets the number of images handed to the session in a single inference call\.

Batching changes nothing about the detections - the network holds no state across images and its normalization is folded into the weights - so this is a throughput knob only. It is clamped to whatever fixed batch dimension the loaded model declares, which a model exported without dynamic axes pins to one.

```csharp
public int BatchSize { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.Confidence'></a>

## YOLOONNXPredictionOptions\.Confidence Property

Gets or sets the confidence threshold a detection has to reach to be reported\.

The default matches predict.py's own default. The weights are frozen, so this is the only knob over how much the detector reports.

```csharp
public double Confidence { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.InputSize'></a>

## YOLOONNXPredictionOptions\.InputSize Property

Gets or sets the square side, in pixels, the images are letterboxed to before they are scored\.

640 is the size the frozen weights were trained at and the size the ONNX export was taken at. A model exported without dynamic axes accepts no other value.

```csharp
public int InputSize { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.IoU'></a>

## YOLOONNXPredictionOptions\.IoU Property

Gets or sets the intersection\-over\-union threshold above which non\-maximum suppression discards the weaker of two overlapping detections\.

0.7 is ultralytics' own default. The CPython path never had to expose it because ultralytics applied it internally; this path has to state it to reproduce that path.

```csharp
public double IoU { get; set; }
```

#### Property Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.MaxDetections'></a>

## YOLOONNXPredictionOptions\.MaxDetections Property

Gets or sets the largest number of detections kept for one image after suppression\.

300 is ultralytics' own default, applied after suppression and in descending confidence order.

```csharp
public int MaxDetections { get; set; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.ModelPath'></a>

## YOLOONNXPredictionOptions\.ModelPath Property

Gets or sets the path of the exported ONNX model the prediction scores with\.

This is the ONNX export of the frozen checkpoint, not the checkpoint itself. Exporting it is a one-off preparation step that still needs ultralytics, which is why removing the Python dependency removes it from the run rather than from the repository.

```csharp
public string? ModelPath { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.OutputPath'></a>

## YOLOONNXPredictionOptions\.OutputPath Property

Gets or sets the path of the bounding box result file the prediction writes\.

The file is opened for writing rather than appending, so re-running a source directory replaces the previous answer instead of doubling it.

```csharp
public string? OutputPath { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions.SourceDirectory'></a>

## YOLOONNXPredictionOptions\.SourceDirectory Property

Gets or sets the directory holding the images to score\.

The .jpg, .jpeg and .png files directly in the directory are read, in that order, and the directory is not descended into - the same set predict.py globs for, in the same order, so the two paths produce their result lines in the same order.

```csharp
public string? SourceDirectory { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult'></a>

## YOLOONNXPredictionResult Class

Represents what one in\-process ONNX prediction run did: how many images it scored, what it produced, and anything it has to say about a run that did not finish\.

The detections are kept as the raw lines of the bounding box result file rather than as parsed objects, so that a result read back from JSON is the same result that was written, and so that it can be compared line for line against the file the CPython path writes. Parse them with [BoundingBoxResultFile\(this YOLOONNXPredictionResult\)](DiGi.YOLO.ONNX.md#DiGi.YOLO.ONNX.Create.BoundingBoxResultFile(thisDiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult) 'DiGi\.YOLO\.ONNX\.Create\.BoundingBoxResultFile\(this DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionResult\)').

```csharp
public class YOLOONNXPredictionResult : DiGi.Core.Classes.SerializableResult, DiGi.YOLO.ONNX.Interfaces.IYOLOONNXSerializableObject, DiGi.YOLO.ONNX.Interfaces.IYOLOONNXObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableResult](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableresult 'DiGi\.Core\.Classes\.SerializableResult') → YOLOONNXPredictionResult

Implements [IYOLOONNXSerializableObject](DiGi.YOLO.ONNX.Interfaces.md#DiGi.YOLO.ONNX.Interfaces.IYOLOONNXSerializableObject 'DiGi\.YOLO\.ONNX\.Interfaces\.IYOLOONNXSerializableObject'), [IYOLOONNXObject](DiGi.YOLO.ONNX.Interfaces.md#DiGi.YOLO.ONNX.Interfaces.IYOLOONNXObject 'DiGi\.YOLO\.ONNX\.Interfaces\.IYOLOONNXObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')
### Constructors

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.YOLOONNXPredictionResult(DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult)'></a>

## YOLOONNXPredictionResult\(YOLOONNXPredictionResult\) Constructor

Initializes a new instance of the [YOLOONNXPredictionResult](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionResult') class by copying an existing result\.

```csharp
public YOLOONNXPredictionResult(DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult? yOLOONNXPredictionResult);
```
#### Parameters

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.YOLOONNXPredictionResult(DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult).yOLOONNXPredictionResult'></a>

`yOLOONNXPredictionResult` [YOLOONNXPredictionResult](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionResult')

The source result to copy from\.

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.YOLOONNXPredictionResult(int,string,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_,System.Nullable_System.DateTimeOffset_)'></a>

## YOLOONNXPredictionResult\(int, string, IEnumerable\<string\>, IEnumerable\<string\>, Nullable\<DateTimeOffset\>, Nullable\<DateTimeOffset\>\) Constructor

Initializes a new instance of the [YOLOONNXPredictionResult](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionResult') class\.

```csharp
public YOLOONNXPredictionResult(int imageCount, string? outputPath, System.Collections.Generic.IEnumerable<string>? values, System.Collections.Generic.IEnumerable<string>? messages, System.Nullable<System.DateTimeOffset> start, System.Nullable<System.DateTimeOffset> end);
```
#### Parameters

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.YOLOONNXPredictionResult(int,string,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_,System.Nullable_System.DateTimeOffset_).imageCount'></a>

`imageCount` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of images found in the source directory\.

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.YOLOONNXPredictionResult(int,string,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_,System.Nullable_System.DateTimeOffset_).outputPath'></a>

`outputPath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path of the bounding box result file the run was told to write\.

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.YOLOONNXPredictionResult(int,string,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_,System.Nullable_System.DateTimeOffset_).values'></a>

`values` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The lines of the bounding box result file the run produced, or `null` when it produced none\.

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.YOLOONNXPredictionResult(int,string,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_,System.Nullable_System.DateTimeOffset_).messages'></a>

`messages` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

What the run has to say about itself, which for a run that finished is nothing\.

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.YOLOONNXPredictionResult(int,string,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_,System.Nullable_System.DateTimeOffset_).start'></a>

`start` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The moment the run began\.

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.YOLOONNXPredictionResult(int,string,System.Collections.Generic.IEnumerable_string_,System.Collections.Generic.IEnumerable_string_,System.Nullable_System.DateTimeOffset_,System.Nullable_System.DateTimeOffset_).end'></a>

`end` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The moment the run ended\.

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.YOLOONNXPredictionResult(System.Text.Json.Nodes.JsonObject)'></a>

## YOLOONNXPredictionResult\(JsonObject\) Constructor

Initializes a new instance of the [YOLOONNXPredictionResult](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionResult') class using a JSON object\.

```csharp
public YOLOONNXPredictionResult(System.Text.Json.Nodes.JsonObject? jsonObject);
```
#### Parameters

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.YOLOONNXPredictionResult(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object containing the result data\.
### Properties

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.Duration'></a>

## YOLOONNXPredictionResult\.Duration Property

Gets how long the run took, or `null` when either end of it is unknown\.

```csharp
public System.Nullable<System.TimeSpan> Duration { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.TimeSpan](https://learn.microsoft.com/en-us/dotnet/api/system.timespan 'System\.TimeSpan')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.End'></a>

## YOLOONNXPredictionResult\.End Property

Gets the moment the run ended\.

```csharp
public System.Nullable<System.DateTimeOffset> End { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.ImageCount'></a>

## YOLOONNXPredictionResult\.ImageCount Property

Gets the number of images found in the source directory\.

Zero here on a run that succeeded is a run that had nothing to do, which is worth telling apart from a run that scored images and found nothing on them.

```csharp
public int ImageCount { get; }
```

#### Property Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.Messages'></a>

## YOLOONNXPredictionResult\.Messages Property

Gets what the run has to say about itself \- a missing source directory, a model that would not load, a cancellation\. A run that finished says nothing\.

```csharp
public System.Collections.Generic.List<string>? Messages { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.OutputPath'></a>

## YOLOONNXPredictionResult\.OutputPath Property

Gets the path of the bounding box result file the run was told to write\.

```csharp
public string? OutputPath { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.Start'></a>

## YOLOONNXPredictionResult\.Start Property

Gets the moment the run began\.

```csharp
public System.Nullable<System.DateTimeOffset> Start { get; }
```

#### Property Value
[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.DateTimeOffset](https://learn.microsoft.com/en-us/dotnet/api/system.datetimeoffset 'System\.DateTimeOffset')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.Succeeded'></a>

## YOLOONNXPredictionResult\.Succeeded Property

Gets a value indicating whether the run completed and produced its result lines\.

```csharp
public bool Succeeded { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.Values'></a>

## YOLOONNXPredictionResult\.Values Property

Gets the lines of the bounding box result file the run produced, or `null` when it produced none\.

An empty list is a run that had no images to score; `null` is a run that did not finish.

```csharp
public System.Collections.Generic.List<string>? Values { get; }
```

#### Property Value
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')