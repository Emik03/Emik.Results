#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.operator |(Result<TOk,TErr>, TErr) Operator

Gets the [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok') value, or the parameter.

```csharp
public static TErr operator |(Emik.Results.Result<TOk,TErr> result, TErr def);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.op_BitwiseOr(Emik.Results.Result_TOk,TErr_,TErr).result'></a>

`result` [Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

<a name='Emik.Results.Result_TOk,TErr_.op_BitwiseOr(Emik.Results.Result_TOk,TErr_,TErr).def'></a>

`def` [TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')

The default value if this [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')  
The value [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok'), or [def](Result_TOk,TErr_.op_BitwiseOr(Result,TErr).md#Emik.Results.Result_TOk,TErr_.op_BitwiseOr(Emik.Results.Result_TOk,TErr_,TErr).def 'Emik.Results.Result<TOk,TErr>.op_BitwiseOr(Emik.Results.Result<TOk,TErr>, TErr).def').

### Remarks
  
The default value is eagerly evaluated, use [OkOr(Converter&lt;TErr,TOk&gt;)](Result_TOk,TErr_.OkOr(Converter).md 'Emik.Results.Result<TOk,TErr>.OkOr(System.Converter<TErr,TOk>)') for lazy evaluation.