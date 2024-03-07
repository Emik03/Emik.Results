#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result](Result.md 'Emik.Results.Result')

## Result.Err<T>(T) Method

Creates an [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') value.

```csharp
public static Emik.Results.Result<Emik.Results.Unit,T> Err<T>(T err)
    where T : notnull;
```
#### Type parameters

<a name='Emik.Results.Result.Err_T_(T).T'></a>

`T`

The type of [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').
#### Parameters

<a name='Emik.Results.Result.Err_T_(T).err'></a>

`err` [T](Result.Err{T}(T).md#Emik.Results.Result.Err_T_(T).T 'Emik.Results.Result.Err<T>(T).T')

The value to pass into the [Result](Result.md 'Emik.Results.Result').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Unit](Unit.md 'Emik.Results.Unit')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result.Err{T}(T).md#Emik.Results.Result.Err_T_(T).T 'Emik.Results.Result.Err<T>(T).T')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') with [err](Result.Err{T}(T).md#Emik.Results.Result.Err_T_(T).err 'Emik.Results.Result.Err<T>(T).err') passed in.