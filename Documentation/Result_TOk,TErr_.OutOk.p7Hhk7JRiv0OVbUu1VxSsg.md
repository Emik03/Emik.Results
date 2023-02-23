#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.OutOk(TOk) Method

Useful for ternary operators to use a temporary value when [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') is set.

```csharp
public bool OutOk(out TOk? ok);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.OutOk(TOk).ok'></a>

`ok` [TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')

The success value.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [IsOk](Result_TOk,TErr_.IsOk.md 'Emik.Results.Result<TOk,TErr>.IsOk'), with nullability awareness for the out parameter.