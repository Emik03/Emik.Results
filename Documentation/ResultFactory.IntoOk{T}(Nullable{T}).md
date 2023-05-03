#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.IntoOk<T>(this Nullable<T>) Method

Maps [T](ResultFactory.IntoOk{T}(Nullable{T}).md#Emik.Results.Extensions.ResultFactory.IntoOk_T_(thisSystem.Nullable_T_).T 'Emik.Results.Extensions.ResultFactory.IntoOk<T>(this System.Nullable<T>).T') into a [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>').

```csharp
public static Emik.Results.Result<T,object?> IntoOk<T>(this System.Nullable<T> ok)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoOk_T_(thisSystem.Nullable_T_).T'></a>

`T`

The success type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoOk_T_(thisSystem.Nullable_T_).ok'></a>

`ok` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](ResultFactory.IntoOk{T}(Nullable{T}).md#Emik.Results.Extensions.ResultFactory.IntoOk_T_(thisSystem.Nullable_T_).T 'Emik.Results.Extensions.ResultFactory.IntoOk<T>(this System.Nullable<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The value to pass in.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](ResultFactory.IntoOk{T}(Nullable{T}).md#Emik.Results.Extensions.ResultFactory.IntoOk_T_(thisSystem.Nullable_T_).T 'Emik.Results.Extensions.ResultFactory.IntoOk<T>(this System.Nullable<T>).T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') where [ok](ResultFactory.IntoOk{T}(Nullable{T}).md#Emik.Results.Extensions.ResultFactory.IntoOk_T_(thisSystem.Nullable_T_).ok 'Emik.Results.Extensions.ResultFactory.IntoOk<T>(this System.Nullable<T>).ok') is used if it isn't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'),  
or else [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').