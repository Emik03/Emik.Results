#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.TryMatch(Action<TOk>, Action<TErr>) Method

Performs an exhaustive match statement.

```csharp
public Emik.Results.Result<Emik.Results.Unit,System.Exception> TryMatch(System.Action<TOk> onOk, System.Action<TErr> onErr);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.TryMatch(System.Action_TOk_,System.Action_TErr_).onOk'></a>

`onOk` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The delegate to invoke when [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

<a name='Emik.Results.Result_TOk,TErr_.TryMatch(System.Action_TOk_,System.Action_TErr_).onErr'></a>

`onErr` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The delegate to invoke when [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Unit](Unit.md 'Emik.Results.Unit')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [onOk](Result{TOk,TErr}.TryMatch(Action{TOk},Action{TErr}).md#Emik.Results.Result_TOk,TErr_.TryMatch(System.Action_TOk_,System.Action_TErr_).onOk 'Emik.Results.Result<TOk,TErr>.TryMatch(System.Action<TOk>, System.Action<TErr>).onOk') if [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), otherwise the result of [onErr](Result{TOk,TErr}.TryMatch(Action{TOk},Action{TErr}).md#Emik.Results.Result_TOk,TErr_.TryMatch(System.Action_TOk_,System.Action_TErr_).onErr 'Emik.Results.Result<TOk,TErr>.TryMatch(System.Action<TOk>, System.Action<TErr>).onErr').