#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.OkOrNew<TOk,TErr>(this Result<TOk,TErr>) Method

Gets [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), or calls the default constructor for [TOk](ResultFactory.OkOrNew.h3I2jq/VS3Q0d56rfLaU2Q.md#Emik.Results.Extensions.ResultFactory.OkOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.OkOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk').

```csharp
public static TOk OkOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr> result)
    where TOk : new();
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.OkOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.OkOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.OkOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).result'></a>

`result` [Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.OkOrNew.h3I2jq/VS3Q0d56rfLaU2Q.md#Emik.Results.Extensions.ResultFactory.OkOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.OkOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.OkOrNew.h3I2jq/VS3Q0d56rfLaU2Q.md#Emik.Results.Extensions.ResultFactory.OkOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.OkOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

The result parameter.

#### Returns
[TOk](ResultFactory.OkOrNew.h3I2jq/VS3Q0d56rfLaU2Q.md#Emik.Results.Extensions.ResultFactory.OkOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.OkOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk')  
The value [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), or the default constructor for [TOk](ResultFactory.OkOrNew.h3I2jq/VS3Q0d56rfLaU2Q.md#Emik.Results.Extensions.ResultFactory.OkOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.OkOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk').

### Remarks
  
The generic parameter [TOk](ResultFactory.OkOrNew.h3I2jq/VS3Q0d56rfLaU2Q.md#Emik.Results.Extensions.ResultFactory.OkOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.OkOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk') must have a public default constructor.