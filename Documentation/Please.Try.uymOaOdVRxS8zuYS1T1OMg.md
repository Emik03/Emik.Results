#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Please](Please.md 'Emik.Results.Please')

## Please.Try<T1,T2,T3,TResult>(Func<T1,T2,T3,TResult>, T1, T2, T3) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static Emik.Results.Result<TResult,System.Exception> Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult> func, T1 first, T2 second, T3 third);
```
#### Type parameters

<a name='Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).T1'></a>

`T1`

The type of the first parameter.

<a name='Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).T2'></a>

`T2`

The type of the second parameter.

<a name='Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).T3'></a>

`T3`

The type of the third parameter.

<a name='Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).TResult'></a>

`TResult`

The type of the result of [func](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).func 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).func').
#### Parameters

<a name='Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T1](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).T1 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T2](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).T2 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T3](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).T3 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TResult](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).TResult 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).first'></a>

`first` [T1](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).T1 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).T1')

The first parameter to invoke [func](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).func 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).func') with.

<a name='Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).second'></a>

`second` [T2](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).T2 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).T2')

The second parameter to invoke [func](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).func 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).func') with.

<a name='Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).third'></a>

`third` [T3](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).T3 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).T3')

The third parameter to invoke [func](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).func 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).func') with.

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TResult](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).TResult 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).TResult')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
The result of [func](Please.Try.uymOaOdVRxS8zuYS1T1OMg.md#Emik.Results.Please.Try_T1,T2,T3,TResult_(System.Func_T1,T2,T3,TResult_,T1,T2,T3).func 'Emik.Results.Please.Try<T1,T2,T3,TResult>(System.Func<T1,T2,T3,TResult>, T1, T2, T3).func'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.