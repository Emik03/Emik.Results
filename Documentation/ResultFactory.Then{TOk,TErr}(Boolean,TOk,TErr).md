#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.Then<TOk,TErr>(this bool, TOk, TErr) Method

Creates a result from a boolean expression.

```csharp
public static Emik.Results.Result<TOk,TErr> Then<TOk,TErr>(this bool value, TOk ifTrue, TErr ifFalse)
    where TOk : notnull
    where TErr : notnull;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).value'></a>

`value` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value to check.

<a name='Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).ifTrue'></a>

`ifTrue` [TOk](ResultFactory.Then{TOk,TErr}(Boolean,TOk,TErr).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).TOk 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, TOk, TErr).TOk')

The value to [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') when [value](ResultFactory.Then{TOk,TErr}(Boolean,TOk,TErr).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).value 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, TOk, TErr).value') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).ifFalse'></a>

`ifFalse` [TErr](ResultFactory.Then{TOk,TErr}(Boolean,TOk,TErr).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).TErr 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, TOk, TErr).TErr')

The value to [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return') when [value](ResultFactory.Then{TOk,TErr}(Boolean,TOk,TErr).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).value 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, TOk, TErr).value') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.Then{TOk,TErr}(Boolean,TOk,TErr).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).TOk 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, TOk, TErr).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.Then{TOk,TErr}(Boolean,TOk,TErr).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).TErr 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, TOk, TErr).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The parameter [ifTrue](ResultFactory.Then{TOk,TErr}(Boolean,TOk,TErr).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).ifTrue 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, TOk, TErr).ifTrue') if [value](ResultFactory.Then{TOk,TErr}(Boolean,TOk,TErr).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).value 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, TOk, TErr).value') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'),  
otherwise the parameter [ifFalse](ResultFactory.Then{TOk,TErr}(Boolean,TOk,TErr).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,TOk,TErr).ifFalse 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, TOk, TErr).ifFalse').

### Remarks
  
All parameters are eagerly evaluated.