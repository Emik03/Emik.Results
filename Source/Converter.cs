// SPDX-License-Identifier: MPL-2.0
#if !(NETFRAMEWORK || NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_0_OR_GREATER)
namespace Emik.Results;

/// <summary>Represents a method that converts an object from one type to another type.</summary>
/// <typeparam name="TInput">The type of object that is to be converted.</typeparam>
/// <typeparam name="TOutput">The type the input object is to be converted to.</typeparam>
/// <param name="input">The object to convert.</param>
/// <returns>The <typeparamref name="TOutput"/> that represents the converted <typeparamref name="TInput"/>.</returns>
public delegate TOutput Converter<in TInput, out TOutput>(TInput input);
#endif
