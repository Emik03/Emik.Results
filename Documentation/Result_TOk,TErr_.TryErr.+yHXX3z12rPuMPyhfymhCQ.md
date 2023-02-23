#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.TryErr(Action<TErr>) Method

Applies a selector to [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err') if [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err') is set, leaving [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') untouched.

```csharp
public Emik.Results.Result<TOk,Emik.Results.Result<object?,System.Exception>> TryErr(System.Action<TErr> action);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.TryErr(System.Action_TErr_).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The selector to change [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
Another [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') with the result of [action](Result_TOk,TErr_.TryErr.+yHXX3z12rPuMPyhfymhCQ.md#Emik.Results.Result_TOk,TErr_.TryErr(System.Action_TErr_).action 'Emik.Results.Result<TOk,TErr>.TryErr(System.Action<TErr>).action')  
if this [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err'), otherwise [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').