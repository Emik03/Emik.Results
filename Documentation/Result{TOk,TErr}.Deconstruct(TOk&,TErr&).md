#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Deconstruct(TOk, TErr) Method

Destructures the [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') into 2 optional values, [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') and [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').

```csharp
public void Deconstruct(out TOk? ok, out TErr? err);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.Deconstruct(TOk,TErr).ok'></a>

`ok` [TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')

The success value.

<a name='Emik.Results.Result_TOk,TErr_.Deconstruct(TOk,TErr).err'></a>

`err` [TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')

The error value.