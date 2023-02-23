#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.ErrOr(TErr) Method

Gets the [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') value, or the parameter.

```csharp
public TErr ErrOr(TErr def);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.ErrOr(TErr).def'></a>

`def` [TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')

The default value if this [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')  
The value [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), or [def](Result_TOk,TErr_.ErrOr./lnKEPVU3XnRnF+0A9oOQQ.md#Emik.Results.Result_TOk,TErr_.ErrOr(TErr).def 'Emik.Results.Result<TOk,TErr>.ErrOr(TErr).def').

### Remarks
  
The default value is eagerly evaluated, use [OkOr(Converter&lt;TErr,TOk&gt;)](Result_TOk,TErr_.OkOr.EgpBcG5c4SaY0LbCQokaKA.md 'Emik.Results.Result<TOk,TErr>.OkOr(System.Converter<TErr,TOk>)') for lazy evaluation.