#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.Try<T1,T2,T3,TResult>(Func<T1,T2,T3,ValueTask<TResult>>, T1, T2, T3) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static System.Threading.Tasks.ValueTask<Emik.Results.Result<TResult,System.Exception>> Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>> func, T1 first, T2 second, T3 third);
```
#### Type parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).T1'></a>

`T1`

The type of the first parameter.

<a name='Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).T2'></a>

`T2`

The type of the second parameter.

<a name='Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).T3'></a>

`T3`

The type of the third parameter.

<a name='Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).TResult'></a>

`TResult`

The type of the result of [func](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).func 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).func').
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T1](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).T1 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T2](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).T2 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T3](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).T3 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[TResult](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).TResult 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).first'></a>

`first` [T1](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).T1 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).T1')

The first parameter to invoke [func](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).func 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).func') with.

<a name='Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).second'></a>

`second` [T2](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).T2 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).T2')

The second parameter to invoke [func](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).func 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).func') with.

<a name='Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).third'></a>

`third` [T3](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).T3 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).T3')

The third parameter to invoke [func](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).func 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).func') with.

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TResult](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).TResult 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).TResult')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')  
The result of [func](PleaseAsync.Try{T1,T2,T3,TResult}(Func{T1,T2,T3,ValueTask},T1,T2,T3).md#Emik.Results.Extensions.PleaseAsync.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,System.Threading.Tasks.ValueTask_TResult__,T1,T2,T3).func 'Emik.Results.Extensions.PleaseAsync.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,System.Threading.Tasks.ValueTask<TResult>>, T1, T2, T3).func'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.