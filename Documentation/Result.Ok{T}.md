#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result](Result.md 'Emik.Results.Result')

## Result.Ok<T>() Method

Creates an [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') value.

```csharp
public static Emik.Results.Result<object,T> Ok<T>()
    where T : notnull;
```
#### Type parameters

<a name='Emik.Results.Result.Ok_T_().T'></a>

`T`

The type of [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result.Ok{T}.md#Emik.Results.Result.Ok_T_().T 'Emik.Results.Result.Ok<T>().T')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') marked with [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').