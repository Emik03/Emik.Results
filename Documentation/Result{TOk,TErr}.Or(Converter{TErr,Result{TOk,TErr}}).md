#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Or(Converter<TErr,Result<TOk,TErr>>) Method

Gets itself, or the returned value of the parameter.

```csharp
public Emik.Results.Result<TOk,TErr> Or(System.Converter<TErr,Emik.Results.Result<TOk,TErr>> converter);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.Or(System.Converter_TErr,Emik.Results.Result_TOk,TErr__).converter'></a>

`converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The delegate to invoke and return if this [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
Itself or the result of [converter](Result{TOk,TErr}.Or(Converter{TErr,Result{TOk,TErr}}).md#Emik.Results.Result_TOk,TErr_.Or(System.Converter_TErr,Emik.Results.Result_TOk,TErr__).converter 'Emik.Results.Result<TOk,TErr>.Or(System.Converter<TErr,Emik.Results.Result<TOk,TErr>>).converter').

### Remarks
  
The default value is lazily evaluated, use [Or(Result&lt;TOk,TErr&gt;)](Result{TOk,TErr}.Or(Result{TOk,TErr}).md 'Emik.Results.Result<TOk,TErr>.Or(Emik.Results.Result<TOk,TErr>)') for eager evaluation.