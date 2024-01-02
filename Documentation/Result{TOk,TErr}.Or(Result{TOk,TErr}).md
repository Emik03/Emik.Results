#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Or(Result<TOk,TErr>) Method

Gets itself, or the parameter.

```csharp
public Emik.Results.Result<TOk,TErr> Or(Emik.Results.Result<TOk,TErr> def);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.Or(Emik.Results.Result_TOk,TErr_).def'></a>

`def` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

The default value if this [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
Itself or [def](Result{TOk,TErr}.Or(Result{TOk,TErr}).md#Emik.Results.Result_TOk,TErr_.Or(Emik.Results.Result_TOk,TErr_).def 'Emik.Results.Result<TOk,TErr>.Or(Emik.Results.Result<TOk,TErr>).def').

### Remarks
  
The default value is eagerly evaluated,  
use [Or(Converter&lt;TErr,Result&lt;TOk,TErr&gt;&gt;)](Result{TOk,TErr}.Or(Converter{TErr,Result{TOk,TErr}}).md 'Emik.Results.Result<TOk,TErr>.Or(System.Converter<TErr,Emik.Results.Result<TOk,TErr>>)') for lazy evaluation.