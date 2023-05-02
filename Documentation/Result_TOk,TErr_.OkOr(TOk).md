#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.OkOr(TOk) Method

Gets the [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok') value, or the parameter.

```csharp
public TOk OkOr(TOk def);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.OkOr(TOk).def'></a>

`def` [TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')

The default value if this [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')  
The value [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok'), or [def](Result_TOk,TErr_.OkOr(TOk).md#Emik.Results.Result_TOk,TErr_.OkOr(TOk).def 'Emik.Results.Result<TOk,TErr>.OkOr(TOk).def').

### Remarks
  
The default value is eagerly evaluated, use [OkOr(Converter&lt;TErr,TOk&gt;)](Result_TOk,TErr_.OkOr(Converter).md 'Emik.Results.Result<TOk,TErr>.OkOr(System.Converter<TErr,TOk>)') for lazy evaluation.