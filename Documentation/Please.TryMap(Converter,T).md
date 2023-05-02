#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Please](Please.md 'Emik.Results.Please')

## Please.TryMap<T,TResult>(Converter<T,TResult>, T) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static Emik.Results.Result<TResult,System.Exception> TryMap<T,TResult>(System.Converter<T,TResult> converter, T first);
```
#### Type parameters

<a name='Emik.Results.Please.TryMap_T,TResult_(System.Converter_T,TResult_,T).T'></a>

`T`

The type of the first parameter.

<a name='Emik.Results.Please.TryMap_T,TResult_(System.Converter_T,TResult_,T).TResult'></a>

`TResult`

The type of the result of [converter](Please.TryMap(Converter,T).md#Emik.Results.Please.TryMap_T,TResult_(System.Converter_T,TResult_,T).converter 'Emik.Results.Please.TryMap<T,TResult>(System.Converter<T,TResult>, T).converter').
#### Parameters

<a name='Emik.Results.Please.TryMap_T,TResult_(System.Converter_T,TResult_,T).converter'></a>

`converter` [System.Converter&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[T](Please.TryMap(Converter,T).md#Emik.Results.Please.TryMap_T,TResult_(System.Converter_T,TResult_,T).T 'Emik.Results.Please.TryMap<T,TResult>(System.Converter<T,TResult>, T).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')[TResult](Please.TryMap(Converter,T).md#Emik.Results.Please.TryMap_T,TResult_(System.Converter_T,TResult_,T).TResult 'Emik.Results.Please.TryMap<T,TResult>(System.Converter<T,TResult>, T).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Converter-2 'System.Converter`2')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Please.TryMap_T,TResult_(System.Converter_T,TResult_,T).first'></a>

`first` [T](Please.TryMap(Converter,T).md#Emik.Results.Please.TryMap_T,TResult_(System.Converter_T,TResult_,T).T 'Emik.Results.Please.TryMap<T,TResult>(System.Converter<T,TResult>, T).T')

The first parameter to invoke [converter](Please.TryMap(Converter,T).md#Emik.Results.Please.TryMap_T,TResult_(System.Converter_T,TResult_,T).converter 'Emik.Results.Please.TryMap<T,TResult>(System.Converter<T,TResult>, T).converter') with.

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TResult](Please.TryMap(Converter,T).md#Emik.Results.Please.TryMap_T,TResult_(System.Converter_T,TResult_,T).TResult 'Emik.Results.Please.TryMap<T,TResult>(System.Converter<T,TResult>, T).TResult')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
The result of [converter](Please.TryMap(Converter,T).md#Emik.Results.Please.TryMap_T,TResult_(System.Converter_T,TResult_,T).converter 'Emik.Results.Please.TryMap<T,TResult>(System.Converter<T,TResult>, T).converter'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.