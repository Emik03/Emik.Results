#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.Try<TResult>(Func<Task<TResult>>) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static System.Threading.Tasks.Task<Emik.Results.Result<TResult,System.Exception>> Try<TResult>(System.Func<System.Threading.Tasks.Task<TResult>> func);
```
#### Type parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).TResult'></a>

`TResult`

The type of the result of [func](PleaseAsync.Try{TResult}(Func{Task{TResult}}).md#Emik.Results.Extensions.PleaseAsync.Try_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).func 'Emik.Results.Extensions.PleaseAsync.Try<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>).func').
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResult](PleaseAsync.Try{TResult}(Func{Task{TResult}}).md#Emik.Results.Extensions.PleaseAsync.Try_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).TResult 'Emik.Results.Extensions.PleaseAsync.Try<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TResult](PleaseAsync.Try{TResult}(Func{Task{TResult}}).md#Emik.Results.Extensions.PleaseAsync.Try_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).TResult 'Emik.Results.Extensions.PleaseAsync.Try<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>).TResult')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The result of [func](PleaseAsync.Try{TResult}(Func{Task{TResult}}).md#Emik.Results.Extensions.PleaseAsync.Try_TResult_(System.Func_System.Threading.Tasks.Task_TResult__).func 'Emik.Results.Extensions.PleaseAsync.Try<TResult>(System.Func<System.Threading.Tasks.Task<TResult>>).func'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.