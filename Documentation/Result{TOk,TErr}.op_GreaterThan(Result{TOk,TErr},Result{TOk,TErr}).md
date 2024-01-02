#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.operator >(Result<TOk,TErr>, Result<TOk,TErr>) Operator

Determines if the left result is greater than the right.

```csharp
public static bool operator >(Emik.Results.Result<TOk,TErr> left, Emik.Results.Result<TOk,TErr> right);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.op_GreaterThan(Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr_).left'></a>

`left` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

The left-hand side parameter.

<a name='Emik.Results.Result_TOk,TErr_.op_GreaterThan(Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr_).right'></a>

`right` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

The right-hand side parameter.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if either [left](Result{TOk,TErr}.op_GreaterThan(Result{TOk,TErr},Result{TOk,TErr}).md#Emik.Results.Result_TOk,TErr_.op_GreaterThan(Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr_).left 'Emik.Results.Result<TOk,TErr>.op_GreaterThan(Emik.Results.Result<TOk,TErr>, Emik.Results.Result<TOk,TErr>).left') is [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err') and  
[right](Result{TOk,TErr}.op_GreaterThan(Result{TOk,TErr},Result{TOk,TErr}).md#Emik.Results.Result_TOk,TErr_.op_GreaterThan(Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr_).right 'Emik.Results.Result<TOk,TErr>.op_GreaterThan(Emik.Results.Result<TOk,TErr>, Emik.Results.Result<TOk,TErr>).right') is [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok'), or both are [Ok](Result{TOk,TErr}.Ok.md 'Emik.Results.Result<TOk,TErr>.Ok') or [Err](Result{TOk,TErr}.Err.md 'Emik.Results.Result<TOk,TErr>.Err')  
and [left](Result{TOk,TErr}.op_GreaterThan(Result{TOk,TErr},Result{TOk,TErr}).md#Emik.Results.Result_TOk,TErr_.op_GreaterThan(Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr_).left 'Emik.Results.Result<TOk,TErr>.op_GreaterThan(Emik.Results.Result<TOk,TErr>, Emik.Results.Result<TOk,TErr>).left')'s inner value is greater than the [right](Result{TOk,TErr}.op_GreaterThan(Result{TOk,TErr},Result{TOk,TErr}).md#Emik.Results.Result_TOk,TErr_.op_GreaterThan(Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr_).right 'Emik.Results.Result<TOk,TErr>.op_GreaterThan(Emik.Results.Result<TOk,TErr>, Emik.Results.Result<TOk,TErr>).right')'s inner  
value, otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').