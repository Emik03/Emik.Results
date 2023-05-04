#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.Try<T,TResult>(Func<T,Task<TResult>>, T) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static System.Threading.Tasks.Task<Emik.Results.Result<TResult,System.Exception>> Try<T,TResult>(System.Func<T,System.Threading.Tasks.Task<TResult>> func, T first);
```
#### Type parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_T,TResult_(System.Func_T,System.Threading.Tasks.Task_TResult__,T).T'></a>

`T`

The type of the first parameter.

<a name='Emik.Results.Extensions.PleaseAsync.Try_T,TResult_(System.Func_T,System.Threading.Tasks.Task_TResult__,T).TResult'></a>

`TResult`

The type of the result of [func](PleaseAsync.Try{T,TResult}(Func{T,Task},T).md#Emik.Results.Extensions.PleaseAsync.Try_T,TResult_(System.Func_T,System.Threading.Tasks.Task_TResult__,T).func 'Emik.Results.Extensions.PleaseAsync.Try<T,TResult>(System.Func<T,System.Threading.Tasks.Task<TResult>>, T).func').
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_T,TResult_(System.Func_T,System.Threading.Tasks.Task_TResult__,T).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](PleaseAsync.Try{T,TResult}(Func{T,Task},T).md#Emik.Results.Extensions.PleaseAsync.Try_T,TResult_(System.Func_T,System.Threading.Tasks.Task_TResult__,T).T 'Emik.Results.Extensions.PleaseAsync.Try<T,TResult>(System.Func<T,System.Threading.Tasks.Task<TResult>>, T).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResult](PleaseAsync.Try{T,TResult}(Func{T,Task},T).md#Emik.Results.Extensions.PleaseAsync.Try_T,TResult_(System.Func_T,System.Threading.Tasks.Task_TResult__,T).TResult 'Emik.Results.Extensions.PleaseAsync.Try<T,TResult>(System.Func<T,System.Threading.Tasks.Task<TResult>>, T).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Extensions.PleaseAsync.Try_T,TResult_(System.Func_T,System.Threading.Tasks.Task_TResult__,T).first'></a>

`first` [T](PleaseAsync.Try{T,TResult}(Func{T,Task},T).md#Emik.Results.Extensions.PleaseAsync.Try_T,TResult_(System.Func_T,System.Threading.Tasks.Task_TResult__,T).T 'Emik.Results.Extensions.PleaseAsync.Try<T,TResult>(System.Func<T,System.Threading.Tasks.Task<TResult>>, T).T')

The first parameter to invoke [func](PleaseAsync.Try{T,TResult}(Func{T,Task},T).md#Emik.Results.Extensions.PleaseAsync.Try_T,TResult_(System.Func_T,System.Threading.Tasks.Task_TResult__,T).func 'Emik.Results.Extensions.PleaseAsync.Try<T,TResult>(System.Func<T,System.Threading.Tasks.Task<TResult>>, T).func') with.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TResult](PleaseAsync.Try{T,TResult}(Func{T,Task},T).md#Emik.Results.Extensions.PleaseAsync.Try_T,TResult_(System.Func_T,System.Threading.Tasks.Task_TResult__,T).TResult 'Emik.Results.Extensions.PleaseAsync.Try<T,TResult>(System.Func<T,System.Threading.Tasks.Task<TResult>>, T).TResult')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The result of [func](PleaseAsync.Try{T,TResult}(Func{T,Task},T).md#Emik.Results.Extensions.PleaseAsync.Try_T,TResult_(System.Func_T,System.Threading.Tasks.Task_TResult__,T).func 'Emik.Results.Extensions.PleaseAsync.Try<T,TResult>(System.Func<T,System.Threading.Tasks.Task<TResult>>, T).func'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.