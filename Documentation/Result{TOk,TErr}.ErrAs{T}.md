#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.ErrAs<T>() Method

Casts [TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr') into [T](Result{TOk,TErr}.ErrAs{T}.md#Emik.Results.Result_TOk,TErr_.ErrAs_T_().T 'Emik.Results.Result<TOk,TErr>.ErrAs<T>().T').

```csharp
public Emik.Results.Result<TOk,T?> ErrAs<T>()
    where T : class?;
```
#### Type parameters

<a name='Emik.Results.Result_TOk,TErr_.ErrAs_T_().T'></a>

`T`

The type parameter to convert [TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr') into.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result{TOk,TErr}.ErrAs{T}.md#Emik.Results.Result_TOk,TErr_.ErrAs_T_().T 'Emik.Results.Result<TOk,TErr>.ErrAs<T>().T')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The value  as [T](Result{TOk,TErr}.ErrAs{T}.md#Emik.Results.Result_TOk,TErr_.ErrAs_T_().T 'Emik.Results.Result<TOk,TErr>.ErrAs<T>().T').