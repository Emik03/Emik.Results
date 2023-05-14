#### [Emik.Results](index.md 'index')
### [Emik.Results.Extensions](Emik.Results.Extensions.md 'Emik.Results.Extensions').[ResultFactory](ResultFactory.md 'Emik.Results.Extensions.ResultFactory')

## ResultFactory.OkOrErr<T>(this Result<T,T>) Method

Returns the value, but unlike [Value](Result{TOk,TErr}.Value.md 'Emik.Results.Result<TOk,TErr>.Value'),  
nothing is boxed since both types are the same.

```csharp
public static T OkOrErr<T>(this Emik.Results.Result<T,T> result)
    where T : notnull;
```
#### Type parameters

<a name='Emik.Results.Extensions.ResultFactory.OkOrErr_T_(thisEmik.Results.Result_T,T_).T'></a>

`T`

The success and error type.
#### Parameters

<a name='Emik.Results.Extensions.ResultFactory.OkOrErr_T_(thisEmik.Results.Result_T,T_).result'></a>

`result` [Emik.Results.Result&lt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](ResultFactory.OkOrErr{T}(Result{T,T}).md#Emik.Results.Extensions.ResultFactory.OkOrErr_T_(thisEmik.Results.Result_T,T_).T 'Emik.Results.Extensions.ResultFactory.OkOrErr<T>(this Emik.Results.Result<T,T>).T')[,](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')[T](ResultFactory.OkOrErr{T}(Result{T,T}).md#Emik.Results.Extensions.ResultFactory.OkOrErr_T_(thisEmik.Results.Result_T,T_).T 'Emik.Results.Extensions.ResultFactory.OkOrErr<T>(this Emik.Results.Result<T,T>).T')[&gt;](Result{TOk,TErr}.md 'Emik.Results.Result<TOk,TErr>')

The result parameter.

#### Returns
[T](ResultFactory.OkOrErr{T}(Result{T,T}).md#Emik.Results.Extensions.ResultFactory.OkOrErr_T_(thisEmik.Results.Result_T,T_).T 'Emik.Results.Extensions.ResultFactory.OkOrErr<T>(this Emik.Results.Result<T,T>).T')  
The value of [result](ResultFactory.OkOrErr{T}(Result{T,T}).md#Emik.Results.Extensions.ResultFactory.OkOrErr_T_(thisEmik.Results.Result_T,T_).result 'Emik.Results.Extensions.ResultFactory.OkOrErr<T>(this Emik.Results.Result<T,T>).result').

### Remarks
  
Both the success and error types must be the same.