#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.TryResult<T>(this Task<T>) Method

Wraps a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') within a try-catch.

```csharp
public static Emik.Results.Result<T,System.Exception> TryResult<T>(this System.Threading.Tasks.Task<T> task);
```
#### Type parameters

<a name='Emik.Results.Extensions.PleaseAsync.TryResult_T_(thisSystem.Threading.Tasks.Task_T_).T'></a>

`T`

The returned value of the [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1').
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.TryResult_T_(thisSystem.Threading.Tasks.Task_T_).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](PleaseAsync.TryResult(Task).md#Emik.Results.Extensions.PleaseAsync.TryResult_T_(thisSystem.Threading.Tasks.Task_T_).T 'Emik.Results.Extensions.PleaseAsync.TryResult<T>(this System.Threading.Tasks.Task<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') to invoke.

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[T](PleaseAsync.TryResult(Task).md#Emik.Results.Extensions.PleaseAsync.TryResult_T_(thisSystem.Threading.Tasks.Task_T_).T 'Emik.Results.Extensions.PleaseAsync.TryResult<T>(this System.Threading.Tasks.Task<T>).T')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
The result of [task](PleaseAsync.TryResult(Task).md#Emik.Results.Extensions.PleaseAsync.TryResult_T_(thisSystem.Threading.Tasks.Task_T_).task 'Emik.Results.Extensions.PleaseAsync.TryResult<T>(this System.Threading.Tasks.Task<T>).task'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.