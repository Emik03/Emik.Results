#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.TryAwaiter(this ValueTask) Method

Wraps a [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') within a try-catch.

```csharp
public static Emik.Results.Result<System.Runtime.CompilerServices.ValueTaskAwaiter,System.Exception> TryAwaiter(this System.Threading.Tasks.ValueTask task);
```
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.TryAwaiter(thisSystem.Threading.Tasks.ValueTask).task'></a>

`task` [System.Threading.Tasks.ValueTask](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask 'System.Threading.Tasks.ValueTask')

The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') to invoke.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Runtime.CompilerServices.ValueTaskAwaiter](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.ValueTaskAwaiter 'System.Runtime.CompilerServices.ValueTaskAwaiter')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [task](PleaseAsync.TryAwaiter(ValueTask).md#Emik.Results.Extensions.PleaseAsync.TryAwaiter(thisSystem.Threading.Tasks.ValueTask).task 'Emik.Results.Extensions.PleaseAsync.TryAwaiter(this System.Threading.Tasks.ValueTask).task'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.