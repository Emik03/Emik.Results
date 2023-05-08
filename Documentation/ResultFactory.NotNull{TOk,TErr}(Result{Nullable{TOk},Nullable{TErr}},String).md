#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.NotNull<TOk,TErr>(this Result<Nullable<TOk>,Nullable<TErr>>, string) Method

Asserts that both generics are non-null.

```csharp
public static Emik.Results.Result<TOk,TErr> NotNull<TOk,TErr>(this Emik.Results.Result<System.Nullable<TOk>,System.Nullable<TErr>> result, string? message=null)
    where TOk : struct, System.ValueType, System.ValueType
    where TErr : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.NotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,System.Nullable_TErr__,string).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.NotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,System.Nullable_TErr__,string).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.NotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,System.Nullable_TErr__,string).result'></a>

`result` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TOk](ResultFactory.NotNull{TOk,TErr}(Result{Nullable{TOk},Nullable{TErr}},String).md#Emik.Results.Extensions.ResultFactory.NotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,System.Nullable_TErr__,string).TOk 'Emik.Results.Extensions.ResultFactory.NotNull<TOk,TErr>(this Emik.Results.Result<System.Nullable<TOk>,System.Nullable<TErr>>, string).TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TErr](ResultFactory.NotNull{TOk,TErr}(Result{Nullable{TOk},Nullable{TErr}},String).md#Emik.Results.Extensions.ResultFactory.NotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,System.Nullable_TErr__,string).TErr 'Emik.Results.Extensions.ResultFactory.NotNull<TOk,TErr>(this Emik.Results.Result<System.Nullable<TOk>,System.Nullable<TErr>>, string).TErr')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

The result parameter.

<a name='Emik.Results.Extensions.ResultFactory.NotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,System.Nullable_TErr__,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message to send into [ResultException&lt;T&gt;](ResultException{T}.md 'Emik.Results.ResultException<T>').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.NotNull{TOk,TErr}(Result{Nullable{TOk},Nullable{TErr}},String).md#Emik.Results.Extensions.ResultFactory.NotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,System.Nullable_TErr__,string).TOk 'Emik.Results.Extensions.ResultFactory.NotNull<TOk,TErr>(this Emik.Results.Result<System.Nullable<TOk>,System.Nullable<TErr>>, string).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.NotNull{TOk,TErr}(Result{Nullable{TOk},Nullable{TErr}},String).md#Emik.Results.Extensions.ResultFactory.NotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,System.Nullable_TErr__,string).TErr 'Emik.Results.Extensions.ResultFactory.NotNull<TOk,TErr>(this Emik.Results.Result<System.Nullable<TOk>,System.Nullable<TErr>>, string).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') where neither generics are null.