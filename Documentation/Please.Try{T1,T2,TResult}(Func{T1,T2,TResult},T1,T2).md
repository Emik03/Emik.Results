#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Please](Please.md 'Emik.Results.Please')

## Please.Try<T1,T2,TResult>(Func<T1,T2,TResult>, T1, T2) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static Emik.Results.Result<TResult,System.Exception> Try<T1,T2,TResult>(System.Func<T1,T2,TResult> func, T1 first, T2 second)
    where TResult : notnull;
```
#### Type parameters

<a name='Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).T1'></a>

`T1`

The type of the first parameter.

<a name='Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).T2'></a>

`T2`

The type of the second parameter.

<a name='Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).TResult'></a>

`TResult`

The type of the result of [func](Please.Try{T1,T2,TResult}(Func{T1,T2,TResult},T1,T2).md#Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).func 'Emik.Results.Please.Try<T1,T2,TResult>(System.Func<T1,T2,TResult>, T1, T2).func').
#### Parameters

<a name='Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T1](Please.Try{T1,T2,TResult}(Func{T1,T2,TResult},T1,T2).md#Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).T1 'Emik.Results.Please.Try<T1,T2,TResult>(System.Func<T1,T2,TResult>, T1, T2).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T2](Please.Try{T1,T2,TResult}(Func{T1,T2,TResult},T1,T2).md#Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).T2 'Emik.Results.Please.Try<T1,T2,TResult>(System.Func<T1,T2,TResult>, T1, T2).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TResult](Please.Try{T1,T2,TResult}(Func{T1,T2,TResult},T1,T2).md#Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).TResult 'Emik.Results.Please.Try<T1,T2,TResult>(System.Func<T1,T2,TResult>, T1, T2).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).first'></a>

`first` [T1](Please.Try{T1,T2,TResult}(Func{T1,T2,TResult},T1,T2).md#Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).T1 'Emik.Results.Please.Try<T1,T2,TResult>(System.Func<T1,T2,TResult>, T1, T2).T1')

The first parameter to invoke [func](Please.Try{T1,T2,TResult}(Func{T1,T2,TResult},T1,T2).md#Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).func 'Emik.Results.Please.Try<T1,T2,TResult>(System.Func<T1,T2,TResult>, T1, T2).func') with.

<a name='Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).second'></a>

`second` [T2](Please.Try{T1,T2,TResult}(Func{T1,T2,TResult},T1,T2).md#Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).T2 'Emik.Results.Please.Try<T1,T2,TResult>(System.Func<T1,T2,TResult>, T1, T2).T2')

The second parameter to invoke [func](Please.Try{T1,T2,TResult}(Func{T1,T2,TResult},T1,T2).md#Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).func 'Emik.Results.Please.Try<T1,T2,TResult>(System.Func<T1,T2,TResult>, T1, T2).func') with.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TResult](Please.Try{T1,T2,TResult}(Func{T1,T2,TResult},T1,T2).md#Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).TResult 'Emik.Results.Please.Try<T1,T2,TResult>(System.Func<T1,T2,TResult>, T1, T2).TResult')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [func](Please.Try{T1,T2,TResult}(Func{T1,T2,TResult},T1,T2).md#Emik.Results.Please.Try_T1,T2,TResult_(System.Func_T1,T2,TResult_,T1,T2).func 'Emik.Results.Please.Try<T1,T2,TResult>(System.Func<T1,T2,TResult>, T1, T2).func'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.