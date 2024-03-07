#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result](Result.md 'Emik.Results.Result')

## Result.Err<T>() Method

Creates an [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') value.

```csharp
public static Emik.Results.Result<T,Emik.Results.Unit> Err<T>()
    where T : notnull;
```
#### Type parameters

<a name='Emik.Results.Result.Err_T_().T'></a>

`T`

The type of [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result.Err{T}.md#Emik.Results.Result.Err_T_().T 'Emik.Results.Result.Err<T>().T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Unit](Unit.md 'Emik.Results.Unit')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') marked with [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').