#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.AndThenErr<T>(Converter<TErr,Result<TOk,T>>) Method

Applies a selector to [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') if [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') is set, leaving [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') untouched.

```csharp
public Emik.Results.Result<TOk,T> AndThenErr<T>(System.Converter<TErr,Emik.Results.Result<TOk,T>> converter);
```
#### Type parameters

<a name='Emik.Results.Result_TOk,TErr_.AndThenErr_T_(System.Converter_TErr,Emik.Results.Result_TOk,T__).T'></a>

`T`

The new [TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr') type.
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.AndThenErr_T_(System.Converter_TErr,Emik.Results.Result_TOk,T__).converter'></a>

`converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result{TOk,TErr}.AndThenErr{T}(Converter{TErr,Result{TOk,T}}).md#Emik.Results.Result_TOk,TErr_.AndThenErr_T_(System.Converter_TErr,Emik.Results.Result_TOk,T__).T 'Emik.Results.Result<TOk,TErr>.AndThenErr<T>(System.Converter<TErr,Emik.Results.Result<TOk,T>>).T')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The selector to change [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result{TOk,TErr}.AndThenErr{T}(Converter{TErr,Result{TOk,T}}).md#Emik.Results.Result_TOk,TErr_.AndThenErr_T_(System.Converter_TErr,Emik.Results.Result_TOk,T__).T 'Emik.Results.Result<TOk,TErr>.AndThenErr<T>(System.Converter<TErr,Emik.Results.Result<TOk,T>>).T')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
Another [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') with the result of [converter](Result{TOk,TErr}.AndThenErr{T}(Converter{TErr,Result{TOk,T}}).md#Emik.Results.Result_TOk,TErr_.AndThenErr_T_(System.Converter_TErr,Emik.Results.Result_TOk,T__).converter 'Emik.Results.Result<TOk,TErr>.AndThenErr<T>(System.Converter<TErr,Emik.Results.Result<TOk,T>>).converter')  
if this [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err'), otherwise [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').