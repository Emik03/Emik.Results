#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Please](Please.md 'Emik.Results.Please')

## Please.Try<T1,T2,T3,T4,TResult>(Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static Emik.Results.Result<TResult,System.Exception> Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult> func, T1 first, T2 second, T3 third, T4 fourth)
    where TResult : notnull;
```
#### Type parameters

<a name='Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).T1'></a>

`T1`

The type of the first parameter.

<a name='Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).T2'></a>

`T2`

The type of the second parameter.

<a name='Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).T3'></a>

`T3`

The type of the third parameter.

<a name='Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).T4'></a>

`T4`

The type of the fourth parameter.

<a name='Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).TResult'></a>

`TResult`

The type of the result of [func](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).func 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).func').
#### Parameters

<a name='Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T1](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).T1 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T2](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).T2 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T3](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).T3 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T4](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).T4 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).T4')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TResult](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).TResult 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).first'></a>

`first` [T1](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).T1 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).T1')

The first parameter to invoke [func](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).func 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).func') with.

<a name='Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).second'></a>

`second` [T2](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).T2 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).T2')

The second parameter to invoke [func](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).func 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).func') with.

<a name='Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).third'></a>

`third` [T3](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).T3 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).T3')

The third parameter to invoke [func](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).func 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).func') with.

<a name='Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).fourth'></a>

`fourth` [T4](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).T4 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).T4')

The fourth parameter to invoke [func](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).func 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).func') with.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TResult](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).TResult 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).TResult')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [func](Please.Try{T1,T2,T3,T4,TResult}(Func{T1,T2,T3,T4,TResult},T1,T2,T3,T4).md#Emik.Results.Please.Try_T1,T2,T3,T4,TResult_(System.Func_T1,T2,T3,T4,TResult_,T1,T2,T3,T4).func 'Emik.Results.Please.Try<T1,T2,T3,T4,TResult>(System.Func<T1,T2,T3,T4,TResult>, T1, T2, T3, T4).func'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.