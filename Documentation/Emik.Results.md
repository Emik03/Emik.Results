#### [Emik.Results](index.md 'index')

## Emik.Results Namespace

| Classes | |
| :--- | :--- |
| [Please](Please.md 'Emik.Results.Please') | Methods to wrap try-catch into a [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>'). |
| [Result](Result.md 'Emik.Results.Result') | Methods to create result types from singular values. |
| [ResultException&lt;T&gt;](ResultException_T_.md 'Emik.Results.ResultException<T>') | Represents an [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') thrown by [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>'). |

| Structs | |
| :--- | :--- |
| [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') | [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') is the type used for returning and propagating errors.<br/>            It is either [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), representing success and containing a value, or [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err'),<br/>            representing error and containing an error value. |
| [Result&lt;TOk,TErr&gt;.Enumerator](Result_TOk,TErr_.Enumerator.md 'Emik.Results.Result<TOk,TErr>.Enumerator') | Represents an enumeration that is either empty or returns a value once. |

| Interfaces | |
| :--- | :--- |
| [IFatal](IFatal.md 'Emik.Results.IFatal') | Non-generic [ResultException&lt;T&gt;](ResultException_T_.md 'Emik.Results.ResultException<T>'). Implement this to disallow catching in [Please](Please.md 'Emik.Results.Please').<br/>If [Value](IFatal.Value.md 'Emik.Results.IFatal.Value') has no appropriate implementation, simply [return](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/return')[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null'). |
