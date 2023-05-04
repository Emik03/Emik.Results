#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.TryAwaiter(this Task) Method

Wraps a [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') within a try-catch.

```csharp
public static Emik.Results.Result<System.Runtime.CompilerServices.TaskAwaiter,System.Exception> TryAwaiter(this System.Threading.Tasks.Task task);
```
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.TryAwaiter(thisSystem.Threading.Tasks.Task).task'></a>

`task` [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')

The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') to invoke.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Runtime.CompilerServices.TaskAwaiter](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.TaskAwaiter 'System.Runtime.CompilerServices.TaskAwaiter')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [task](PleaseAsync.TryAwaiter(Task).md#Emik.Results.Extensions.PleaseAsync.TryAwaiter(thisSystem.Threading.Tasks.Task).task 'Emik.Results.Extensions.PleaseAsync.TryAwaiter(this System.Threading.Tasks.Task).task'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.