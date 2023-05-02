#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result](Result.md 'Emik.Results.Result')

## Result.Err<T>(T) Method

Creates an [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err') value.

```csharp
public static Emik.Results.Result<object?,T> Err<T>(T err);
```
#### Type parameters

<a name='Emik.Results.Result.Err_T_(T).T'></a>

`T`

The type of [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err').
#### Parameters

<a name='Emik.Results.Result.Err_T_(T).err'></a>

`err` [T](Result.Err(T).md#Emik.Results.Result.Err_T_(T).T 'Emik.Results.Result.Err<T>(T).T')

The value to pass into the [Result](Result.md 'Emik.Results.Result').

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[T](Result.Err(T).md#Emik.Results.Result.Err_T_(T).T 'Emik.Results.Result.Err<T>(T).T')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') with [err](Result.Err(T).md#Emik.Results.Result.Err_T_(T).err 'Emik.Results.Result.Err<T>(T).err') passed in.