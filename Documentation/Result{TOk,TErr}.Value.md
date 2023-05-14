#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Value Property

Gets `Ok` if this [IBoxedResult](IBoxedResult.md 'Emik.Results.IBoxedResult') has a success value and `Err` otherwise.

```csharp
public object Value { get; }
```

Implements [Value](IBoxedResult.Value.md 'Emik.Results.IBoxedResult.Value')

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

### Remarks
  
This process requires boxing for returns that are value-types.