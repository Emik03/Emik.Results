#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.Expect(string) Method

Gets the success value. Throws if this value is not set.

```csharp
public TOk Expect(string? message=null);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.Expect(string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The message to send into [ResultException&lt;T&gt;](ResultException{T}.md 'Emik.Results.ResultException<T>').

#### Returns
[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')  
The value [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok').

#### Exceptions

[ResultException&lt;T&gt;](ResultException{T}.md 'Emik.Results.ResultException<T>')  
This [Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>') is [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err').