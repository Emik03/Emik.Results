#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[PleaseAsync](PleaseAsync.md 'Emik.Results.Extensions.PleaseAsync')

## PleaseAsync.TryResult(this TaskAwaiter) Method

Wraps a [System.Runtime.CompilerServices.TaskAwaiter](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.TaskAwaiter 'System.Runtime.CompilerServices.TaskAwaiter') within a try-catch.

```csharp
public static Emik.Results.Result<object?,System.Exception> TryResult(this System.Runtime.CompilerServices.TaskAwaiter task);
```
#### Parameters

<a name='Emik.Results.Extensions.PleaseAsync.TryResult(thisSystem.Runtime.CompilerServices.TaskAwaiter).task'></a>

`task` [System.Runtime.CompilerServices.TaskAwaiter](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.CompilerServices.TaskAwaiter 'System.Runtime.CompilerServices.TaskAwaiter')

The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') to invoke.

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
The result of [task](PleaseAsync.TryResult.N55JcMDS1YBdII/3Dk3+cw.md#Emik.Results.Extensions.PleaseAsync.TryResult(thisSystem.Runtime.CompilerServices.TaskAwaiter).task 'Emik.Results.Extensions.PleaseAsync.TryResult(this System.Runtime.CompilerServices.TaskAwaiter).task'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.