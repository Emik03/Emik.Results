#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Match<T>(Converter<TOk,T>, Converter<TErr,T>) Method

Performs an exhaustive match statement.

```csharp
public T Match<T>(System.Converter<TOk,T> onOk, System.Converter<TErr,T> onErr);
```
#### Type parameters

<a name='Emik.Results.Result_TOk,TErr_.Match_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).T'></a>

`T`

The return value of both converters.
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.Match_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).onOk'></a>

`onOk` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Result{TOk,TErr}.Match{T}(Converter{TOk,T},Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.Match_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).T 'Emik.Results.Result<TOk,TErr>.Match<T>(System.Converter<TOk,T>, System.Converter<TErr,T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The delegate to invoke when [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

<a name='Emik.Results.Result_TOk,TErr_.Match_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).onErr'></a>

`onErr` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Result{TOk,TErr}.Match{T}(Converter{TOk,T},Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.Match_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).T 'Emik.Results.Result<TOk,TErr>.Match<T>(System.Converter<TOk,T>, System.Converter<TErr,T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The delegate to invoke when [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

#### Returns
[T](Result{TOk,TErr}.Match{T}(Converter{TOk,T},Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.Match_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).T 'Emik.Results.Result<TOk,TErr>.Match<T>(System.Converter<TOk,T>, System.Converter<TErr,T>).T')  
The result of [onOk](Result{TOk,TErr}.Match{T}(Converter{TOk,T},Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.Match_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).onOk 'Emik.Results.Result<TOk,TErr>.Match<T>(System.Converter<TOk,T>, System.Converter<TErr,T>).onOk') if [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), otherwise the result of [onErr](Result{TOk,TErr}.Match{T}(Converter{TOk,T},Converter{TErr,T}).md#Emik.Results.Result_TOk,TErr_.Match_T_(System.Converter_TOk,T_,System.Converter_TErr,T_).onErr 'Emik.Results.Result<TOk,TErr>.Match<T>(System.Converter<TOk,T>, System.Converter<TErr,T>).onErr').