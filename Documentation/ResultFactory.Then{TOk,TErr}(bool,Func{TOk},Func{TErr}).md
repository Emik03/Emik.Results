#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.Then<TOk,TErr>(this bool, Func<TOk>, Func<TErr>) Method

Creates a result from a boolean expression.

```csharp
public static Emik.Results.Result<TOk,TErr> Then<TOk,TErr>(this bool value, System.Func<TOk> onTrue, System.Func<TErr> onFalse)
    where TOk : notnull
    where TErr : notnull;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).TOk'></a>

`TOk`

The success type.

<a name='Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).TErr'></a>

`TErr`

The error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).value'></a>

`value` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean') value to check.

<a name='Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).onTrue'></a>

`onTrue` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TOk](ResultFactory.Then{TOk,TErr}(bool,Func{TOk},Func{TErr}).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).TOk 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, System.Func<TOk>, System.Func<TErr>).TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The value to invoke when [value](ResultFactory.Then{TOk,TErr}(bool,Func{TOk},Func{TErr}).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).value 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, System.Func<TOk>, System.Func<TErr>).value') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

<a name='Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).onFalse'></a>

`onFalse` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TErr](ResultFactory.Then{TOk,TErr}(bool,Func{TOk},Func{TErr}).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).TErr 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, System.Func<TOk>, System.Func<TErr>).TErr')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

The value to invoke when [value](ResultFactory.Then{TOk,TErr}(bool,Func{TOk},Func{TErr}).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).value 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, System.Func<TOk>, System.Func<TErr>).value') is [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

#### Returns
[Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](ResultFactory.Then{TOk,TErr}(bool,Func{TOk},Func{TErr}).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).TOk 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, System.Func<TOk>, System.Func<TErr>).TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](ResultFactory.Then{TOk,TErr}(bool,Func{TOk},Func{TErr}).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).TErr 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, System.Func<TOk>, System.Func<TErr>).TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')  
The parameter [onTrue](ResultFactory.Then{TOk,TErr}(bool,Func{TOk},Func{TErr}).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).onTrue 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, System.Func<TOk>, System.Func<TErr>).onTrue') if [value](ResultFactory.Then{TOk,TErr}(bool,Func{TOk},Func{TErr}).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).value 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, System.Func<TOk>, System.Func<TErr>).value') is [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'),  
otherwise the parameter [onFalse](ResultFactory.Then{TOk,TErr}(bool,Func{TOk},Func{TErr}).md#Emik.Results.Extensions.ResultFactory.Then_TOk,TErr_(thisbool,System.Func_TOk_,System.Func_TErr_).onFalse 'Emik.Results.Extensions.ResultFactory.Then<TOk,TErr>(this bool, System.Func<TOk>, System.Func<TErr>).onFalse').

### Remarks
  
All parameters are lazily evaluated.