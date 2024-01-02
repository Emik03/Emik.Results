#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.TryErr<T>(Converter<TErr,T>) Method

Applies a selector to [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') if [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') is set, leaving [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') untouched.

```csharp
public Emik.Results.Result<TOk,Emik.Results.Result<T,System.Exception>> TryErr<T>(System.Converter<TErr,T> converter)
    where T : notnull;
```
#### Type parameters

<a name='Emik.Results.Result_TOk,TErr_.TryErr_T_(System.Converter_TErr,T_).T'></a>

`T`

The new [TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr') type.
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.TryErr_T_(System.Converter_TErr,T_).converter'></a>

`converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Result{TOk,TErr}.TryErr{T}(Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.TryErr_T_(System.Converter_TErr,T_).T 'Emik.Results.Result<TOk,TErr>.TryErr<T>(System.Converter<TErr,T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The selector to change [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result{TOk,TErr}.TryErr{T}(Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.TryErr_T_(System.Converter_TErr,T_).T 'Emik.Results.Result<TOk,TErr>.TryErr<T>(System.Converter<TErr,T>).T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
Another [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') with the result of [converter](Result{TOk,TErr}.TryErr{T}(Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.TryErr_T_(System.Converter_TErr,T_).converter 'Emik.Results.Result<TOk,TErr>.TryErr<T>(System.Converter<TErr,T>).converter')  
if this [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err'), otherwise [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').