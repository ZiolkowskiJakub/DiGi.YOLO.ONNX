#### [DiGi\.YOLO\.ONNX](DiGi.YOLO.ONNX.Overview.md 'DiGi\.YOLO\.ONNX\.Overview')

## DiGi\.YOLO\.ONNX Namespace
### Classes

<a name='DiGi.YOLO.ONNX.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.YOLO.ONNX.Create.BoundingBoxResultFile(thisDiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult)'></a>

## Create\.BoundingBoxResultFile\(this YOLOONNXPredictionResult\) Method

Parses the detections an in\-process ONNX prediction run produced into a [DiGi\.YOLO\.Classes\.BoundingBoxResultFile](https://learn.microsoft.com/en-us/dotnet/api/digi.yolo.classes.boundingboxresultfile 'DiGi\.YOLO\.Classes\.BoundingBoxResultFile') collection\.

The parsing itself is [DiGi\.YOLO\.Create\.BoundingBoxResultFile\(System\.Collections\.Generic\.IEnumerable\{System\.String\}\)](https://learn.microsoft.com/en-us/dotnet/api/digi.yolo.create.boundingboxresultfile#digi-yolo-create-boundingboxresultfile(system-collections-generic-ienumerable{system-string}) 'DiGi\.YOLO\.Create\.BoundingBoxResultFile\(System\.Collections\.Generic\.IEnumerable\{System\.String\}\)'), unchanged. Both prediction paths write the same lines, so both are read back by the same reader - if that ever stopped being true, everything downstream would have to learn which path produced its input.

```csharp
public static DiGi.YOLO.Classes.BoundingBoxResultFile? BoundingBoxResultFile(this DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult? yOLOONNXPredictionResult);
```
#### Parameters

<a name='DiGi.YOLO.ONNX.Create.BoundingBoxResultFile(thisDiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult).yOLOONNXPredictionResult'></a>

`yOLOONNXPredictionResult` [YOLOONNXPredictionResult](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionResult')

The result of the prediction run\.

#### Returns
[DiGi\.YOLO\.Classes\.BoundingBoxResultFile](https://learn.microsoft.com/en-us/dotnet/api/digi.yolo.classes.boundingboxresultfile 'DiGi\.YOLO\.Classes\.BoundingBoxResultFile')  
A [DiGi\.YOLO\.Classes\.BoundingBoxResultFile](https://learn.microsoft.com/en-us/dotnet/api/digi.yolo.classes.boundingboxresultfile 'DiGi\.YOLO\.Classes\.BoundingBoxResultFile') instance containing the parsed results, or `null` when the run did not complete\.

<a name='DiGi.YOLO.ONNX.Create.LetterBox(int,int,int)'></a>

## Create\.LetterBox\(int, int, int\) Method

Works out how a source image of the given size is fitted onto a square canvas of the given side, reproducing ultralytics' own LetterBox transform\.

The image is scaled by the smaller of the two ratios so that it fits whole, then centred and padded. The scale is never capped at one, because ultralytics lets a smaller image be enlarged - the images this pipeline scores are 320 pixels square and are enlarged to 640, so a guard against upscaling would silently halve the input the frozen detector was trained to see.

The border widths are rounded the way ultralytics rounds them, away from the half remainder by a tenth of a pixel and to even on a tie, so that the mapping back through [Detections\(float\[\], int\[\], int, string, LetterBox, YOLOONNXPredictionOptions\)](DiGi.YOLO.ONNX.md#DiGi.YOLO.ONNX.Query.Detections(float[],int[],int,string,DiGi.YOLO.ONNX.Classes.LetterBox,DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions) 'DiGi\.YOLO\.ONNX\.Query\.Detections\(float\[\], int\[\], int, string, DiGi\.YOLO\.ONNX\.Classes\.LetterBox, DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions\)') undoes exactly what was applied.

```csharp
public static DiGi.YOLO.ONNX.Classes.LetterBox? LetterBox(int sourceWidth, int sourceHeight, int size);
```
#### Parameters

<a name='DiGi.YOLO.ONNX.Create.LetterBox(int,int,int).sourceWidth'></a>

`sourceWidth` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The width of the source image, in pixels\.

<a name='DiGi.YOLO.ONNX.Create.LetterBox(int,int,int).sourceHeight'></a>

`sourceHeight` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The height of the source image, in pixels\.

<a name='DiGi.YOLO.ONNX.Create.LetterBox(int,int,int).size'></a>

`size` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The side of the square canvas the source image is fitted onto, in pixels\.

#### Returns
[LetterBox](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.LetterBox 'DiGi\.YOLO\.ONNX\.Classes\.LetterBox')  
The transform, or `null` when any of the sizes is not a positive number of pixels\.

<a name='DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double)'></a>

## Create\.YOLOONNXPredictionOptions\(string, string, string, double\) Method

Builds the options for one in\-process ONNX prediction run, normalizing the paths and then checking that the combination can actually make a run\.

The [YOLOONNXPredictionOptions](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions') constructors only assign, so this is where the work belongs. The thresholds keep their defaults, which are the ones ultralytics applies.

```csharp
public static DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions? YOLOONNXPredictionOptions(string? modelPath, string? sourceDirectory, string? outputPath, double confidence=0.1);
```
#### Parameters

<a name='DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double).modelPath'></a>

`modelPath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path of the exported ONNX model to score with\.

<a name='DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double).sourceDirectory'></a>

`sourceDirectory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The directory holding the images to score\.

<a name='DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double).outputPath'></a>

`outputPath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path of the bounding box result file to write\.

<a name='DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double).confidence'></a>

`confidence` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The confidence threshold a detection has to reach to be reported\.

#### Returns
[YOLOONNXPredictionOptions](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions')  
The options, or `null` when a required path is missing or the confidence is not a value between zero and one\.

<a name='DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double,double,int)'></a>

## Create\.YOLOONNXPredictionOptions\(string, string, string, double, double, int\) Method

Builds the options for one in\-process ONNX prediction run with custom thresholds, normalizing the paths and then checking that the combination can actually make a run\.

The [YOLOONNXPredictionOptions](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions') constructors only assign, so this is where the work belongs.

Moving either threshold away from ultralytics' default makes this path answer differently from the CPython one on purpose. That is a legitimate thing to want and an illegitimate thing to do by accident, which is why they are parameters here rather than constants.

```csharp
public static DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions? YOLOONNXPredictionOptions(string? modelPath, string? sourceDirectory, string? outputPath, double confidence, double iou, int batchSize);
```
#### Parameters

<a name='DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double,double,int).modelPath'></a>

`modelPath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path of the exported ONNX model to score with\.

<a name='DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double,double,int).sourceDirectory'></a>

`sourceDirectory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The directory holding the images to score\.

<a name='DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double,double,int).outputPath'></a>

`outputPath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The path of the bounding box result file to write\.

<a name='DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double,double,int).confidence'></a>

`confidence` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The confidence threshold a detection has to reach to be reported\.

<a name='DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double,double,int).iou'></a>

`iou` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The overlap above which the weaker of two detections of the same class is discarded\.

<a name='DiGi.YOLO.ONNX.Create.YOLOONNXPredictionOptions(string,string,string,double,double,int).batchSize'></a>

`batchSize` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The number of images handed to the session in a single inference call\.

#### Returns
[YOLOONNXPredictionOptions](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions')  
The options, or `null` when a required path is missing, the confidence or the overlap is not a value between zero and one, or the batch size is less than one\.

<a name='DiGi.YOLO.ONNX.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.YOLO.ONNX.Modify.Predict(thisDiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions,System.Threading.CancellationToken)'></a>

## Modify\.Predict\(this YOLOONNXPredictionOptions, CancellationToken\) Method

Scores a directory of images against an exported ONNX model in this process and writes the detections to a bounding box result file\.

This is the in-process counterpart of [DiGi\.YOLO\.Modify\.Predict\(DiGi\.YOLO\.Classes\.YOLOPredictionOptions,System\.Threading\.CancellationToken\)](https://learn.microsoft.com/en-us/dotnet/api/digi.yolo.modify.predict#digi-yolo-modify-predict(digi-yolo-classes-yolopredictionoptions-system-threading-cancellationtoken) 'DiGi\.YOLO\.Modify\.Predict\(DiGi\.YOLO\.Classes\.YOLOPredictionOptions,System\.Threading\.CancellationToken\)'), which runs the same detector through a CPython interpreter. Everything observable is deliberately the same: the images are taken in the order predict.py globs them, an image with nothing on it gets a line carrying only its name, a detection is written as name, label, corner, extents and confidence, and a stale result file is removed before anything is written so a failed run cannot be mistaken for this one. A source directory holding no images is answered without loading the model at all.

Preprocessing goes through the same OpenCV that ultralytics calls through cv2 - the same JPEG decoder, the same bilinear resize - so the two paths differ only by the arithmetic of the graph itself rather than by what was fed into it.

An image that will not decode is reported in [Messages](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.Messages 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionResult\.Messages') and given a line carrying only its name. Ultralytics would end the run instead; this keeps the result file aligned one-for-one with the source listing, which is what everything downstream of it assumes.

There is one known divergence, and it is reported rather than left silent. For a batch of equally shaped images ultralytics letterboxes onto the smallest canvas that is a multiple of the model stride, which for a non-square image is not a square; this path always pads onto a square. Every image the pipeline scores is 320 pixels square, so the two are the same transform and the divergence has never applied - a non-square source puts a note in [Messages](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult.Messages 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionResult\.Messages') saying its detections may differ from the CPython path.

```csharp
public static DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult? Predict(this DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions? yOLOONNXPredictionOptions, System.Threading.CancellationToken cancellationToken=default(System.Threading.CancellationToken));
```
#### Parameters

<a name='DiGi.YOLO.ONNX.Modify.Predict(thisDiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions,System.Threading.CancellationToken).yOLOONNXPredictionOptions'></a>

`yOLOONNXPredictionOptions` [YOLOONNXPredictionOptions](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions')

The settings for the run\.

<a name='DiGi.YOLO.ONNX.Modify.Predict(thisDiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions,System.Threading.CancellationToken).cancellationToken'></a>

`cancellationToken` [System\.Threading\.CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken 'System\.Threading\.CancellationToken')

The token that cancels the run\.

#### Returns
[YOLOONNXPredictionResult](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionResult')  
The result of the run, or `null` when the options are missing the model, the source directory or the output path\.

<a name='DiGi.YOLO.ONNX.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.YOLO.ONNX.Query.Detections(float[],int[],int,string,DiGi.YOLO.ONNX.Classes.LetterBox,DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions)'></a>

## Query\.Detections\(float\[\], int\[\], int, string, LetterBox, YOLOONNXPredictionOptions\) Method

Turns one image's slice of a raw ONNX detection output into the detections the bounding box result file records\.

The network answers with one column per anchor holding a centred box in canvas pixels followed by a score for each class, already passed through a sigmoid. This filters those columns by confidence, suppresses overlapping boxes of the same class, keeps the strongest of what is left, and carries the survivors back to source pixels through the transform that put the image on the canvas.

Each step reproduces what ultralytics does after its own forward pass, including the order the detections come out in - descending confidence - and the cap on candidates it applies before suppressing anything. Suppression is done in floating point rather than on rounded rectangles, because a box rounded to whole pixels at canvas scale shifts its overlap enough to flip a suppression that sits near the threshold.

```csharp
public static System.Collections.Generic.List<DiGi.YOLO.Classes.BoundingBoxResult>? Detections(float[]? values, int[]? dimensions, int index, string? name, DiGi.YOLO.ONNX.Classes.LetterBox? letterBox, DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions? yOLOONNXPredictionOptions);
```
#### Parameters

<a name='DiGi.YOLO.ONNX.Query.Detections(float[],int[],int,string,DiGi.YOLO.ONNX.Classes.LetterBox,DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions).values'></a>

`values` [System\.Single](https://learn.microsoft.com/en-us/dotnet/api/system.single 'System\.Single')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The raw output buffer of one inference call, holding the whole batch\.

<a name='DiGi.YOLO.ONNX.Query.Detections(float[],int[],int,string,DiGi.YOLO.ONNX.Classes.LetterBox,DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions).dimensions'></a>

`dimensions` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The shape of that buffer: batch, four box values plus one score per class, then anchors\.

<a name='DiGi.YOLO.ONNX.Query.Detections(float[],int[],int,string,DiGi.YOLO.ONNX.Classes.LetterBox,DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The position of the image within the batch\.

<a name='DiGi.YOLO.ONNX.Query.Detections(float[],int[],int,string,DiGi.YOLO.ONNX.Classes.LetterBox,DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name recorded against every detection, which is the image's file name without its extension\.

<a name='DiGi.YOLO.ONNX.Query.Detections(float[],int[],int,string,DiGi.YOLO.ONNX.Classes.LetterBox,DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions).letterBox'></a>

`letterBox` [LetterBox](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.LetterBox 'DiGi\.YOLO\.ONNX\.Classes\.LetterBox')

The transform that put the image on the canvas, used to carry the detections back to source pixels\.

<a name='DiGi.YOLO.ONNX.Query.Detections(float[],int[],int,string,DiGi.YOLO.ONNX.Classes.LetterBox,DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions).yOLOONNXPredictionOptions'></a>

`yOLOONNXPredictionOptions` [YOLOONNXPredictionOptions](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions')

The settings holding the confidence, overlap and count thresholds to apply\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.YOLO\.Classes\.BoundingBoxResult](https://learn.microsoft.com/en-us/dotnet/api/digi.yolo.classes.boundingboxresult 'DiGi\.YOLO\.Classes\.BoundingBoxResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
The detections, ordered by descending confidence, or `null` when the buffer, its shape, the transform or the settings are missing or do not describe one another\.