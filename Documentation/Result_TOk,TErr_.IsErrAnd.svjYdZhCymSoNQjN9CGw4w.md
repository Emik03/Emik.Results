#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.IsErrAnd(Predicate<TErr>) Method

Calls a [System.Predicate&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1') for [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err') if [Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err') is set,  
or returns [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').

```csharp
public bool IsErrAnd(System.Predicate<TErr> predicate);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.IsErrAnd(System.Predicate_TErr_).predicate'></a>

`predicate` [System.Predicate&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')[TErr](Result_TOk,TErr_.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Predicate-1 'System.Predicate`1')

The predicate to match the inner value with.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Returns [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if this [Result&lt;TOk,TErr&gt;](Result_TOk,TErr_.md 'Emik.Results.Result<TOk,TErr>') has  
[Err](Result_TOk,TErr_.Err.md 'Emik.Results.Result<TOk,TErr>.Err') and the value of it matches [predicate](Result_TOk,TErr_.IsErrAnd.svjYdZhCymSoNQjN9CGw4w.md#Emik.Results.Result_TOk,TErr_.IsErrAnd(System.Predicate_TErr_).predicate 'Emik.Results.Result<TOk,TErr>.IsErrAnd(System.Predicate<TErr>).predicate').