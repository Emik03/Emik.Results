#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.OkOr(TOk) Method

Gets the [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') value, or the parameter.

```csharp
public TOk OkOr(TOk def);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.OkOr(TOk).def'></a>

`def` [TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')

The default value if this [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')  
The value [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), or [def](Result{TOk,TErr}.OkOr(TOk).md#Emik.Results.Result_TOk,TErr_.OkOr(TOk).def 'Emik.Results.Result<TOk,TErr>.OkOr(TOk).def').

### Remarks
  
The default value is eagerly evaluated, use [OkOr(Converter&lt;TErr,TOk&gt;)](Result{TOk,TErr}.OkOr(Converter{TErr,TOk}).md 'Emik.Results.Result<TOk,TErr>.OkOr(System.Converter<TErr,TOk>)') for lazy evaluation.