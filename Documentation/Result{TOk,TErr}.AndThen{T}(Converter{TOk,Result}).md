#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.AndThen<T>(Converter<TOk,Result<T,TErr>>) Method

Applies a selector to [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') if [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') is set, leaving [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') untouched.

```csharp
public Emik.Results.Result<T,TErr> AndThen<T>(System.Converter<TOk,Emik.Results.Result<T,TErr>> converter);
```
#### Type parameters

<a name='Emik.Results.Result_TOk,TErr_.AndThen_T_(System.Converter_TOk,Emik.Results.Result_T,TErr__).T'></a>

`T`

The new [TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk') type.
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.AndThen_T_(System.Converter_TOk,Emik.Results.Result_T,TErr__).converter'></a>

`converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result{TOk,TErr}.AndThen{T}(Converter{TOk,Result}).md#Emik.Results.Result_TOk,TErr_.AndThen_T_(System.Converter_TOk,Emik.Results.Result_T,TErr__).T 'Emik.Results.Result<TOk,TErr>.AndThen<T>(System.Converter<TOk,Emik.Results.Result<T,TErr>>).T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The selector to change [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result{TOk,TErr}.AndThen{T}(Converter{TOk,Result}).md#Emik.Results.Result_TOk,TErr_.AndThen_T_(System.Converter_TOk,Emik.Results.Result_T,TErr__).T 'Emik.Results.Result<TOk,TErr>.AndThen<T>(System.Converter<TOk,Emik.Results.Result<T,TErr>>).T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
Another [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') with the result of [converter](Result{TOk,TErr}.AndThen{T}(Converter{TOk,Result}).md#Emik.Results.Result_TOk,TErr_.AndThen_T_(System.Converter_TOk,Emik.Results.Result_T,TErr__).converter 'Emik.Results.Result<TOk,TErr>.AndThen<T>(System.Converter<TOk,Emik.Results.Result<T,TErr>>).converter')  
if this [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') is [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), otherwise [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').