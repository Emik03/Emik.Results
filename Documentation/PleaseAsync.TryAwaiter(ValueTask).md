#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.TryAwaiter<T>(this ValueTask<T>) Method

Wraps a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') within a try-catch.

```csharp
public static Emik.Results.Result<System.Runtime.CompilerServices.ValueTaskAwaiter<T>,System.Exception> TryAwaiter<T>(this System.Threading.Tasks.ValueTask<T> task);
```
#### Type parameters

<a name='Emik.Results.Extensions.PleaseAsync.TryAwaiter_T_(thisSystem.Threading.Tasks.ValueTask_T_).T'></a>

`T`

The returned value of the [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1').
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.TryAwaiter_T_(thisSystem.Threading.Tasks.ValueTask_T_).task'></a>

`task` [System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[T](PleaseAsync.TryAwaiter(ValueTask).md#Emik.Results.Extensions.PleaseAsync.TryAwaiter_T_(thisSystem.Threading.Tasks.ValueTask_T_).T 'Emik.Results.Extensions.PleaseAsync.TryAwaiter<T>(this System.Threading.Tasks.ValueTask<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')

The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') to invoke.

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Runtime.CompilerServices.ValueTaskAwaiter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.ValueTaskAwaiter-1 'System.Runtime.CompilerServices.ValueTaskAwaiter`1')[T](PleaseAsync.TryAwaiter(ValueTask).md#Emik.Results.Extensions.PleaseAsync.TryAwaiter_T_(thisSystem.Threading.Tasks.ValueTask_T_).T 'Emik.Results.Extensions.PleaseAsync.TryAwaiter<T>(this System.Threading.Tasks.ValueTask<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.ValueTaskAwaiter-1 'System.Runtime.CompilerServices.ValueTaskAwaiter`1')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
The result of [task](PleaseAsync.TryAwaiter(ValueTask).md#Emik.Results.Extensions.PleaseAsync.TryAwaiter_T_(thisSystem.Threading.Tasks.ValueTask_T_).task 'Emik.Results.Extensions.PleaseAsync.TryAwaiter<T>(this System.Threading.Tasks.ValueTask<T>).task'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.