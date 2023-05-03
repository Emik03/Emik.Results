#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Try(Action<TOk>) Method

Applies a selector to [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') if [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') is set, leaving [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') untouched.

```csharp
public Emik.Results.Result<Emik.Results.Result<object?,System.Exception>,TErr> Try(System.Action<TOk> action);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.Try(System.Action_TOk_).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The selector to change [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
Another [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') with the result of [action](Result{TOk,TErr}.Try(Action{TOk}).md#Emik.Results.Result_TOk,TErr_.Try(System.Action_TOk_).action 'Emik.Results.Result<TOk,TErr>.Try(System.Action<TOk>).action')  
if this [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') is [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), otherwise [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').