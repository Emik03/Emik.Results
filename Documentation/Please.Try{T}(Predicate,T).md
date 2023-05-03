#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Please](Please.md 'Emik.Results.Please')

## Please.Try<T>(Predicate<T>, T) Method

Attempts to invoke a [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate').

```csharp
public static Emik.Results.Result<bool,System.Exception> Try<T>(System.Predicate<T> predicate, T first);
```
#### Type parameters

<a name='Emik.Results.Please.Try_T_(System.Predicate_T_,T).T'></a>

`T`

The type of the first parameter.
#### Parameters

<a name='Emik.Results.Please.Try_T_(System.Predicate_T_,T).predicate'></a>

`predicate` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[T](Please.Try{T}(Predicate,T).md#Emik.Results.Please.Try_T_(System.Predicate_T_,T).T 'Emik.Results.Please.Try<T>(System.Predicate<T>, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')

The [System.Delegate](https://docs.microsoft.com/en-us/dotnet/api/System.Delegate 'System.Delegate') to invoke.

<a name='Emik.Results.Please.Try_T_(System.Predicate_T_,T).first'></a>

`first` [T](Please.Try{T}(Predicate,T).md#Emik.Results.Please.Try_T_(System.Predicate_T_,T).T 'Emik.Results.Please.Try<T>(System.Predicate<T>, T).T')

The first parameter to invoke [predicate](Please.Try{T}(Predicate,T).md#Emik.Results.Please.Try_T_(System.Predicate_T_,T).predicate 'Emik.Results.Please.Try<T>(System.Predicate<T>, T).predicate') with.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [predicate](Please.Try{T}(Predicate,T).md#Emik.Results.Please.Try_T_(System.Predicate_T_,T).predicate 'Emik.Results.Please.Try<T>(System.Predicate<T>, T).predicate'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.