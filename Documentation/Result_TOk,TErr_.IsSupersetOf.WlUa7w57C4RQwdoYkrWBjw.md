#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.IsSupersetOf(IEnumerable<TOk>) Method

Determines whether the current set is a superset of a specified collection.

```csharp
public bool IsSupersetOf(System.Collections.Generic.IEnumerable<TOk> other);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.IsSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare to the current set.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the current set is a superset of [other](Result_TOk,TErr_.IsSupersetOf.WlUa7w57C4RQwdoYkrWBjw.md#Emik.Results.Result_TOk,TErr_.IsSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.IsSupersetOf(System.Collections.Generic.IEnumerable<TOk>).other');  
            otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[other](Result_TOk,TErr_.IsSupersetOf.WlUa7w57C4RQwdoYkrWBjw.md#Emik.Results.Result_TOk,TErr_.IsSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.IsSupersetOf(System.Collections.Generic.IEnumerable<TOk>).other') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

### Remarks
  
If [other](Result_TOk,TErr_.IsSupersetOf.WlUa7w57C4RQwdoYkrWBjw.md#Emik.Results.Result_TOk,TErr_.IsSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.IsSupersetOf(System.Collections.Generic.IEnumerable<TOk>).other') contains the same elements as the current set,  
the current set is still considered a superset of [other](Result_TOk,TErr_.IsSupersetOf.WlUa7w57C4RQwdoYkrWBjw.md#Emik.Results.Result_TOk,TErr_.IsSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.IsSupersetOf(System.Collections.Generic.IEnumerable<TOk>).other').  
  
This method always returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the current  
set has fewer elements than [other](Result_TOk,TErr_.IsSupersetOf.WlUa7w57C4RQwdoYkrWBjw.md#Emik.Results.Result_TOk,TErr_.IsSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.IsSupersetOf(System.Collections.Generic.IEnumerable<TOk>).other').