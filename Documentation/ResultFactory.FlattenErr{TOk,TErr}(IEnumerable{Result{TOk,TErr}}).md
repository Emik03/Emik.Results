#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.FlattenErr<TOk,TErr>(this IEnumerable<Result<TOk,TErr>>) Method

Returns all [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') values,  
or the first-found [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') if any exist.

```csharp
public static Emik.Results.Result<TOk,System.Collections.Generic.IEnumerable<TErr>> FlattenErr<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>> enumerable)
    where TOk : notnull
    where TErr : notnull;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.FlattenErr_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.FlattenErr_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.FlattenErr_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).enumerable'></a>

`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.FlattenErr{TOk,TErr}(IEnumerable{Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.FlattenErr_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TOk 'Emik.Results.Extensions.ResultFactory.FlattenErr<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>>).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.FlattenErr{TOk,TErr}(IEnumerable{Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.FlattenErr_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TErr 'Emik.Results.Extensions.ResultFactory.FlattenErr<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>>).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The iterable of results.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.FlattenErr{TOk,TErr}(IEnumerable{Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.FlattenErr_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TOk 'Emik.Results.Extensions.ResultFactory.FlattenErr<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>>).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TErr](ResultFactory.FlattenErr{TOk,TErr}(IEnumerable{Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.FlattenErr_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TErr 'Emik.Results.Extensions.ResultFactory.FlattenErr<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>>).TErr')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
All [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') values, or the first [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

### Remarks
  
The type must be an enumeration of results.