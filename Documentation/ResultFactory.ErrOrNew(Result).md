#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.ErrOrNew<TOk,TErr>(this Result<TOk,TErr>) Method

Gets [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err'), or calls the default constructor for [TErr](ResultFactory.ErrOrNew(Result).md#Emik.Results.Extensions.ResultFactory.ErrOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr').

```csharp
public static TErr ErrOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr> result)
    where TErr : new();
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.ErrOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.ErrOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.ErrOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).result'></a>

`result` [Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.ErrOrNew(Result).md#Emik.Results.Extensions.ResultFactory.ErrOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.ErrOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TOk')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.ErrOrNew(Result).md#Emik.Results.Extensions.ResultFactory.ErrOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

The result parameter.

#### Returns
[TErr](ResultFactory.ErrOrNew(Result).md#Emik.Results.Extensions.ResultFactory.ErrOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr')  
The value [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err'), or the default constructor for [TErr](ResultFactory.ErrOrNew(Result).md#Emik.Results.Extensions.ResultFactory.ErrOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr').

### Remarks
  
The generic parameter [TErr](ResultFactory.ErrOrNew(Result).md#Emik.Results.Extensions.ResultFactory.ErrOrNew_TOk,TErr_(thisEmik.Results.Result_TOk,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.ErrOrNew<TOk,TErr>(this Emik.Results.Result<TOk,TErr>).TErr') must have a public default constructor.