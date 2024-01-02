#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Please](Please.md 'Emik.Results.Please')

## Please.CatchFatalExceptions Property

Gets or sets a value indicating whether exception filters should be  
according to [IsFatal(this Exception)](Fatalities.IsFatal(Exception).md 'Emik.Results.Extensions.Fatalities.IsFatal(this System.Exception)'), or have no filter at all.

```csharp
public static bool CatchFatalExceptions { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

#### Exceptions

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The setter is used in .NET Standard 1.0 - 1.6.

### Remarks
  
This value is unique per assembly to allow for configuration, without altering the behavior of other assemblies.  
  
It is encouraged to use a module initializer or static constructor to set this value.