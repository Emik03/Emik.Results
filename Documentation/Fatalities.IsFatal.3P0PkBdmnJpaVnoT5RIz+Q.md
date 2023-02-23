#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[Fatalities](Fatalities.md 'Emik.Results.Extensions.Fatalities')

## Fatalities.IsFatal(this Exception) Method

Determines whether an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') can be handled by [Please](Please.md 'Emik.Results.Please').

```csharp
public static bool IsFatal(this System.Exception? ex);
```
#### Parameters

<a name='Emik.Results.Extensions.Fatalities.IsFatal(thisSystem.Exception).ex'></a>

`ex` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The exception to determine whether it can be handled.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if the parameter [ex](Fatalities.IsFatal.3P0PkBdmnJpaVnoT5RIz+Q.md#Emik.Results.Extensions.Fatalities.IsFatal(thisSystem.Exception).ex 'Emik.Results.Extensions.Fatalities.IsFatal(this System.Exception).ex') is of an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type') that is considered fatal, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

### Remarks
  
List of fatal exceptions:  
- [System.Threading.AbandonedMutexException](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.AbandonedMutexException 'System.Threading.AbandonedMutexException')  
- [System.AccessViolationException](https://docs.microsoft.com/en-us/dotnet/api/System.AccessViolationException 'System.AccessViolationException')  
- [System.ArithmeticException](https://docs.microsoft.com/en-us/dotnet/api/System.ArithmeticException 'System.ArithmeticException')  
- [System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
- [System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
- [System.ArrayTypeMismatchException](https://docs.microsoft.com/en-us/dotnet/api/System.ArrayTypeMismatchException 'System.ArrayTypeMismatchException')  
- [System.AppDomainUnloadedException](https://docs.microsoft.com/en-us/dotnet/api/System.AppDomainUnloadedException 'System.AppDomainUnloadedException')  
- [System.BadImageFormatException](https://docs.microsoft.com/en-us/dotnet/api/System.BadImageFormatException 'System.BadImageFormatException')  
- `CultureNotFoundException` (excluding .NET Framework 3.5)  
- [System.ExecutionEngineException](https://docs.microsoft.com/en-us/dotnet/api/System.ExecutionEngineException 'System.ExecutionEngineException')  
- [System.Runtime.InteropServices.ExternalException](https://docs.microsoft.com/en-us/dotnet/api/System.Runtime.InteropServices.ExternalException 'System.Runtime.InteropServices.ExternalException')  
- [IFatal](IFatal.md 'Emik.Results.IFatal')  
- [System.IndexOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.IndexOutOfRangeException 'System.IndexOutOfRangeException')  
- `InsufficientExecutionStackException` (.NET Framework 3.5 only)  
- [System.InvalidCastException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidCastException 'System.InvalidCastException')  
- [System.Collections.Generic.KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyNotFoundException 'System.Collections.Generic.KeyNotFoundException')  
- [System.NotImplementedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotImplementedException 'System.NotImplementedException')  
- [System.NullReferenceException](https://docs.microsoft.com/en-us/dotnet/api/System.NullReferenceException 'System.NullReferenceException')  
- [System.ObjectDisposedException](https://docs.microsoft.com/en-us/dotnet/api/System.ObjectDisposedException 'System.ObjectDisposedException')  
- [System.OutOfMemoryException](https://docs.microsoft.com/en-us/dotnet/api/System.OutOfMemoryException 'System.OutOfMemoryException')  
- [System.OverflowException](https://docs.microsoft.com/en-us/dotnet/api/System.OverflowException 'System.OverflowException')  
- [System.RankException](https://docs.microsoft.com/en-us/dotnet/api/System.RankException 'System.RankException')  
- [System.StackOverflowException](https://docs.microsoft.com/en-us/dotnet/api/System.StackOverflowException 'System.StackOverflowException')  
- [System.Threading.ThreadAbortException](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.ThreadAbortException 'System.Threading.ThreadAbortException')  
- [System.TypeInitializationException](https://docs.microsoft.com/en-us/dotnet/api/System.TypeInitializationException 'System.TypeInitializationException')  
- `UnreachableException` (including polyfills)