#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.OutErr(TErr) Method

Useful for ternary operators to use a temporary value when [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') is set.

```csharp
public bool OutErr(out TErr? err);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.OutErr(TErr).err'></a>

`err` [TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')

The error value.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [IsErr](Result{TOk,TErr}.IsErr.md 'Emik.Results.Result<TOk,TErr>.IsErr'), with nullability awareness for the out parameter.