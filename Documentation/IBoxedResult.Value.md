#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[IBoxedResult](IBoxedResult.md 'Emik.Results.IBoxedResult')

## IBoxedResult.Value Property

Gets `Ok` if this [IBoxedResult](IBoxedResult.md 'Emik.Results.IBoxedResult') has a success value and `Err` otherwise.

```csharp
object? Value { get; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

### Remarks
  
This process requires boxing for returns that are value-types.