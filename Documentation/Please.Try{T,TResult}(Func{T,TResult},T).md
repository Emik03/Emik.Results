#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Please](Please.md 'Emik.Results.Please')

## Please.Try<T,TResult>(Func<T,TResult>, T) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static Emik.Results.Result<TResult,System.Exception> Try<T,TResult>(System.Func<T,TResult> func, T first)
    where TResult : notnull;
```
#### Type parameters

<a name='Emik.Results.Please.Try_T,TResult_(System.Func_T,TResult_,T).T'></a>

`T`

The type of the first parameter.

<a name='Emik.Results.Please.Try_T,TResult_(System.Func_T,TResult_,T).TResult'></a>

`TResult`

The type of the result of [func](Please.Try{T,TResult}(Func{T,TResult},T).md#Emik.Results.Please.Try_T,TResult_(System.Func_T,TResult_,T).func 'Emik.Results.Please.Try<T,TResult>(System.Func<T,TResult>, T).func').
#### Parameters

<a name='Emik.Results.Please.Try_T,TResult_(System.Func_T,TResult_,T).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Please.Try{T,TResult}(Func{T,TResult},T).md#Emik.Results.Please.Try_T,TResult_(System.Func_T,TResult_,T).T 'Emik.Results.Please.Try<T,TResult>(System.Func<T,TResult>, T).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Please.Try{T,TResult}(Func{T,TResult},T).md#Emik.Results.Please.Try_T,TResult_(System.Func_T,TResult_,T).TResult 'Emik.Results.Please.Try<T,TResult>(System.Func<T,TResult>, T).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Please.Try_T,TResult_(System.Func_T,TResult_,T).first'></a>

`first` [T](Please.Try{T,TResult}(Func{T,TResult},T).md#Emik.Results.Please.Try_T,TResult_(System.Func_T,TResult_,T).T 'Emik.Results.Please.Try<T,TResult>(System.Func<T,TResult>, T).T')

The first parameter to invoke [func](Please.Try{T,TResult}(Func{T,TResult},T).md#Emik.Results.Please.Try_T,TResult_(System.Func_T,TResult_,T).func 'Emik.Results.Please.Try<T,TResult>(System.Func<T,TResult>, T).func') with.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TResult](Please.Try{T,TResult}(Func{T,TResult},T).md#Emik.Results.Please.Try_T,TResult_(System.Func_T,TResult_,T).TResult 'Emik.Results.Please.Try<T,TResult>(System.Func<T,TResult>, T).TResult')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [func](Please.Try{T,TResult}(Func{T,TResult},T).md#Emik.Results.Please.Try_T,TResult_(System.Func_T,TResult_,T).func 'Emik.Results.Please.Try<T,TResult>(System.Func<T,TResult>, T).func'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.