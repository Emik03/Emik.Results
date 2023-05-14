#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.IntoOkOr<TOk,TErr>(this TOk, TErr) Method

Maps [TOk](ResultFactory.IntoOkOr{TOk,TErr}(TOk,TErr).md#Emik.Results.Extensions.ResultFactory.IntoOkOr_TOk,TErr_(thisTOk,TErr).TOk 'Emik.Results.Extensions.ResultFactory.IntoOkOr<TOk,TErr>(this TOk, TErr).TOk') into a [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>').

```csharp
public static Emik.Results.Result<TOk,TErr> IntoOkOr<TOk,TErr>(this TOk? ok, TErr err)
    where TOk : class
    where TErr : notnull;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoOkOr_TOk,TErr_(thisTOk,TErr).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.IntoOkOr_TOk,TErr_(thisTOk,TErr).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoOkOr_TOk,TErr_(thisTOk,TErr).ok'></a>

`ok` [TOk](ResultFactory.IntoOkOr{TOk,TErr}(TOk,TErr).md#Emik.Results.Extensions.ResultFactory.IntoOkOr_TOk,TErr_(thisTOk,TErr).TOk 'Emik.Results.Extensions.ResultFactory.IntoOkOr<TOk,TErr>(this TOk, TErr).TOk')

The value to pass in.

<a name='Emik.Results.Extensions.ResultFactory.IntoOkOr_TOk,TErr_(thisTOk,TErr).err'></a>

`err` [TErr](ResultFactory.IntoOkOr{TOk,TErr}(TOk,TErr).md#Emik.Results.Extensions.ResultFactory.IntoOkOr_TOk,TErr_(thisTOk,TErr).TErr 'Emik.Results.Extensions.ResultFactory.IntoOkOr<TOk,TErr>(this TOk, TErr).TErr')

The value to use instead if [ok](ResultFactory.IntoOkOr{TOk,TErr}(TOk,TErr).md#Emik.Results.Extensions.ResultFactory.IntoOkOr_TOk,TErr_(thisTOk,TErr).ok 'Emik.Results.Extensions.ResultFactory.IntoOkOr<TOk,TErr>(this TOk, TErr).ok') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.IntoOkOr{TOk,TErr}(TOk,TErr).md#Emik.Results.Extensions.ResultFactory.IntoOkOr_TOk,TErr_(thisTOk,TErr).TOk 'Emik.Results.Extensions.ResultFactory.IntoOkOr<TOk,TErr>(this TOk, TErr).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.IntoOkOr{TOk,TErr}(TOk,TErr).md#Emik.Results.Extensions.ResultFactory.IntoOkOr_TOk,TErr_(thisTOk,TErr).TErr 'Emik.Results.Extensions.ResultFactory.IntoOkOr<TOk,TErr>(this TOk, TErr).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') where [ok](ResultFactory.IntoOkOr{TOk,TErr}(TOk,TErr).md#Emik.Results.Extensions.ResultFactory.IntoOkOr_TOk,TErr_(thisTOk,TErr).ok 'Emik.Results.Extensions.ResultFactory.IntoOkOr<TOk,TErr>(this TOk, TErr).ok') is used if it isn't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'),  
or else [err](ResultFactory.IntoOkOr{TOk,TErr}(TOk,TErr).md#Emik.Results.Extensions.ResultFactory.IntoOkOr_TOk,TErr_(thisTOk,TErr).err 'Emik.Results.Extensions.ResultFactory.IntoOkOr<TOk,TErr>(this TOk, TErr).err').