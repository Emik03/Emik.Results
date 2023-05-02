#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.ErrOr(Converter<TOk,TErr>) Method

Gets the [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok') value, or the returned value of the parameter.

```csharp
public TErr ErrOr(System.Converter<TOk,TErr> converter);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.ErrOr(System.Converter_TOk,TErr_).converter'></a>

`converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TOk](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The delegate to invoke and return if this [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result_TOk,TErr_.Err().md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')  
The value [Ok](Result_TOk,TErr_.Ok().md 'Emik.Results.Result<TOk,TErr>.Ok'), or the result of [converter](Result_TOk,TErr_.ErrOr(Converter).md#Emik.Results.Result_TOk,TErr_.ErrOr(System.Converter_TOk,TErr_).converter 'Emik.Results.Result<TOk,TErr>.ErrOr(System.Converter<TOk,TErr>).converter').

### Remarks
  
The default value is lazily evaluated, use [OkOr(TOk)](Result_TOk,TErr_.OkOr(TOk).md 'Emik.Results.Result<TOk,TErr>.OkOr(TOk)') for eager evaluation.