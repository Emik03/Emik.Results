#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.ErrOrCast<TOk,TErr>(this Result<TOk,TErr>) Method

Gets the value of the [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') by casting into [TErr](ResultFactory.ErrOrCast.gNm11yuJBXwIcab4OzxYTw.md#Emik.Results.Extensions.ResultFactory.ErrOrCast_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOrCast<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr').

```csharp
public static TErr ErrOrCast<TOk,TErr>(this Emik.Results.Result<TOk,TErr> result)
    where TOk : TErr;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.ErrOrCast_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.ErrOrCast_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.ErrOrCast_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).result'></a>

`result` [Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.ErrOrCast.gNm11yuJBXwIcab4OzxYTw.md#Emik.Results.Extensions.ResultFactory.ErrOrCast_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.ErrOrCast<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.ErrOrCast.gNm11yuJBXwIcab4OzxYTw.md#Emik.Results.Extensions.ResultFactory.ErrOrCast_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOrCast<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

The result parameter.

#### Returns
[TErr](ResultFactory.ErrOrCast.gNm11yuJBXwIcab4OzxYTw.md#Emik.Results.Extensions.ResultFactory.ErrOrCast_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOrCast<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr')  
The value [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err'), or [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') as [TErr](ResultFactory.ErrOrCast.gNm11yuJBXwIcab4OzxYTw.md#Emik.Results.Extensions.ResultFactory.ErrOrCast_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOrCast<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr').

### Remarks
  
The generic parameter [TOk](ResultFactory.ErrOrCast.gNm11yuJBXwIcab4OzxYTw.md#Emik.Results.Extensions.ResultFactory.ErrOrCast_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.ErrOrCast<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk') must implement or inherit [TErr](ResultFactory.ErrOrCast.gNm11yuJBXwIcab4OzxYTw.md#Emik.Results.Extensions.ResultFactory.ErrOrCast_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOrCast<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr').