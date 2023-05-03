#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.operator |(Result<TOk,TErr>, TErr) Operator

Gets the [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') value, or the parameter.

```csharp
public static TErr operator |(Emik.Results.Result<TOk,TErr> result, TErr def);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.op_BitwiseOr(Emik.Results.Result_TOk,TErr_,TErr).result'></a>

`result` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

<a name='Emik.Results.Result_TOk,TErr_.op_BitwiseOr(Emik.Results.Result_TOk,TErr_,TErr).def'></a>

`def` [TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')

The default value if this [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')  
The value [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), or [def](Result{TOk,TErr}.op_BitwiseOr(Result{TOk,TErr},TErr).md#Emik.Results.Result_TOk,TErr_.op_BitwiseOr(Emik.Results.Result_TOk,TErr_,TErr).def 'Emik.Results.Result<TOk,TErr>.op_BitwiseOr(Emik.Results.Result<TOk,TErr>, TErr).def').

### Remarks
  
The default value is eagerly evaluated, use [OkOr(Converter&lt;TErr,TOk&gt;)](Result{TOk,TErr}.OkOr(Converter{TErr,TOk}).md 'Emik.Results.Result<TOk,TErr>.OkOr(System.Converter<TErr,TOk>)') for lazy evaluation.