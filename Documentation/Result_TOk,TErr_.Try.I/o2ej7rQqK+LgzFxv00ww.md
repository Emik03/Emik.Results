#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Try(Action<TOk>) Method

Applies a selector to [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') if [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') is set, leaving [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err') untouched.

```csharp
public Emik.Results.Result<Emik.Results.Result<object?,System.Exception>,TErr> Try(System.Action<TOk> action);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.Try(System.Action_TOk_).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The selector to change [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
Another [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') with the result of [action](Result_TOk,TErr_.Try.I/o2ej7rQqK+LgzFxv00ww.md#Emik.Results.Result_TOk,TErr_.Try(System.Action_TOk_).action 'Emik.Results.Result<TOk,TErr>.Try(System.Action<TOk>).action')  
if this [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') is [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), otherwise [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err').