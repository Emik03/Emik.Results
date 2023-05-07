#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results')

## IBoxedResult Interface

Represents an untyped result type, which allows [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
instances to interact regardless of its generic parameters.

```csharp
public interface IBoxedResult
```

Derived  
&#8627; [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

| Properties | |
| :--- | :--- |
| [IsErr](IBoxedResult.IsErr.md 'Emik.Results.IBoxedResult.IsErr') | Gets a value indicating whether this [IBoxedResult](IBoxedResult.md 'Emik.Results.IBoxedResult') has an `Err` value. |
| [IsOk](IBoxedResult.IsOk.md 'Emik.Results.IBoxedResult.IsOk') | Gets a value indicating whether this [IBoxedResult](IBoxedResult.md 'Emik.Results.IBoxedResult') has an `Ok` value. |
| [Value](IBoxedResult.Value.md 'Emik.Results.IBoxedResult.Value') | Gets `Ok` if this [IBoxedResult](IBoxedResult.md 'Emik.Results.IBoxedResult') has a success value and `Err` otherwise. |
