#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.Deconstruct(this IBoxedResult, bool, object) Method

Deconstructs the [IBoxedResult](IBoxedResult.md 'Emik.Results.IBoxedResult').

```csharp
public static void Deconstruct(this Emik.Results.IBoxedResult? result, out bool isOk, out object value);
```
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.Deconstruct(thisEmik.Results.IBoxedResult,bool,object).result'></a>

`result` [IBoxedResult](IBoxedResult.md 'Emik.Results.IBoxedResult')

The [IBoxedResult](IBoxedResult.md 'Emik.Results.IBoxedResult') to deconstruct.

<a name='Emik.Results.Extensions.ResultFactory.Deconstruct(thisEmik.Results.IBoxedResult,bool,object).isOk'></a>

`isOk` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The parameter [result](ResultFactory.Deconstruct(IBoxedResult,bool&,object&).md#Emik.Results.Extensions.ResultFactory.Deconstruct(thisEmik.Results.IBoxedResult,bool,object).result 'Emik.Results.Extensions.ResultFactory.Deconstruct(this Emik.Results.IBoxedResult, bool, object).result')'s [IsOk](IBoxedResult.IsOk.md 'Emik.Results.IBoxedResult.IsOk').

<a name='Emik.Results.Extensions.ResultFactory.Deconstruct(thisEmik.Results.IBoxedResult,bool,object).value'></a>

`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The parameter [result](ResultFactory.Deconstruct(IBoxedResult,bool&,object&).md#Emik.Results.Extensions.ResultFactory.Deconstruct(thisEmik.Results.IBoxedResult,bool,object).result 'Emik.Results.Extensions.ResultFactory.Deconstruct(this Emik.Results.IBoxedResult, bool, object).result')'s [Value](IBoxedResult.Value.md 'Emik.Results.IBoxedResult.Value').