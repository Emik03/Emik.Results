#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.OkOr(Converter<TErr,TOk>) Method

Gets the [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') value, or the returned value of the parameter.

```csharp
public TOk OkOr(System.Converter<TErr,TOk> converter);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.OkOr(System.Converter_TErr,TOk_).converter'></a>

`converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The delegate to invoke and return if this [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')  
The value [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), or the result of [converter](Result{TOk,TErr}.OkOr(Converter{TErr,TOk}).md#Emik.Results.Result_TOk,TErr_.OkOr(System.Converter_TErr,TOk_).converter 'Emik.Results.Result<TOk,TErr>.OkOr(System.Converter<TErr,TOk>).converter').

### Remarks
  
The default value is lazily evaluated, use [OkOr(TOk)](Result{TOk,TErr}.OkOr(TOk).md 'Emik.Results.Result<TOk,TErr>.OkOr(TOk)') for eager evaluation.