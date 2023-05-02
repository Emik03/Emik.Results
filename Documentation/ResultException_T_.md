#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results')

## ResultException<T> Class

Represents an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown by [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>').

```csharp
public sealed class ResultException<T> : System.Exception,
Emik.Results.IFatal
```
#### Type parameters

<a name='Emik.Results.ResultException_T_.T'></a>

`T`

The error value.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; ResultException<T>

Implements [IFatal](IFatal.md 'Emik.Results.IFatal')

### Remarks
  
Due to the philosophy of [ResultException&lt;T&gt;](ResultException_T_.md 'Emik.Results.ResultException<T>'), it is generally advised but not completely  
disallowed to catch this type, as it strongly indicates an unsalvageable program state.

| Properties | |
| :--- | :--- |
| [Value](ResultException_T_.Value().md 'Emik.Results.ResultException<T>.Value') | Gets the value. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Emik.Results.IFatal.Value](ResultException_T_.Emik.Results.IFatal.Value().md 'Emik.Results.ResultException<T>.Emik.Results.IFatal.Value') | Gets the value. |
