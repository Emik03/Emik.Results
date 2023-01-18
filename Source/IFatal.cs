// SPDX-License-Identifier: MPL-2.0

// ReSharper disable once CheckNamespace
namespace Emik.Results;

/// <summary>
/// Non-generic <see cref="ResultException{T}"/>. Implement this to disallow catching in <see cref="Please"/>.
/// If <see cref="Value"/> has no appropriate implementation, simply <see langword="return"/> <see langword="null"/>.
/// </summary>
/// <remarks><para>For more details, see <see cref="ResultException{T}"/>.</para></remarks>
public interface IFatal
{
    /// <summary>Gets the value.</summary>
    public object? Value { get; }
}
