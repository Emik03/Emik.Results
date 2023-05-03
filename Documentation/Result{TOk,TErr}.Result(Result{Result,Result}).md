#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.implicit operator Result<TOk,TErr>(Result<Result<TOk,TErr>,Result<TOk,TErr>>) Operator

Maps the nested results into one result.

```csharp
public static Emik.Results.Result<TOk,TErr> implicit operator Result<TOk,TErr>(Emik.Results.Result<Emik.Results.Result<TOk,TErr>,Emik.Results.Result<TOk,TErr>> result);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.op_ImplicitEmik.Results.Result_TOk,TErr_(Emik.Results.Result_Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr__).result'></a>

`result` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

The result parameter.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The nested results collapsing into one result.

### Remarks
  
The parameter must be a nested [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>').