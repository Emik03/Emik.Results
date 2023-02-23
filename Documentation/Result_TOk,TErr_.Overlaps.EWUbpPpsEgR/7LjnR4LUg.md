#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Overlaps(IEnumerable<TOk>) Method

Determines whether the current set overlaps with the specified collection.

```csharp
public bool Overlaps(System.Collections.Generic.IEnumerable<TOk> other);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.Overlaps(System.Collections.Generic.IEnumerable_TOk_).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare to the current set.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the current set and [other](Result_TOk,TErr_.Overlaps.EWUbpPpsEgR//7LjnR4LUg.md#Emik.Results.Result_TOk,TErr_.Overlaps(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.Overlaps(System.Collections.Generic.IEnumerable<TOk>).other') share at least one common element;  
            otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[other](Result_TOk,TErr_.Overlaps.EWUbpPpsEgR//7LjnR4LUg.md#Emik.Results.Result_TOk,TErr_.Overlaps(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.Overlaps(System.Collections.Generic.IEnumerable<TOk>).other') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

### Remarks
  
Any duplicate elements in [other](Result_TOk,TErr_.Overlaps.EWUbpPpsEgR//7LjnR4LUg.md#Emik.Results.Result_TOk,TErr_.Overlaps(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.Overlaps(System.Collections.Generic.IEnumerable<TOk>).other') are ignored.