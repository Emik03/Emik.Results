#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.SetEquals(IEnumerable<TOk>) Method

Determines whether the current set and the specified collection contain the same elements.

```csharp
public bool SetEquals(System.Collections.Generic.IEnumerable<TOk> other);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.SetEquals(System.Collections.Generic.IEnumerable_TOk_).other'></a>

`other` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The collection to compare to the current set.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
[true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the current set is equal to [other](Result{TOk,TErr}.SetEquals(IEnumerable{TOk}).md#Emik.Results.Result_TOk,TErr_.SetEquals(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.SetEquals(System.Collections.Generic.IEnumerable<TOk>).other');  
            otherwise, [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[other](Result{TOk,TErr}.SetEquals(IEnumerable{TOk}).md#Emik.Results.Result_TOk,TErr_.SetEquals(System.Collections.Generic.IEnumerable_TOk_).other 'Emik.Results.Result<TOk,TErr>.SetEquals(System.Collections.Generic.IEnumerable<TOk>).other') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').