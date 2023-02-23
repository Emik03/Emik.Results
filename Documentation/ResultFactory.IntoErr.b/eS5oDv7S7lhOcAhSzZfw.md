#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.IntoErr<T>(this T) Method

Maps [T](ResultFactory.IntoErr.b/eS5oDv7S7lhOcAhSzZfw.md#Emik.Results.Extensions.ResultFactory.IntoErr_T_(thisT).T 'Emik.Results.Extensions.ResultFactory.IntoErr<T>(this T).T') into a [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>').

```csharp
public static Emik.Results.Result<object?,T> IntoErr<T>(this T? err)
    where T : class;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoErr_T_(thisT).T'></a>

`T`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoErr_T_(thisT).err'></a>

`err` [T](ResultFactory.IntoErr.b/eS5oDv7S7lhOcAhSzZfw.md#Emik.Results.Extensions.ResultFactory.IntoErr_T_(thisT).T 'Emik.Results.Extensions.ResultFactory.IntoErr<T>(this T).T')

The value to pass in.

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[T](ResultFactory.IntoErr.b/eS5oDv7S7lhOcAhSzZfw.md#Emik.Results.Extensions.ResultFactory.IntoErr_T_(thisT).T 'Emik.Results.Extensions.ResultFactory.IntoErr<T>(this T).T')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') where [err](ResultFactory.IntoErr.b/eS5oDv7S7lhOcAhSzZfw.md#Emik.Results.Extensions.ResultFactory.IntoErr_T_(thisT).err 'Emik.Results.Extensions.ResultFactory.IntoErr<T>(this T).err') is used if it isn't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'),  
or else [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').