#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Out(TOk, TErr) Method

Destructures the [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') into 2 optional values, [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok') and [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err').

```csharp
public bool Out(out TOk? ok, out TErr? err);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.Out(TOk,TErr).ok'></a>

`ok` [TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')

The success value.

<a name='Emik.Results.Result_TOk,TErr_.Out(TOk,TErr).err'></a>

`err` [TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')

The error value.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [IsOk](Result_TOk,TErr_.IsOk().md 'Emik.Results.Result<TOk,TErr>.IsOk'), with nullability awareness for the out parameters.