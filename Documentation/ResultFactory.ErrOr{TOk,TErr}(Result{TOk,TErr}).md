#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.ErrOr<TOk,TErr>(this Result<TOk,TErr>) Method

Gets the value of the [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') by casting into [TErr](ResultFactory.ErrOr{TOk,TErr}(Result{TOk,TErr}).md#Emik.Results.Extensions.ResultFactory.ErrOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr').

```csharp
public static TErr ErrOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr> result)
    where TOk : TErr;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.ErrOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.ErrOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.ErrOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).result'></a>

`result` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.ErrOr{TOk,TErr}(Result{TOk,TErr}).md#Emik.Results.Extensions.ResultFactory.ErrOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.ErrOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.ErrOr{TOk,TErr}(Result{TOk,TErr}).md#Emik.Results.Extensions.ResultFactory.ErrOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

The result parameter.

#### Returns
[TErr](ResultFactory.ErrOr{TOk,TErr}(Result{TOk,TErr}).md#Emik.Results.Extensions.ResultFactory.ErrOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr')  
The value [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') as [TErr](ResultFactory.ErrOr{TOk,TErr}(Result{TOk,TErr}).md#Emik.Results.Extensions.ResultFactory.ErrOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr'),  
or [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

### Remarks
  
The generic parameter [TErr](ResultFactory.ErrOr{TOk,TErr}(Result{TOk,TErr}).md#Emik.Results.Extensions.ResultFactory.ErrOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr') must implement or inherit [TOk](ResultFactory.ErrOr{TOk,TErr}(Result{TOk,TErr}).md#Emik.Results.Extensions.ResultFactory.ErrOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.ErrOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk').