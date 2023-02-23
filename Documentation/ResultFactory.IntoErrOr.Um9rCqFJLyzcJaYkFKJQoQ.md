#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.IntoErrOr<TOk,TErr>(this TErr, TOk) Method

Maps [TErr](ResultFactory.IntoErrOr.Um9rCqFJLyzcJaYkFKJQoQ.md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisTErr,TOk).TErr 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this TErr, TOk).TErr') into a [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>').

```csharp
public static Emik.Results.Result<TOk,TErr> IntoErrOr<TOk,TErr>(this TErr? err, TOk ok)
    where TErr : class;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisTErr,TOk).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisTErr,TOk).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisTErr,TOk).err'></a>

`err` [TErr](ResultFactory.IntoErrOr.Um9rCqFJLyzcJaYkFKJQoQ.md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisTErr,TOk).TErr 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this TErr, TOk).TErr')

The value to pass in.

<a name='Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisTErr,TOk).ok'></a>

`ok` [TOk](ResultFactory.IntoErrOr.Um9rCqFJLyzcJaYkFKJQoQ.md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisTErr,TOk).TOk 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this TErr, TOk).TOk')

The value to use instead if [err](ResultFactory.IntoErrOr.Um9rCqFJLyzcJaYkFKJQoQ.md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisTErr,TOk).err 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this TErr, TOk).err') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.IntoErrOr.Um9rCqFJLyzcJaYkFKJQoQ.md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisTErr,TOk).TOk 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this TErr, TOk).TOk')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.IntoErrOr.Um9rCqFJLyzcJaYkFKJQoQ.md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisTErr,TOk).TErr 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this TErr, TOk).TErr')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') where [err](ResultFactory.IntoErrOr.Um9rCqFJLyzcJaYkFKJQoQ.md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisTErr,TOk).err 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this TErr, TOk).err') is used if it isn't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'),  
or else [ok](ResultFactory.IntoErrOr.Um9rCqFJLyzcJaYkFKJQoQ.md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisTErr,TOk).ok 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this TErr, TOk).ok').