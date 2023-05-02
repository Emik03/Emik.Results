#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.operator |(Result<TOk,TErr>, TOk) Operator

Gets the [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok') value, or the parameter.

```csharp
public static TOk operator |(Emik.Results.Result<TOk,TErr> result, TOk def);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.op_BitwiseOr(Emik.Results.Result_TOk,TErr_,TOk).result'></a>

`result` [Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

<a name='Emik.Results.Result_TOk,TErr_.op_BitwiseOr(Emik.Results.Result_TOk,TErr_,TOk).def'></a>

`def` [TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')

The default value if this [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')  
The value [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok'), or [def](Result_TOk,TErr_.op_BitwiseOr(Result,TOk).md#Emik.Results.Result_TOk,TErr_.op_BitwiseOr(Emik.Results.Result_TOk,TErr_,TOk).def 'Emik.Results.Result<TOk,TErr>.op_BitwiseOr(Emik.Results.Result<TOk,TErr>, TOk).def').

### Remarks
  
The default value is eagerly evaluated, use [OkOr(Converter&lt;TErr,TOk&gt;)](Result_TOk,TErr_.OkOr(Converter).md 'Emik.Results.Result<TOk,TErr>.OkOr(System.Converter<TErr,TOk>)') for lazy evaluation.