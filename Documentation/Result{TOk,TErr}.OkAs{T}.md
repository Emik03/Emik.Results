#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.OkAs<T>() Method

Casts [TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk') into [T](Result{TOk,TErr}.OkAs{T}.md#Emik.Results.Result_TOk,TErr_.OkAs_T_().T 'Emik.Results.Result<TOk,TErr>.OkAs<T>().T').

```csharp
public Emik.Results.Result<T?,TErr> OkAs<T>()
    where T : class?;
```
#### Type parameters

<a name='Emik.Results.Result_TOk,TErr_.OkAs_T_().T'></a>

`T`

The type parameter to convert [TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk') into.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result{TOk,TErr}.OkAs{T}.md#Emik.Results.Result_TOk,TErr_.OkAs_T_().T 'Emik.Results.Result<TOk,TErr>.OkAs<T>().T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The value  as [T](Result{TOk,TErr}.OkAs{T}.md#Emik.Results.Result_TOk,TErr_.OkAs_T_().T 'Emik.Results.Result<TOk,TErr>.OkAs<T>().T').