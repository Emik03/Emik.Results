#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.TryErr<T>(Converter<TErr,T>) Method

Applies a selector to [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err') if [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err') is set, leaving [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok') untouched.

```csharp
public Emik.Results.Result<TOk,Emik.Results.Result<T,System.Exception>> TryErr<T>(System.Converter<TErr,T> converter);
```
#### Type parameters

<a name='Emik.Results.Result_TOk,TErr_.TryErr_T_(System.Converter_TErr,T_).T'></a>

`T`

The new [TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr') type.
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.TryErr_T_(System.Converter_TErr,T_).converter'></a>

`converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Result_TOk,TErr_.TryErr(Converter).md#Emik.Results.Result_TOk,TErr_.TryErr_T_(System.Converter_TErr,T_).T 'Emik.Results.Result<TOk,TErr>.TryErr<T>(System.Converter<TErr,T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The selector to change [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[T](Result_TOk,TErr_.TryErr(Converter).md#Emik.Results.Result_TOk,TErr_.TryErr_T_(System.Converter_TErr,T_).T 'Emik.Results.Result<TOk,TErr>.TryErr<T>(System.Converter<TErr,T>).T')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
Another [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') with the result of [converter](Result_TOk,TErr_.TryErr(Converter).md#Emik.Results.Result_TOk,TErr_.TryErr_T_(System.Converter_TErr,T_).converter 'Emik.Results.Result<TOk,TErr>.TryErr<T>(System.Converter<TErr,T>).converter')  
if this [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err'), otherwise [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok').