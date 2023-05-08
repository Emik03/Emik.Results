#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.OkNotNull<TOk,TErr>(this Result<Nullable<TOk>,TErr>, string) Method

Asserts that [TOk](ResultFactory.OkNotNull{TOk,TErr}(Result{Nullable{TOk},TErr},String).md#Emik.Results.Extensions.ResultFactory.OkNotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,TErr_,string).TOk 'Emik.Results.Extensions.ResultFactory.OkNotNull<TOk,TErr>(this Emik.Results.Result<System.Nullable<TOk>,TErr>, string).TOk') is non-null.

```csharp
public static Emik.Results.Result<TOk,TErr> OkNotNull<TOk,TErr>(this Emik.Results.Result<System.Nullable<TOk>,TErr> result, string? message=null)
    where TOk : struct, System.ValueType?, System.ValueType;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.OkNotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,TErr_,string).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.OkNotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,TErr_,string).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.OkNotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,TErr_,string).result'></a>

`result` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TOk](ResultFactory.OkNotNull{TOk,TErr}(Result{Nullable{TOk},TErr},String).md#Emik.Results.Extensions.ResultFactory.OkNotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,TErr_,string).TOk 'Emik.Results.Extensions.ResultFactory.OkNotNull<TOk,TErr>(this Emik.Results.Result<System.Nullable<TOk>,TErr>, string).TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.OkNotNull{TOk,TErr}(Result{Nullable{TOk},TErr},String).md#Emik.Results.Extensions.ResultFactory.OkNotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,TErr_,string).TErr 'Emik.Results.Extensions.ResultFactory.OkNotNull<TOk,TErr>(this Emik.Results.Result<System.Nullable<TOk>,TErr>, string).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

The result parameter.

<a name='Emik.Results.Extensions.ResultFactory.OkNotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,TErr_,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message to send into [ResultException&lt;T&gt;](ResultException{T}.md 'Emik.Results.ResultException<T>').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.OkNotNull{TOk,TErr}(Result{Nullable{TOk},TErr},String).md#Emik.Results.Extensions.ResultFactory.OkNotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,TErr_,string).TOk 'Emik.Results.Extensions.ResultFactory.OkNotNull<TOk,TErr>(this Emik.Results.Result<System.Nullable<TOk>,TErr>, string).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.OkNotNull{TOk,TErr}(Result{Nullable{TOk},TErr},String).md#Emik.Results.Extensions.ResultFactory.OkNotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,TErr_,string).TErr 'Emik.Results.Extensions.ResultFactory.OkNotNull<TOk,TErr>(this Emik.Results.Result<System.Nullable<TOk>,TErr>, string).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') where [TOk](ResultFactory.OkNotNull{TOk,TErr}(Result{Nullable{TOk},TErr},String).md#Emik.Results.Extensions.ResultFactory.OkNotNull_TOk,TErr_(thisEmik.Results.Result_System.Nullable_TOk_,TErr_,string).TOk 'Emik.Results.Extensions.ResultFactory.OkNotNull<TOk,TErr>(this Emik.Results.Result<System.Nullable<TOk>,TErr>, string).TOk') is non-null.