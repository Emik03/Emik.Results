#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Enumerator Struct

Represents an enumeration that is either empty or returns a value once.

```csharp
public struct Result<TOk,TErr>.Enumerator :
System.Collections.Generic.IEnumerator<TOk>,
System.IDisposable,
System.Collections.IEnumerator
```
#### Type parameters

<a name='Emik.Results.Result_TOk,TErr_.Enumerator.TOk'></a>

`TOk`

<a name='Emik.Results.Result_TOk,TErr_.Enumerator.TErr'></a>

`TErr`

Implements [System.Collections.Generic.IEnumerator&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1')[TOk](Result_TOk,TErr_.Enumerator.md#Emik.Results.Result_TOk,TErr_.Enumerator.TOk 'Emik.Results.Result<TOk,TErr>.Enumerator.TOk')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerator-1 'System.Collections.Generic.IEnumerator`1'), [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable'), [System.Collections.IEnumerator](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerator 'System.Collections.IEnumerator')

| Constructors | |
| :--- | :--- |
| [Enumerator(TOk)](Result_TOk,TErr_.Enumerator..ctor.tljqUhjY8VCX3CfMST04aw.md 'Emik.Results.Result<TOk,TErr>.Enumerator.Enumerator(TOk)') | Initializes a new instance of the [Enumerator](Result_TOk,TErr_.Enumerator.md 'Emik.Results.Result<TOk,TErr>.Enumerator') struct. |

| Properties | |
| :--- | :--- |
| [CanMoveNext](Result_TOk,TErr_.Enumerator.CanMoveNext.md 'Emik.Results.Result<TOk,TErr>.Enumerator.CanMoveNext') | Gets a value indicating whether [Emik.Results.Result&lt;&gt;.Enumerator.MoveNext](https://docs.microsoft.com/en-us/dotnet/api/Emik.Results.Result-2.Enumerator.MoveNext 'Emik.Results.Result`2.Enumerator.MoveNext') will<br/>return [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') or [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool'). |
| [IsEnd](Result_TOk,TErr_.Enumerator.IsEnd.md 'Emik.Results.Result<TOk,TErr>.Enumerator.IsEnd') | Gets a value indicating whether this [Enumerator](Result_TOk,TErr_.Enumerator.md 'Emik.Results.Result<TOk,TErr>.Enumerator') has been used. |
| [IsOk](Result_TOk,TErr_.Enumerator.IsOk.md 'Emik.Results.Result<TOk,TErr>.Enumerator.IsOk') | Gets a value indicating whether this [Enumerator](Result_TOk,TErr_.Enumerator.md 'Emik.Results.Result<TOk,TErr>.Enumerator') has an [Ok](Result_TOk,TErr_.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') value. |
