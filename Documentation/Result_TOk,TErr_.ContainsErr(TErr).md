#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.ContainsErr(TErr) Method

Performs an equality comparison between [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err') and the parameter,  
or [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public bool ContainsErr(TErr item);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.ContainsErr(TErr).item'></a>

`item` [TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')

The value to compare.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The result of the comparison of [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err'), or [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').