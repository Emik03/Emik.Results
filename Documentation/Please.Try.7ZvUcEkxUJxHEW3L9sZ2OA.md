#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Please](Please.md 'Emik.Results.Please')

## Please.Try<T>(Action<T>, T) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static Emik.Results.Result<object?,System.Exception> Try<T>(System.Action<T> action, T first);
```
#### Type parameters

<a name='Emik.Results.Please.Try_T_(System.Action_T_,T).T'></a>

`T`

The type of the first parameter.
#### Parameters

<a name='Emik.Results.Please.Try_T_(System.Action_T_,T).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Please.Try.7ZvUcEkxUJxHEW3L9sZ2OA.md#Emik.Results.Please.Try_T_(System.Action_T_,T).T 'Emik.Results.Please.Try<T>(System.Action<T>, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Please.Try_T_(System.Action_T_,T).first'></a>

`first` [T](Please.Try.7ZvUcEkxUJxHEW3L9sZ2OA.md#Emik.Results.Please.Try_T_(System.Action_T_,T).T 'Emik.Results.Please.Try<T>(System.Action<T>, T).T')

The first parameter to invoke [action](Please.Try.7ZvUcEkxUJxHEW3L9sZ2OA.md#Emik.Results.Please.Try_T_(System.Action_T_,T).action 'Emik.Results.Please.Try<T>(System.Action<T>, T).action') with.

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
The result of [action](Please.Try.7ZvUcEkxUJxHEW3L9sZ2OA.md#Emik.Results.Please.Try_T_(System.Action_T_,T).action 'Emik.Results.Please.Try<T>(System.Action<T>, T).action'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.