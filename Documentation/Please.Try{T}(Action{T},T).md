#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Please](Please.md 'Emik.Results.Please')

## Please.Try<T>(Action<T>, T) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static Emik.Results.Result<Emik.Results.Unit,System.Exception> Try<T>(System.Action<T> action, T first);
```
#### Type parameters

<a name='Emik.Results.Please.Try_T_(System.Action_T_,T).T'></a>

`T`

The type of the first parameter.
#### Parameters

<a name='Emik.Results.Please.Try_T_(System.Action_T_,T).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Please.Try{T}(Action{T},T).md#Emik.Results.Please.Try_T_(System.Action_T_,T).T 'Emik.Results.Please.Try<T>(System.Action<T>, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Please.Try_T_(System.Action_T_,T).first'></a>

`first` [T](Please.Try{T}(Action{T},T).md#Emik.Results.Please.Try_T_(System.Action_T_,T).T 'Emik.Results.Please.Try<T>(System.Action<T>, T).T')

The first parameter to invoke [action](Please.Try{T}(Action{T},T).md#Emik.Results.Please.Try_T_(System.Action_T_,T).action 'Emik.Results.Please.Try<T>(System.Action<T>, T).action') with.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[Unit](Unit.md 'Emik.Results.Unit')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [action](Please.Try{T}(Action{T},T).md#Emik.Results.Please.Try_T_(System.Action_T_,T).action 'Emik.Results.Please.Try<T>(System.Action<T>, T).action'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.