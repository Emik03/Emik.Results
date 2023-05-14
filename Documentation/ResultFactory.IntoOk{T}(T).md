#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.IntoOk<T>(this T) Method

Maps [T](ResultFactory.IntoOk{T}(T).md#Emik.Results.Extensions.ResultFactory.IntoOk_T_(thisT).T 'Emik.Results.Extensions.ResultFactory.IntoOk<T>(this T).T') into a [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>').

```csharp
public static Emik.Results.Result<T,object> IntoOk<T>(this T? ok)
    where T : class;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoOk_T_(thisT).T'></a>

`T`

The success type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoOk_T_(thisT).ok'></a>

`ok` [T](ResultFactory.IntoOk{T}(T).md#Emik.Results.Extensions.ResultFactory.IntoOk_T_(thisT).T 'Emik.Results.Extensions.ResultFactory.IntoOk<T>(this T).T')

The value to pass in.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](ResultFactory.IntoOk{T}(T).md#Emik.Results.Extensions.ResultFactory.IntoOk_T_(thisT).T 'Emik.Results.Extensions.ResultFactory.IntoOk<T>(this T).T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') where [ok](ResultFactory.IntoOk{T}(T).md#Emik.Results.Extensions.ResultFactory.IntoOk_T_(thisT).ok 'Emik.Results.Extensions.ResultFactory.IntoOk<T>(this T).ok') is used if it isn't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'),  
or else [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').