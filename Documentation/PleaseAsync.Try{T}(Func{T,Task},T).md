#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.Try<T>(Func<T,Task>, T) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static System.Threading.Tasks.Task<Emik.Results.Result<object?,System.Exception>> Try<T>(System.Func<T,System.Threading.Tasks.Task> func, T first);
```
#### Type parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.Task_,T).T'></a>

`T`

The type of the first parameter.
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.Task_,T).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](PleaseAsync.Try{T}(Func{T,Task},T).md#Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.Task_,T).T 'Emik.Results.Extensions.PleaseAsync.Try<T>(System.Func<T,System.Threading.Tasks.Task>, T).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.Task_,T).first'></a>

`first` [T](PleaseAsync.Try{T}(Func{T,Task},T).md#Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.Task_,T).T 'Emik.Results.Extensions.PleaseAsync.Try<T>(System.Func<T,System.Threading.Tasks.Task>, T).T')

The first parameter to invoke [func](PleaseAsync.Try{T}(Func{T,Task},T).md#Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.Task_,T).func 'Emik.Results.Extensions.PleaseAsync.Try<T>(System.Func<T,System.Threading.Tasks.Task>, T).func') with.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The result of [func](PleaseAsync.Try{T}(Func{T,Task},T).md#Emik.Results.Extensions.PleaseAsync.Try_T_(System.Func_T,System.Threading.Tasks.Task_,T).func 'Emik.Results.Extensions.PleaseAsync.Try<T>(System.Func<T,System.Threading.Tasks.Task>, T).func'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.