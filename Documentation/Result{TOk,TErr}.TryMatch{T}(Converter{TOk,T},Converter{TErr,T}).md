#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.TryMatch<T>(Converter<TOk,T>, Converter<TErr,T>) Method

Performs an exhaustive match statement.

```csharp
public Emik.Results.Result<T,System.Exception> TryMatch<T>(System.Converter<TOk,T> onOk, System.Converter<TErr,T> onErr)
    where T : notnull;
```
#### Type parameters

<a name='Emik.Results.Result_TOk,TErr_.TryMatch_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).T'></a>

`T`

The return value of both converters.
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.TryMatch_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).onOk'></a>

`onOk` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Result{TOk,TErr}.TryMatch{T}(Converter{TOk,T},Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.TryMatch_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).T 'Emik.Results.Result<TOk,TErr>.TryMatch<T>(System.Converter<TOk,T>, System.Converter<TErr,T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The delegate to invoke when [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

<a name='Emik.Results.Result_TOk,TErr_.TryMatch_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).onErr'></a>

`onErr` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Result{TOk,TErr}.TryMatch{T}(Converter{TOk,T},Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.TryMatch_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).T 'Emik.Results.Result<TOk,TErr>.TryMatch<T>(System.Converter<TOk,T>, System.Converter<TErr,T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The delegate to invoke when [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Result{TOk,TErr}.TryMatch{T}(Converter{TOk,T},Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.TryMatch_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).T 'Emik.Results.Result<TOk,TErr>.TryMatch<T>(System.Converter<TOk,T>, System.Converter<TErr,T>).T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [onOk](Result{TOk,TErr}.TryMatch{T}(Converter{TOk,T},Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.TryMatch_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).onOk 'Emik.Results.Result<TOk,TErr>.TryMatch<T>(System.Converter<TOk,T>, System.Converter<TErr,T>).onOk') if [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), otherwise the result of [onErr](Result{TOk,TErr}.TryMatch{T}(Converter{TOk,T},Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.TryMatch_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).onErr 'Emik.Results.Result<TOk,TErr>.TryMatch<T>(System.Converter<TOk,T>, System.Converter<TErr,T>).onErr').