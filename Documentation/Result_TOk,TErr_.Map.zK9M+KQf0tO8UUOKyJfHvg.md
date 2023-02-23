#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Map<T>(Converter<TOk,T>) Method

Applies a selector to [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') if [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') is set, leaving [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err') untouched.

```csharp
public Emik.Results.Result<T,TErr> Map<T>(System.Converter<TOk,T> converter);
```
#### Type parameters

<a name='Emik.Results.Result_TOk,TErr_.Map_T_(System.Converter_TOk,T_).T'></a>

`T`

The new [TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk') type.
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.Map_T_(System.Converter_TOk,T_).converter'></a>

`converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Result_TOk,TErr_.Map.zK9M+KQf0tO8UUOKyJfHvg.md#Emik.Results.Result_TOk,TErr_.Map_T_(System.Converter_TOk,T_).T 'Emik.Results.Result<TOk,TErr>.Map<T>(System.Converter<TOk,T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The selector to change [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[T](Result_TOk,TErr_.Map.zK9M+KQf0tO8UUOKyJfHvg.md#Emik.Results.Result_TOk,TErr_.Map_T_(System.Converter_TOk,T_).T 'Emik.Results.Result<TOk,TErr>.Map<T>(System.Converter<TOk,T>).T')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
Another [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') with the result of [converter](Result_TOk,TErr_.Map.zK9M+KQf0tO8UUOKyJfHvg.md#Emik.Results.Result_TOk,TErr_.Map_T_(System.Converter_TOk,T_).converter 'Emik.Results.Result<TOk,TErr>.Map<T>(System.Converter<TOk,T>).converter')  
if this [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') is [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), otherwise [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err').