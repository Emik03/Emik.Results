#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result](Result.md 'Emik.Results.Result')

## Result.Ok<T>(T) Method

Creates an [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') value.

```csharp
public static Emik.Results.Result<T,Emik.Results.Unit> Ok<T>(T ok)
    where T : notnull;
```
#### Type parameters

<a name='Emik.Results.Result.Ok_T_(T).T'></a>

`T`

The type of [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').
#### Parameters

<a name='Emik.Results.Result.Ok_T_(T).ok'></a>

`ok` [T](Result.Ok{T}(T).md#Emik.Results.Result.Ok_T_(T).T 'Emik.Results.Result.Ok<T>(T).T')

The value to pass into the [Result](Result.md 'Emik.Results.Result').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result.Ok{T}(T).md#Emik.Results.Result.Ok_T_(T).T 'Emik.Results.Result.Ok<T>(T).T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Unit](Unit.md 'Emik.Results.Unit')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') with [ok](Result.Ok{T}(T).md#Emik.Results.Result.Ok_T_(T).ok 'Emik.Results.Result.Ok<T>(T).ok') passed in.