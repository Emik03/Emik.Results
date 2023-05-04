#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.TryResult<T>(this TaskAwaiter<T>) Method

Wraps a [System.Runtime.CompilerServices.TaskAwaiter&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.TaskAwaiter-1 'System.Runtime.CompilerServices.TaskAwaiter`1') within a try-catch.

```csharp
public static Emik.Results.Result<T,System.Exception> TryResult<T>(this System.Runtime.CompilerServices.TaskAwaiter<T> task);
```
#### Type parameters

<a name='Emik.Results.Extensions.PleaseAsync.TryResult_T_(thisSystem.Runtime.CompilerServices.TaskAwaiter_T_).T'></a>

`T`

The returned value of the [System.Runtime.CompilerServices.TaskAwaiter&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.TaskAwaiter-1 'System.Runtime.CompilerServices.TaskAwaiter`1').
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.TryResult_T_(thisSystem.Runtime.CompilerServices.TaskAwaiter_T_).task'></a>

`task` [System.Runtime.CompilerServices.TaskAwaiter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.TaskAwaiter-1 'System.Runtime.CompilerServices.TaskAwaiter`1')[T](PleaseAsync.TryResult{T}(TaskAwaiter{T}).md#Emik.Results.Extensions.PleaseAsync.TryResult_T_(thisSystem.Runtime.CompilerServices.TaskAwaiter_T_).T 'Emik.Results.Extensions.PleaseAsync.TryResult<T>(this System.Runtime.CompilerServices.TaskAwaiter<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.TaskAwaiter-1 'System.Runtime.CompilerServices.TaskAwaiter`1')

The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') to invoke.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](PleaseAsync.TryResult{T}(TaskAwaiter{T}).md#Emik.Results.Extensions.PleaseAsync.TryResult_T_(thisSystem.Runtime.CompilerServices.TaskAwaiter_T_).T 'Emik.Results.Extensions.PleaseAsync.TryResult<T>(this System.Runtime.CompilerServices.TaskAwaiter<T>).T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [task](PleaseAsync.TryResult{T}(TaskAwaiter{T}).md#Emik.Results.Extensions.PleaseAsync.TryResult_T_(thisSystem.Runtime.CompilerServices.TaskAwaiter_T_).task 'Emik.Results.Extensions.PleaseAsync.TryResult<T>(this System.Runtime.CompilerServices.TaskAwaiter<T>).task'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.