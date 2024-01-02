#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.Flatten<TOk,TErr>(this Result<Result<TOk,TErr>,Result<TOk,TErr>>) Method

Maps the nested results into one result.

```csharp
public static Emik.Results.Result<TOk,TErr> Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,Emik.Results.Result<TOk,TErr>> result)
    where TOk : notnull
    where TErr : notnull;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr__).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr__).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr__).result'></a>

`result` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.Flatten{TOk,TErr}(Result{Result{TOk,TErr},Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr__).TOk 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,Emik.Results.Result<TOk,TErr>>).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.Flatten{TOk,TErr}(Result{Result{TOk,TErr},Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr__).TErr 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,Emik.Results.Result<TOk,TErr>>).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.Flatten{TOk,TErr}(Result{Result{TOk,TErr},Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr__).TOk 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,Emik.Results.Result<TOk,TErr>>).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.Flatten{TOk,TErr}(Result{Result{TOk,TErr},Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr__).TErr 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,Emik.Results.Result<TOk,TErr>>).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

The result parameter.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.Flatten{TOk,TErr}(Result{Result{TOk,TErr},Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr__).TOk 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,Emik.Results.Result<TOk,TErr>>).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.Flatten{TOk,TErr}(Result{Result{TOk,TErr},Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisEmik.Results.Result_Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr__).TErr 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this Emik.Results.Result<Emik.Results.Result<TOk,TErr>,Emik.Results.Result<TOk,TErr>>).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The nested results collapsing into one result.

### Remarks
  
The parameter must be a nested [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>').