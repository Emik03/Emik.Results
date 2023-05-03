#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Try<T>(Converter<TOk,T>) Method

Applies a selector to [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') if [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') is set, leaving [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') untouched.

```csharp
public Emik.Results.Result<Emik.Results.Result<T,System.Exception>,TErr> Try<T>(System.Converter<TOk,T> converter);
```
#### Type parameters

<a name='Emik.Results.Result_TOk,TErr_.Try_T_(System.Converter_TOk,T_).T'></a>

`T`

The new [TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk') type.
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.Try_T_(System.Converter_TOk,T_).converter'></a>

`converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Result{TOk,TErr}.Try{T}(Converter{TOk,T}).md#Emik.Results.Result_TOk,TErr_.Try_T_(System.Converter_TOk,T_).T 'Emik.Results.Result<TOk,TErr>.Try<T>(System.Converter<TOk,T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The selector to change [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result{TOk,TErr}.Try{T}(Converter{TOk,T}).md#Emik.Results.Result_TOk,TErr_.Try_T_(System.Converter_TOk,T_).T 'Emik.Results.Result<TOk,TErr>.Try<T>(System.Converter<TOk,T>).T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
Another [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') with the result of [converter](Result{TOk,TErr}.Try{T}(Converter{TOk,T}).md#Emik.Results.Result_TOk,TErr_.Try_T_(System.Converter_TOk,T_).converter 'Emik.Results.Result<TOk,TErr>.Try<T>(System.Converter<TOk,T>).converter')  
if this [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') is [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), otherwise [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').