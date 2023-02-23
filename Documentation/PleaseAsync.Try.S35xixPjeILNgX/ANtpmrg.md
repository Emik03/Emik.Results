#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.Try<T>(Func<T,ValueTask>, T) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static System.Threading.Tasks.ValueTask<Emik.Results.Result<object?,System.Exception>> Try<T>(System.Func<T,System.Threading.Tasks.ValueTask> func, T first);
```
#### Type parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.ValueTask_,T).T'></a>

`T`

The type of the first parameter.
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.ValueTask_,T).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](PleaseAsync.Try.S35xixPjeILNgX/ANtpmrg.md#Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.ValueTask_,T).T 'Emik.Results.Extensions.PleaseAsync.Try<T>(System.Func<T,System.Threading.Tasks.ValueTask>, T).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.ValueTask_,T).first'></a>

`first` [T](PleaseAsync.Try.S35xixPjeILNgX/ANtpmrg.md#Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.ValueTask_,T).T 'Emik.Results.Extensions.PleaseAsync.Try<T>(System.Func<T,System.Threading.Tasks.ValueTask>, T).T')

The first parameter to invoke [func](PleaseAsync.Try.S35xixPjeILNgX/ANtpmrg.md#Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.ValueTask_,T).func 'Emik.Results.Extensions.PleaseAsync.Try<T>(System.Func<T,System.Threading.Tasks.ValueTask>, T).func') with.

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')  
The result of [func](PleaseAsync.Try.S35xixPjeILNgX/ANtpmrg.md#Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.ValueTask_,T).func 'Emik.Results.Extensions.PleaseAsync.Try<T>(System.Func<T,System.Threading.Tasks.ValueTask>, T).func'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.