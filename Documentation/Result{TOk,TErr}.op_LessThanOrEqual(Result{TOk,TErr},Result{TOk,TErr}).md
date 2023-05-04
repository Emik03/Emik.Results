#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results').[Result&lt;TOk,TErr&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

## Result<TOk,TErr>.operator <=(Result<TOk,TErr>, Result<TOk,TErr>) Operator

Determines if the left result is lesser or equal to the right.

```csharp
public static bool operator <=(Emik.Results.Result<TOk,TErr> left, Emik.Results.Result<TOk,TErr> right);
```
#### Parameters

<a name='Emik.Results.Result_TOk,TErr_.op_LessThanOrEqual(Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr_).left'></a>

`left` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

The left-hand side parameter.

<a name='Emik.Results.Result_TOk,TErr_.op_LessThanOrEqual(Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr_).right'></a>

`right` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TOk](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TOk 'Emik.Results.Result<TOk,TErr>.TOk')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[TErr](Result{TOk,TErr}.md#Emik.Results.Result_TOk,TErr_.TErr 'Emik.Results.Result<TOk,TErr>.TErr')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

The right-hand side parameter.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The value [true](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool') if [left](Result{TOk,TErr}.op_LessThanOrEqual(Result{TOk,TErr},Result{TOk,TErr}).md#Emik.Results.Result_TOk,TErr_.op_LessThanOrEqual(Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr_).left 'Emik.Results.Result<TOk,TErr>.op_LessThanOrEqual(Emik.Results.Result<TOk,TErr>, Emik.Results.Result<TOk,TErr>).left') is lesser or equal to [right](Result{TOk,TErr}.op_LessThanOrEqual(Result{TOk,TErr},Result{TOk,TErr}).md#Emik.Results.Result_TOk,TErr_.op_LessThanOrEqual(Emik.Results.Result_TOk,TErr_,Emik.Results.Result_TOk,TErr_).right 'Emik.Results.Result<TOk,TErr>.op_LessThanOrEqual(Emik.Results.Result<TOk,TErr>, Emik.Results.Result<TOk,TErr>).right'),  
otherwise [false](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/bool').