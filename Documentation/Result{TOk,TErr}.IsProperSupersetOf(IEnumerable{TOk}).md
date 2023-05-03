#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.IsProperSupersetOf(IEnumerable<TOk>) Method

Determines whether the current set is a proper (strict) superset of a specified collection.

```csharp
public bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<TOk> other);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare to the current set.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the current set is a proper superset of [other](Result{TOk,TErr}.IsProperSupersetOf(IEnumerable{TOk}).md#Emik.Results.Result_TOk,TErr_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<TOk>).other');  
            otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[other](Result{TOk,TErr}.IsProperSupersetOf(IEnumerable{TOk}).md#Emik.Results.Result_TOk,TErr_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<TOk>).other') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

### Remarks
  
If the current set is a proper superset of [other](Result{TOk,TErr}.IsProperSupersetOf(IEnumerable{TOk}).md#Emik.Results.Result_TOk,TErr_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<TOk>).other'),  
[other](Result{TOk,TErr}.IsProperSupersetOf(IEnumerable{TOk}).md#Emik.Results.Result_TOk,TErr_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<TOk>).other') must have at least one element that the current set does not have.  
  
An empty set is a proper superset of any other collection. Therefore, this method returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool')  
if the current set is empty, unless the [other](Result{TOk,TErr}.IsProperSupersetOf(IEnumerable{TOk}).md#Emik.Results.Result_TOk,TErr_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<TOk>).other') parameter is also an empty set.  
  
This method always returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the current set is  
less than or equal to the number of elements in [other](Result{TOk,TErr}.IsProperSupersetOf(IEnumerable{TOk}).md#Emik.Results.Result_TOk,TErr_.IsProperSupersetOf(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.IsProperSupersetOf(System.Collections.Generic.IEnumerable<TOk>).other').