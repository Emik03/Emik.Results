#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.Flatten<TOk,TErr>(this Result<Result<TOk,TErr>,TErr>) Method

Maps the nested results into one result.

```csharp
public static Emik.Results.Result<TOk,TErr> Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,TErr> result);
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,TErr_).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,TErr_).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,TErr_).result'></a>

`result` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.Flatten{TOk,TErr}(Result{Result,TErr}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,TErr>).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.Flatten{TOk,TErr}(Result{Result,TErr}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,TErr>).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.Flatten{TOk,TErr}(Result{Result,TErr}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,TErr>).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

The result parameter.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.Flatten{TOk,TErr}(Result{Result,TErr}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,TErr_).TOk 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,TErr>).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.Flatten{TOk,TErr}(Result{Result,TErr}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,TErr_).TErr 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,TErr>).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The nested results collapsing into one result.

### Remarks
  
The parameter must be a nested [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>').