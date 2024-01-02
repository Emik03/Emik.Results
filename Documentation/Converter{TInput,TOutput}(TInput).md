#### [Emik.Results](index.md 'index')
### [Emik.Results](Emik.Results.md 'Emik.Results')

## Converter<TInput,TOutput>(TInput) Delegate

<b>POLYFILL:</b> Represents a method that converts an object from one type to another type.

```csharp
public delegate TOutput Converter<in TInput,out TOutput>(TInput input);
```
#### Type parameters

<a name='Emik.Results.Converter_TInput,TOutput_(TInput).TInput'></a>

`TInput`

The type of object that is to be converted.

<a name='Emik.Results.Converter_TInput,TOutput_(TInput).TOutput'></a>

`TOutput`

The type the input object is to be converted to.
#### Parameters

<a name='Emik.Results.Converter_TInput,TOutput_(TInput).input'></a>

`input` [TInput](Converter{TInput,TOutput}(TInput).md#Emik.Results.Converter_TInput,TOutput_(TInput).TInput 'Emik.Results.Converter<TInput,TOutput>(TInput).TInput')

The object to convert.

#### Returns
[TOutput](Converter{TInput,TOutput}(TInput).md#Emik.Results.Converter_TInput,TOutput_(TInput).TOutput 'Emik.Results.Converter<TInput,TOutput>(TInput).TOutput')  
The [TOutput](Converter{TInput,TOutput}(TInput).md#Emik.Results.Converter_TInput,TOutput_(TInput).TOutput 'Emik.Results.Converter<TInput,TOutput>(TInput).TOutput') that represents the converted [TInput](Converter{TInput,TOutput}(TInput).md#Emik.Results.Converter_TInput,TOutput_(TInput).TInput 'Emik.Results.Converter<TInput,TOutput>(TInput).TInput').

### Remarks
  
This type only appears for .NET Standard 1.0 - 1.6.