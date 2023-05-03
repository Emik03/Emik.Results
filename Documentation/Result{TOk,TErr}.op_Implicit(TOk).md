#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.implicit operator Result<TOk,TErr>(TOk) Operator

Implicitly converts [TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk') into [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>').  
The success value is specified.

```csharp
public static Emik.Results.Result<TOk,TErr> implicit operator Result<TOk,TErr>(TOk ok);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.op_ImplicitEmik.Results.Result_TOk,TErr_(TOk).ok'></a>

`ok` [TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')

The success value to pass in.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
An encapsulation of the parameter [ok](Result{TOk,TErr}.op_Implicit(TOk).md#Emik.Results.Result_TOk,TErr_.op_ImplicitEmik.Results.Result_TOk,TErr_(TOk).ok 'Emik.Results.Result<TOk,TErr>.op_Implicit Emik.Results.Result<TOk,TErr>(TOk).ok').