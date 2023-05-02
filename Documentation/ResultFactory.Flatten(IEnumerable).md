#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.Flatten<TOk,TErr>(this IEnumerable<Result<TOk,TErr>>) Method

Returns all [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok') values,  
or the first-found [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err') if any exist.

```csharp
public static Emik.Results.Result<System.Collections.Generic.IEnumerable<TOk>,TErr> Flatten<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>> enumerable);
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

`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.Flatten(IEnumerable).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TOk 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>>).TOk')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.Flatten(IEnumerable).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TErr 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>>).TErr')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The iterable of results.

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TOk](ResultFactory.Flatten(IEnumerable).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TOk 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>>).TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.Flatten(IEnumerable).md#Emik.Results.Extensions.ResultFactory.Flatten_TOk,TErr_(thisSystem.Collections.Generic.IEnumerable_Emik.Results.Result_TOk,TErr__).TErr 'Emik.Results.Extensions.ResultFactory.Flatten<TOk,TErr>(this System.Collections.Generic.IEnumerable<Emik.Results.Result<TOk,TErr>>).TErr')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
All [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok') values, or the first [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err').

### Remarks
  
The type must be an enumeration of results.