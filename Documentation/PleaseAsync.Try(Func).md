#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.Try<TResult>(Func<ValueTask<TResult>>) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static System.Threading.Tasks.ValueTask<Emik.Results.Result<TResult,System.Exception>> Try<TResult>(System.Func<System.Threading.Tasks.ValueTask<TResult>> func);
```
#### Type parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_TResult_(System.Func_System.Threading.Tasks.ValueTask_TResult__).TResult'></a>

`TResult`

The type of the result of [func](PleaseAsync.Try(Func).md#Emik.Results.Extensions.PleaseAsync.Try_TResult_(System.Func_System.Threading.Tasks.ValueTask_TResult__).func 'Emik.Results.Extensions.PleaseAsync.Try<TResult>(System.Func<System.Threading.Tasks.ValueTask<TResult>>).func').
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_TResult_(System.Func_System.Threading.Tasks.ValueTask_TResult__).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TResult](PleaseAsync.Try(Func).md#Emik.Results.Extensions.PleaseAsync.Try_TResult_(System.Func_System.Threading.Tasks.ValueTask_TResult__).TResult 'Emik.Results.Extensions.PleaseAsync.Try<TResult>(System.Func<System.Threading.Tasks.ValueTask<TResult>>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TResult](PleaseAsync.Try(Func).md#Emik.Results.Extensions.PleaseAsync.Try_TResult_(System.Func_System.Threading.Tasks.ValueTask_TResult__).TResult 'Emik.Results.Extensions.PleaseAsync.Try<TResult>(System.Func<System.Threading.Tasks.ValueTask<TResult>>).TResult')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')  
The result of [func](PleaseAsync.Try(Func).md#Emik.Results.Extensions.PleaseAsync.Try_TResult_(System.Func_System.Threading.Tasks.ValueTask_TResult__).func 'Emik.Results.Extensions.PleaseAsync.Try<TResult>(System.Func<System.Threading.Tasks.ValueTask<TResult>>).func'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.