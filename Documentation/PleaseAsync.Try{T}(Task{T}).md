#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.Try<T>(this Task<T>) Method

Wraps a [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1') within a try-catch.

```csharp
public static System.Threading.Tasks.Task<Emik.Results.Result<T,System.Exception>> Try<T>(this System.Threading.Tasks.Task<T> task)
    where T : notnull;
```
#### Type parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_T_(thisSystem.Threading.Tasks.Task_T_).T'></a>

`T`

The returned value of the [System.Threading.Tasks.Task&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1').
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.Try_T_(thisSystem.Threading.Tasks.Task_T_).task'></a>

`task` [System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[T](PleaseAsync.Try{T}(Task{T}).md#Emik.Results.Extensions.PleaseAsync.Try_T_(thisSystem.Threading.Tasks.Task_T_).T 'Emik.Results.Extensions.PleaseAsync.Try<T>(this System.Threading.Tasks.Task<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')

The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') to invoke.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](PleaseAsync.Try{T}(Task{T}).md#Emik.Results.Extensions.PleaseAsync.Try_T_(thisSystem.Threading.Tasks.Task_T_).T 'Emik.Results.Extensions.PleaseAsync.Try<T>(this System.Threading.Tasks.Task<T>).T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The result of [task](PleaseAsync.Try{T}(Task{T}).md#Emik.Results.Extensions.PleaseAsync.Try_T_(thisSystem.Threading.Tasks.Task_T_).task 'Emik.Results.Extensions.PleaseAsync.Try<T>(this System.Threading.Tasks.Task<T>).task'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.