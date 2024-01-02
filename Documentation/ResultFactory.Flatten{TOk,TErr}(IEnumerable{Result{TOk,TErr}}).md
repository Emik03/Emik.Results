#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.Flatten<TOk,TErr>(this IEnumerable<Result<TOk,TErr>>) Method

Returns all [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') values,  
or the first-found [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') if any exist.

```csharp
public static Emik.Results.Result<System.Collections.Generic.IList<TOk>,TErr> Flatten<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>> enumerable)
    where TOk : notnull
    where TErr : notnull;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).enumerable'></a>

`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.Flatten{TOk,TErr}(IEnumerable{Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TOk 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>>).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.Flatten{TOk,TErr}(IEnumerable{Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TErr 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>>).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The iterable of results.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[TOk](ResultFactory.Flatten{TOk,TErr}(IEnumerable{Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TOk 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>>).TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.Flatten{TOk,TErr}(IEnumerable{Result{TOk,TErr}}).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TErr 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>>).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
All [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') values, or the first [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

### Remarks
  
The type must be an enumeration of results.