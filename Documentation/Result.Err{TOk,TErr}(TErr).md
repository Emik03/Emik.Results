#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result](Result.md 'Emik.Results.Result')

## Result.Err<TOk,TErr>(TErr) Method

Creates an [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') value.

```csharp
public static Emik.Results.Result<TOk,TErr> Err<TOk,TErr>(TErr err);
```
#### Type parameters

<a name='Emik.Results.Result.Err_TOk,TErr_(TErr).TOk'></a>

`TOk`

The type of [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

<a name='Emik.Results.Result.Err_TOk,TErr_(TErr).TErr'></a>

`TErr`

The type of [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').
#### Parameters

<a name='Emik.Results.Result.Err_TOk,TErr_(TErr).err'></a>

`err` [TErr](Result.Err{TOk,TErr}(TErr).md#Emik.Results.Result.Err_TOk,TErr_(TErr).TErr 'Emik.Results.Result.Err<TOk,TErr>(TErr).TErr')

The value to pass into the [Result](Result.md 'Emik.Results.Result').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result.Err{TOk,TErr}(TErr).md#Emik.Results.Result.Err_TOk,TErr_(TErr).TOk 'Emik.Results.Result.Err<TOk,TErr>(TErr).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result.Err{TOk,TErr}(TErr).md#Emik.Results.Result.Err_TOk,TErr_(TErr).TErr 'Emik.Results.Result.Err<TOk,TErr>(TErr).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') with [err](Result.Err{TOk,TErr}(TErr).md#Emik.Results.Result.Err_TOk,TErr_(TErr).err 'Emik.Results.Result.Err<TOk,TErr>(TErr).err') passed in.