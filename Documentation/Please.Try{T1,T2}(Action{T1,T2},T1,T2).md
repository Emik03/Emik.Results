#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Please](Please.md 'Emik.Results.Please')

## Please.Try<T1,T2>(Action<T1,T2>, T1, T2) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static Emik.Results.Result<Emik.Results.Unit,System.Exception> Try<T1,T2>(System.Action<T1,T2> action, T1 first, T2 second);
```
#### Type parameters

<a name='Emik.Results.Please.Try_T1,T2_(System.Action_T1,T2_,T1,T2).T1'></a>

`T1`

The type of the first parameter.

<a name='Emik.Results.Please.Try_T1,T2_(System.Action_T1,T2_,T1,T2).T2'></a>

`T2`

The type of the second parameter.
#### Parameters

<a name='Emik.Results.Please.Try_T1,T2_(System.Action_T1,T2_,T1,T2).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T1](Please.Try{T1,T2}(Action{T1,T2},T1,T2).md#Emik.Results.Please.Try_T1,T2_(System.Action_T1,T2_,T1,T2).T1 'Emik.Results.Please.Try<T1,T2>(System.Action<T1,T2>, T1, T2).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T2](Please.Try{T1,T2}(Action{T1,T2},T1,T2).md#Emik.Results.Please.Try_T1,T2_(System.Action_T1,T2_,T1,T2).T2 'Emik.Results.Please.Try<T1,T2>(System.Action<T1,T2>, T1, T2).T2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Please.Try_T1,T2_(System.Action_T1,T2_,T1,T2).first'></a>

`first` [T1](Please.Try{T1,T2}(Action{T1,T2},T1,T2).md#Emik.Results.Please.Try_T1,T2_(System.Action_T1,T2_,T1,T2).T1 'Emik.Results.Please.Try<T1,T2>(System.Action<T1,T2>, T1, T2).T1')

The first parameter to invoke [action](Please.Try{T1,T2}(Action{T1,T2},T1,T2).md#Emik.Results.Please.Try_T1,T2_(System.Action_T1,T2_,T1,T2).action 'Emik.Results.Please.Try<T1,T2>(System.Action<T1,T2>, T1, T2).action') with.

<a name='Emik.Results.Please.Try_T1,T2_(System.Action_T1,T2_,T1,T2).second'></a>

`second` [T2](Please.Try{T1,T2}(Action{T1,T2},T1,T2).md#Emik.Results.Please.Try_T1,T2_(System.Action_T1,T2_,T1,T2).T2 'Emik.Results.Please.Try<T1,T2>(System.Action<T1,T2>, T1, T2).T2')

The second parameter to invoke [action](Please.Try{T1,T2}(Action{T1,T2},T1,T2).md#Emik.Results.Please.Try_T1,T2_(System.Action_T1,T2_,T1,T2).action 'Emik.Results.Please.Try<T1,T2>(System.Action<T1,T2>, T1, T2).action') with.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Unit](Unit.md 'Emik.Results.Unit')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [action](Please.Try{T1,T2}(Action{T1,T2},T1,T2).md#Emik.Results.Please.Try_T1,T2_(System.Action_T1,T2_,T1,T2).action 'Emik.Results.Please.Try<T1,T2>(System.Action<T1,T2>, T1, T2).action'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.