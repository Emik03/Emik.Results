#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.TryResult(this ValueTaskAwaiter) Method

Wraps a [System.Runtime.CompilerServices.TaskAwaiter](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.TaskAwaiter 'System.Runtime.CompilerServices.TaskAwaiter') within a try-catch.

```csharp
public static Emik.Results.Result<object?,System.Exception> TryResult(this System.Runtime.CompilerServices.ValueTaskAwaiter task);
```
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.TryResult(thisSystem.Runtime.CompilerServices.ValueTaskAwaiter).task'></a>

`task` [System.Runtime.CompilerServices.ValueTaskAwaiter](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.ValueTaskAwaiter 'System.Runtime.CompilerServices.ValueTaskAwaiter')

The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') to invoke.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [task](PleaseAsync.TryResult(ValueTaskAwaiter).md#Emik.Results.Extensions.PleaseAsync.TryResult(thisSystem.Runtime.CompilerServices.ValueTaskAwaiter).task 'Emik.Results.Extensions.PleaseAsync.TryResult(this System.Runtime.CompilerServices.ValueTaskAwaiter).task'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.