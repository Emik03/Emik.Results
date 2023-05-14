#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.IntoErr<T>(this Nullable<T>) Method

Maps [T](ResultFactory.IntoErr{T}(Nullable{T}).md#Emik.Results.Extensions.ResultFactory.IntoErr_T_(thisSystem.Nullable_T_).T 'Emik.Results.Extensions.ResultFactory.IntoErr<T>(this System.Nullable<T>).T') into a [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>').

```csharp
public static Emik.Results.Result<object,T> IntoErr<T>(this System.Nullable<T> err)
    where T : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoErr_T_(thisSystem.Nullable_T_).T'></a>

`T`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoErr_T_(thisSystem.Nullable_T_).err'></a>

`err` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[T](ResultFactory.IntoErr{T}(Nullable{T}).md#Emik.Results.Extensions.ResultFactory.IntoErr_T_(thisSystem.Nullable_T_).T 'Emik.Results.Extensions.ResultFactory.IntoErr<T>(this System.Nullable<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The value to pass in.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](ResultFactory.IntoErr{T}(Nullable{T}).md#Emik.Results.Extensions.ResultFactory.IntoErr_T_(thisSystem.Nullable_T_).T 'Emik.Results.Extensions.ResultFactory.IntoErr<T>(this System.Nullable<T>).T')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') where [err](ResultFactory.IntoErr{T}(Nullable{T}).md#Emik.Results.Extensions.ResultFactory.IntoErr_T_(thisSystem.Nullable_T_).err 'Emik.Results.Extensions.ResultFactory.IntoErr<T>(this System.Nullable<T>).err') is used if it isn't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'),  
or else [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').