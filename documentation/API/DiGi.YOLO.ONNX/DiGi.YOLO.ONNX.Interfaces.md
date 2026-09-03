#### [DiGi\.YOLO\.ONNX](DiGi.YOLO.ONNX.Overview.md 'DiGi\.YOLO\.ONNX\.Overview')

## DiGi\.YOLO\.ONNX\.Interfaces Namespace
### Interfaces

<a name='DiGi.YOLO.ONNX.Interfaces.IYOLOONNXObject'></a>

## IYOLOONNXObject Interface

Marker interface implemented by every object belonging to the DiGi\.YOLO\.ONNX domain\.

```csharp
public interface IYOLOONNXObject : DiGi.Core.Interfaces.IObject
```

Derived  
↳ [LetterBox](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.LetterBox 'DiGi\.YOLO\.ONNX\.Classes\.LetterBox')  
↳ [YOLOONNXPredictionOptions](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions')  
↳ [YOLOONNXPredictionResult](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionResult')  
↳ [IYOLOONNXSerializableObject](DiGi.YOLO.ONNX.Interfaces.md#DiGi.YOLO.ONNX.Interfaces.IYOLOONNXSerializableObject 'DiGi\.YOLO\.ONNX\.Interfaces\.IYOLOONNXSerializableObject')

Implements [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject')

<a name='DiGi.YOLO.ONNX.Interfaces.IYOLOONNXSerializableObject'></a>

## IYOLOONNXSerializableObject Interface

Marker interface implemented by every DiGi\.YOLO\.ONNX object that can be serialized to and from JSON\.

```csharp
public interface IYOLOONNXSerializableObject : DiGi.YOLO.ONNX.Interfaces.IYOLOONNXObject, DiGi.Core.Interfaces.IObject, DiGi.Core.Interfaces.ISerializableObject, DiGi.Core.Interfaces.ICloneableObject<DiGi.Core.Interfaces.ISerializableObject>, DiGi.Core.Interfaces.ICloneableObject
```

Derived  
↳ [YOLOONNXPredictionOptions](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionOptions 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionOptions')  
↳ [YOLOONNXPredictionResult](DiGi.YOLO.ONNX.Classes.md#DiGi.YOLO.ONNX.Classes.YOLOONNXPredictionResult 'DiGi\.YOLO\.ONNX\.Classes\.YOLOONNXPredictionResult')

Implements [IYOLOONNXObject](DiGi.YOLO.ONNX.Interfaces.md#DiGi.YOLO.ONNX.Interfaces.IYOLOONNXObject 'DiGi\.YOLO\.ONNX\.Interfaces\.IYOLOONNXObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject'), [DiGi\.Core\.Interfaces\.ICloneableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1')[DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject-1 'DiGi\.Core\.Interfaces\.ICloneableObject\`1'), [DiGi\.Core\.Interfaces\.ICloneableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.icloneableobject 'DiGi\.Core\.Interfaces\.ICloneableObject')