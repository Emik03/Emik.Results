#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Please](Please.md 'Emik.Results.Please')

## Please.Try<T>(this Lazy<T>) Method

Attempts to invoke a [System.Lazy&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Lazy-1 'System.Lazy`1').

```csharp
public static Emik.Results.Result<T,System.Exception> Try<T>(this System.Lazy<T> lazy)
    where T : notnull;
```
#### Type parameters

<a name='Emik.Results.Please.Try_T_(thisSystem.Lazy_T_).T'></a>

`T`

The type of the result of [lazy](Please.Try{T}(Lazy{T}).md#Emik.Results.Please.Try_T_(thisSystem.Lazy_T_).lazy 'Emik.Results.Please.Try<T>(this System.Lazy<T>).lazy').
#### Parameters

<a name='Emik.Results.Please.Try_T_(thisSystem.Lazy_T_).lazy'></a>

`lazy` [System.Lazy&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Lazy-1 'System.Lazy`1')[T](Please.Try{T}(Lazy{T}).md#Emik.Results.Please.Try_T_(thisSystem.Lazy_T_).T 'Emik.Results.Please.Try<T>(this System.Lazy<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Lazy-1 'System.Lazy`1')

The [System.Lazy&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Lazy-1 'System.Lazy`1') to invoke.

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](Please.Try{T}(Lazy{T}).md#Emik.Results.Please.Try_T_(thisSystem.Lazy_T_).T 'Emik.Results.Please.Try<T>(this System.Lazy<T>).T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The result of [lazy](Please.Try{T}(Lazy{T}).md#Emik.Results.Please.Try_T_(thisSystem.Lazy_T_).lazy 'Emik.Results.Please.Try<T>(this System.Lazy<T>).lazy'), or the [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown.