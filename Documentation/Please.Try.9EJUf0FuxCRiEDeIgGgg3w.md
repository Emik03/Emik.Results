#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Please](Please.md 'Emik.Results.Please')

## Please.Try<TResult>(Func<TResult>) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static Emik.Results.Result<TResult,System.Exception> Try<TResult>(System.Func<TResult> func);
```
#### Type parameters

<a name='Emik.Results.Please.Try_TResult_(System.Func_TResult_).TResult'></a>

`TResult`

The type of the result of [func](Please.Try.9EJUf0FuxCRiEDeIgGgg3w.md#Emik.Results.Please.Try_TResult_(System.Func_TResult_).func 'Emik.Results.Please.Try<TResult>(System.Func<TResult>).func').
#### Parameters

<a name='Emik.Results.Please.Try_TResult_(System.Func_TResult_).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](Please.Try.9EJUf0FuxCRiEDeIgGgg3w.md#Emik.Results.Please.Try_TResult_(System.Func_TResult_).TResult 'Emik.Results.Please.Try<TResult>(System.Func<TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TResult](Please.Try.9EJUf0FuxCRiEDeIgGgg3w.md#Emik.Results.Please.Try_TResult_(System.Func_TResult_).TResult 'Emik.Results.Please.Try<TResult>(System.Func<TResult>).TResult')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
The result of [func](Please.Try.9EJUf0FuxCRiEDeIgGgg3w.md#Emik.Results.Please.Try_TResult_(System.Func_TResult_).func 'Emik.Results.Please.Try<TResult>(System.Func<TResult>).func'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.