#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results')

## IFatal Interface

Non-generic [ResultException&lt;T&gt;](ResultException_T_.md 'Emik.Results.ResultException<T>'). Implement this to disallow catching in [Please](Please.md 'Emik.Results.Please').  
If [Value](IFatal.Value().md 'Emik.Results.IFatal.Value') has no appropriate implementation, simply [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

```csharp
public interface IFatal
```

Derived  
&#8627; [ResultException&lt;T&gt;](ResultException_T_.md 'Emik.Results.ResultException<T>')

### Remarks
  
For more details, see [ResultException&lt;T&gt;](ResultException_T_.md 'Emik.Results.ResultException<T>').

| Properties | |
| :--- | :--- |
| [Value](IFatal.Value().md 'Emik.Results.IFatal.Value') | Gets the value. |
