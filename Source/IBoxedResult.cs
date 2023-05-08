// SPDX-License-Identifier: MPL-2.0
namespace Emik.Results;

/// <summary>
/// Represents an untyped result type, which allows <see cref="Result{TOk, TErr}"/>
/// instances to interact regardless of its generic parameters.
/// </summary>
public interface IBoxedResult
{
    /// <summary>Gets a value indicating whether this <see cref="IBoxedResult"/> has an <c>Ok</c> value.</summary>
    public bool IsOk { get; }

    /// <summary>Gets a value indicating whether this <see cref="IBoxedResult"/> has an <c>Err</c> value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_0_OR_GREATER
    public bool IsErr => !IsOk;
#else
    public bool IsErr { get; }
#endif

    /// <summary>
    /// Gets <c>Ok</c> if this <see cref="IBoxedResult"/> has a success value and <c>Err</c> otherwise.
    /// </summary>
    /// <remarks><para>This process requires boxing for returns that are value-types.</para></remarks>
    public object? Value { get; }
}
