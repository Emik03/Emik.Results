#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.TryAwaiter<T>(this Task<T>) Method

Wraps a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') within a try-catch.

```csharp
public static Emik.Results.Result<System.Runtime.CompilerServices.TaskAwaiter<T>,System.Exception> TryAwaiter<T>(this System.Threading.Tasks.Task<T> task);
```
#### Type parameters

<a name='Emik.Results.Extensions.PleaseAsync.TryAwaiter_T_(thisSystem.Threading.Tasks.Task_T_).T'></a>

`T`

The returned value of the [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1').
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.TryAwaiter_T_(thisSystem.Threading.Tasks.Task_T_).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](PleaseAsync.TryAwaiter{T}(Task{T}).md#Emik.Results.Extensions.PleaseAsync.TryAwaiter_T_(thisSystem.Threading.Tasks.Task_T_).T 'Emik.Results.Extensions.PleaseAsync.TryAwaiter<T>(this System.Threading.Tasks.Task<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') to invoke.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Runtime.CompilerServices.TaskAwaiter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.TaskAwaiter-1 'System.Runtime.CompilerServices.TaskAwaiter`1')[T](PleaseAsync.TryAwaiter{T}(Task{T}).md#Emik.Results.Extensions.PleaseAsync.TryAwaiter_T_(thisSystem.Threading.Tasks.Task_T_).T 'Emik.Results.Extensions.PleaseAsync.TryAwaiter<T>(this System.Threading.Tasks.Task<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.TaskAwaiter-1 'System.Runtime.CompilerServices.TaskAwaiter`1')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [task](PleaseAsync.TryAwaiter{T}(Task{T}).md#Emik.Results.Extensions.PleaseAsync.TryAwaiter_T_(thisSystem.Threading.Tasks.Task_T_).task 'Emik.Results.Extensions.PleaseAsync.TryAwaiter<T>(this System.Threading.Tasks.Task<T>).task'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.