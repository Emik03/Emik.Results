// SPDX-License-Identifier: MPL-2.0
namespace Emik.Results;

/// <summary>A polyfill of <c>System.ValueTuple</c> that this library use in-place of its lack of existence.</summary>
#if !NETSTANDARD1_0 && !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6 && !NETCOREAPP1_0 && !NETCOREAPP1_1
[Serializable]
#endif
#pragma warning disable CA1036, CA1066, CA1815, CA2231, MA0096, MA0097
public readonly struct Unit :
#pragma warning restore CA1036, CA1066, CA1815, CA2231, MA0096, MA0097
#if !NET20 && !NET30 && !NET35
    IStructuralEquatable,
    IStructuralComparable,
#endif
    IComparable,
    IComparable<Unit>
{
    /// <summary>
    /// Returns a value that indicates whether the current <see cref="ValueTuple"/> instance is equal to a specified object.
    /// </summary>
    /// <param name="obj">The object to compare with this instance.</param>
    /// <returns><see langword="true"/> if <paramref name="obj"/> is a <see cref="ValueTuple"/>.</returns>
    [Pure]
    public override bool Equals([NotNullWhen(true)] object? obj) => obj is Unit;

    /// <summary>Returns a value indicating whether this instance is equal to a specified value.</summary>
    /// <param name="other">An instance to compare to this instance.</param>
    /// <returns>true if <paramref name="other"/> has the same value as this instance; otherwise, false.</returns>
    [Pure]
#pragma warning disable IDE0060, RCS1163
    public bool Equals(Unit other) => true;
#pragma warning restore IDE0060, RCS1163

    /// <inheritdoc/>
    [Pure, ValueRange(0, 1)]
    int IComparable.CompareTo(object? other) =>
        other switch
        {
            null => 1,
            Unit => 0,
            _ => throw new ArgumentException($"Not null or {nameof(Unit)}", nameof(other)),
        };

    /// <summary>
    /// Compares this instance to a specified instance and returns an indication of their relative values.
    /// </summary>
    /// <param name="other">An instance to compare.</param>
    /// <returns>
    /// A signed number indicating the relative values of this instance and <paramref name="other"/>.
    /// Returns less than zero if this instance is less than <paramref name="other"/>, zero if this
    /// instance is equal to <paramref name="other"/>, and greater than zero if this instance is greater
    /// than <paramref name="other"/>.
    /// </returns>
    [Pure, ValueRange(0)]
    public int CompareTo(Unit other) => 0;

    /// <summary>Returns the hash code for this instance.</summary>
    /// <returns>A 32-bit signed integer hash code.</returns>
    [Pure, ValueRange(0)]
    public override int GetHashCode() => 0;
#if !NET20 && !NET30 && !NET35
        [Pure]
        bool IStructuralEquatable.Equals(object? other, IEqualityComparer comparer) => other is Unit;

        [Pure]
        int IStructuralEquatable.GetHashCode(IEqualityComparer comparer) => 0;

        [Pure, ValueRange(0)]
        int IStructuralComparable.CompareTo(object? other, IComparer comparer) =>
            other switch
            {
                null => 1,
                Unit => 0,
                _ => throw new ArgumentException(),
            };
#endif

    /// <summary>Returns a string that represents the value of this <see cref="Unit"/> instance.</summary>
    /// <remarks><para>The string returned by this method takes the form <c>()</c>.</para></remarks>
    /// <returns>The string representation of this <see cref="Unit"/> instance.</returns>
    [Pure]
    public override string ToString() => "()";
}
