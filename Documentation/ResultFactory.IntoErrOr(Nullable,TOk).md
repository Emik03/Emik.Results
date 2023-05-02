#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.IntoErrOr<TOk,TErr>(this Nullable<TErr>, TOk) Method

Maps [TErr](ResultFactory.IntoErrOr(Nullable,TOk).md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisSystem.Nullable_TErr_,TOk).TErr 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this System.Nullable<TErr>, TOk).TErr') into a [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>').

```csharp
public static Emik.Results.Result<TOk,TErr> IntoErrOr<TOk,TErr>(this System.Nullable<TErr> err, TOk ok)
    where TErr : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisSystem.Nullable_TErr_,TOk).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisSystem.Nullable_TErr_,TOk).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisSystem.Nullable_TErr_,TOk).err'></a>

`err` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[TErr](ResultFactory.IntoErrOr(Nullable,TOk).md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisSystem.Nullable_TErr_,TOk).TErr 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this System.Nullable<TErr>, TOk).TErr')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The value to pass in.

<a name='Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisSystem.Nullable_TErr_,TOk).ok'></a>

`ok` [TOk](ResultFactory.IntoErrOr(Nullable,TOk).md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisSystem.Nullable_TErr_,TOk).TOk 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this System.Nullable<TErr>, TOk).TOk')

The value to use instead if [err](ResultFactory.IntoErrOr(Nullable,TOk).md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisSystem.Nullable_TErr_,TOk).err 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this System.Nullable<TErr>, TOk).err') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

#### Returns
[Emik.Results.Result&lt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.IntoErrOr(Nullable,TOk).md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisSystem.Nullable_TErr_,TOk).TOk 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this System.Nullable<TErr>, TOk).TOk')[,](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.IntoErrOr(Nullable,TOk).md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisSystem.Nullable_TErr_,TOk).TErr 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this System.Nullable<TErr>, TOk).TErr')[&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') where [err](ResultFactory.IntoErrOr(Nullable,TOk).md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisSystem.Nullable_TErr_,TOk).err 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this System.Nullable<TErr>, TOk).err') is used if it isn't [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'),  
or else [ok](ResultFactory.IntoErrOr(Nullable,TOk).md#Emik.Results.Extensions.ResultFactory.IntoErrOr_TOk,TErr_(thisSystem.Nullable_TErr_,TOk).ok 'Emik.Results.Extensions.ResultFactory.IntoErrOr<TOk,TErr>(this System.Nullable<TErr>, TOk).ok').