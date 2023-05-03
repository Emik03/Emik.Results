#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.implicit operator Result<TOk,TErr>(TErr) Operator

Implicitly converts [TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr') into [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>').  
The error value is specified.

```csharp
public static Emik.Results.Result<TOk,TErr> implicit operator Result<TOk,TErr>(TErr err);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.op_ImplicitEmik.Results.Result_TOk,TErr_(TErr).err'></a>

`err` [TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')

The error value to pass in.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
An encapsulation of the parameter [err](Result{TOk,TErr}.Result(TErr).md#Emik.Results.Result_TOk,TErr_.op_ImplicitEmik.Results.Result_TOk,TErr_(TErr).err 'Emik.Results.Result<TOk,TErr>.op_Implicit Emik.Results.Result<TOk,TErr>(TErr).err').