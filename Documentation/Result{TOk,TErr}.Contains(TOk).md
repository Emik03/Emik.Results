#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Contains(TOk) Method

Performs an equality comparison between [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') and the parameter,  
or [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public bool Contains(TOk item);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.Contains(TOk).item'></a>

`item` [TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')

The value to compare.

Implements [Contains(T)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlySet-1.Contains#System_Collections_Generic_IReadOnlySet_1_Contains__0_ 'System.Collections.Generic.IReadOnlySet`1.Contains(`0)'), [Contains(T)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Contains#System_Collections_Generic_ICollection_1_Contains__0_ 'System.Collections.Generic.ICollection`1.Contains(`0)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the comparison of [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), or [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').