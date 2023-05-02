#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.TryMatch(Action<TOk>, Action<TErr>) Method

Performs an exhaustive match statement.

```csharp
public Emik.Results.Result<object?,System.Exception> TryMatch(System.Action<TOk> onOk, System.Action<TErr> onErr);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.TryMatch(System.Action_TOk_,System.Action_TErr_).onOk'></a>

`onOk` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The delegate to invoke when [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok').

<a name='Emik.Results.Result_TOk,TErr_.TryMatch(System.Action_TOk_,System.Action_TErr_).onErr'></a>

`onErr` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The delegate to invoke when [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
The result of [onOk](Result_TOk,TErr_.TryMatch(Action,Action).md#Emik.Results.Result_TOk,TErr_.TryMatch(System.Action_TOk_,System.Action_TErr_).onOk 'Emik.Results.Result<TOk,TErr>.TryMatch(System.Action<TOk>, System.Action<TErr>).onOk') if [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok'), otherwise the result of [onErr](Result_TOk,TErr_.TryMatch(Action,Action).md#Emik.Results.Result_TOk,TErr_.TryMatch(System.Action_TOk_,System.Action_TErr_).onErr 'Emik.Results.Result<TOk,TErr>.TryMatch(System.Action<TOk>, System.Action<TErr>).onErr').