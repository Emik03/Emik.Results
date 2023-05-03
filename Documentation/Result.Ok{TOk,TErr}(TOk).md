#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result](Result.md 'Emik.Results.Result')

## Result.Ok<TOk,TErr>(TOk) Method

Creates an [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') value.

```csharp
public static Emik.Results.Result<TOk,TErr> Ok<TOk,TErr>(TOk ok);
```
#### Type parameters

<a name='Emik.Results.Result.Ok_TOk,TErr_(TOk).TOk'></a>

`TOk`

The type of [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

<a name='Emik.Results.Result.Ok_TOk,TErr_(TOk).TErr'></a>

`TErr`

The type of [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').
#### Parameters

<a name='Emik.Results.Result.Ok_TOk,TErr_(TOk).ok'></a>

`ok` [TOk](Result.Ok{TOk,TErr}(TOk).md#Emik.Results.Result.Ok_TOk,TErr_(TOk).TOk 'Emik.Results.Result.Ok<TOk,TErr>(TOk).TOk')

The value to pass into the [Result](Result.md 'Emik.Results.Result').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result.Ok{TOk,TErr}(TOk).md#Emik.Results.Result.Ok_TOk,TErr_(TOk).TOk 'Emik.Results.Result.Ok<TOk,TErr>(TOk).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result.Ok{TOk,TErr}(TOk).md#Emik.Results.Result.Ok_TOk,TErr_(TOk).TErr 'Emik.Results.Result.Ok<TOk,TErr>(TOk).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
A [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') with [ok](Result.Ok{TOk,TErr}(TOk).md#Emik.Results.Result.Ok_TOk,TErr_(TOk).ok 'Emik.Results.Result.Ok<TOk,TErr>(TOk).ok') passed in.