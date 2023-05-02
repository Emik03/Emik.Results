#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.OkOr<TOk,TErr>(this Result<TOk,TErr>) Method

Gets the value of the [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') by casting into [TOk](ResultFactory.OkOr(Result).md#Emik.Results.Extensions.ResultFactory.OkOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.OkOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk').

```csharp
public static TOk OkOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr> result)
    where TErr : TOk;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.OkOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.OkOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.OkOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).result'></a>

`result` [Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.OkOr(Result).md#Emik.Results.Extensions.ResultFactory.OkOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.OkOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.OkOr(Result).md#Emik.Results.Extensions.ResultFactory.OkOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.OkOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

The result parameter.

#### Returns
[TOk](ResultFactory.OkOr(Result).md#Emik.Results.Extensions.ResultFactory.OkOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.OkOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk')  
The value [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok'),  
or [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err') as [TOk](ResultFactory.OkOr(Result).md#Emik.Results.Extensions.ResultFactory.OkOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.OkOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk').

### Remarks
  
The generic parameter [TErr](ResultFactory.OkOr(Result).md#Emik.Results.Extensions.ResultFactory.OkOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.OkOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr') must implement or inherit [TOk](ResultFactory.OkOr(Result).md#Emik.Results.Extensions.ResultFactory.OkOr_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.OkOr<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk').