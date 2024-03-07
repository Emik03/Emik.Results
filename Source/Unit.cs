// SPDX-License-Identifier: MPL-2.0
namespace Emik.Results;

// ReSharper disable RedundantExtendsListEntry
using static CollectionAccessType;

/// <summary><see cref="Unit"/> is the type used when there is no other meaningful value that can be returned.</summary>
#if !NETSTANDARD1_0 && !NETSTANDARD1_1 && !NETSTANDARD1_2 && !NETSTANDARD1_3 && !NETSTANDARD1_4 && !NETSTANDARD1_5 && !NETSTANDARD1_6 && !NETCOREAPP1_0 && !NETCOREAPP1_1
[Serializable]
#endif
#pragma warning disable CA1710
public readonly struct Unit :
#pragma warning restore CA1710
#if NET7_0_OR_GREATER
    IComparisonOperators<Unit, Unit, bool>,
#endif
#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
    ITuple,
#endif
#if NET40 || NETSTANDARD1_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    IStructuralComparable,
    IStructuralEquatable,
#endif
#if NETFRAMEWORK || NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_0_OR_GREATER
    ICloneable,
#endif
    IComparable,
    IComparable<object>,
    IComparable<Unit>,
    IComparer,
    IComparer<object>,
    IComparer<Unit>,
    IEqualityComparer,
    IEnumerator,
    IEnumerator<object>,
    IEnumerator<Unit>,
    ICollection,
    IEquatable<object>,
    IEquatable<Unit>,
    IEqualityComparer<object>,
    IEqualityComparer<Unit>,
    IFormattable,
    IList<object>,
    IList<Unit>,
    IReadOnlyList<object>,
    IReadOnlyList<Unit>,
    IReadOnlySet<object>,
    IReadOnlySet<Unit>,
    ISet<object>,
    ISet<Unit>
{
    /// <summary>The hash code of <see cref="Unit"/>, returned by <see cref="GetHashCode()"/>.</summary>
    [ValueRange(Hash)]
    public const int Hash = 0x7FFFFFFF;

    /// <summary>The string representation of <see cref="Unit"/>, returned by <see cref="ToString()"/>.</summary>
    public const string Representation = "()";

    /// <summary>Gets the boxed value of <see cref="Unit"/>.</summary>
    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    public static object Boxed { [CollectionAccess(None), Pure] get; } = default(Unit);

    static
#if NETSTANDARD2_0_OR_GREATER || !NETSTANDARD
        Comparer
#else
        Comparer<object?>
#endif
#pragma warning disable SCA1007
        FallbackComparer
#pragma warning restore SCA1007
    {
        [Pure]
        get =>
#if NETSTANDARD2_0_OR_GREATER || !NETSTANDARD
            Comparer.Default;
#else
            Comparer<object?>.Default;
#endif
    }

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ICollection.IsSynchronized => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ICollection<object>.IsReadOnly => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ICollection<Unit>.IsReadOnly => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(0)]
    int ICollection.Count => 0;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(0)]
    int ICollection<object>.Count => 0;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(0)]
    int ICollection<Unit>.Count => 0;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(0)]
    int IReadOnlyCollection<object>.Count => 0;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(0)]
    int IReadOnlyCollection<Unit>.Count => 0;

#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(0)]
    int ITuple.Length => 0;
#endif

    /// <inheritdoc />
    // Do not use Boxed. The shared instance could unnecessarily lock a thread even though this type is thread-safe.
    [CollectionAccess(None), Pure]
    object ICollection.SyncRoot => this;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    object IEnumerator.Current => Boxed;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    object IEnumerator<object>.Current => Boxed;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    object IList<object>.this[int index]
    {
        get => Boxed;
        set { }
    }

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    object IReadOnlyList<object>.this[int index] => Boxed;

#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    object ITuple.this[int index] => Boxed;
#endif

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    Unit IEnumerator<Unit>.Current => this;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    Unit IList<Unit>.this[int index]
    {
        get => this;
        set { }
    }

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    Unit IReadOnlyList<Unit>.this[int index] => this;

    /// <summary>Returns <see langword="true"/>.</summary>
    /// <param name="left">The left-hand side parameter.</param>
    /// <param name="right">The right-hand side parameter.</param>
    /// <returns>The value <see langword="true"/>.</returns>
    [Pure]
    public static bool operator ==(Unit left, Unit right) => true;

    /// <summary>Returns <see langword="false"/>.</summary>
    /// <param name="left">The left-hand side parameter.</param>
    /// <param name="right">The right-hand side parameter.</param>
    /// <returns>The value <see langword="false"/>.</returns>
    [Pure]
    public static bool operator !=(Unit left, Unit right) => false;

    /// <inheritdoc cref="op_Inequality"/>
    [Pure]
    public static bool operator <(Unit left, Unit right) => false;

    /// <inheritdoc cref="op_Equality"/>
    [Pure]
    public static bool operator <=(Unit left, Unit right) => true;

    /// <inheritdoc cref="op_Inequality"/>
    [Pure]
    public static bool operator >(Unit left, Unit right) => false;

    /// <inheritdoc cref="op_Equality"/>
    [Pure]
    public static bool operator >=(Unit left, Unit right) => true;

    /// <summary>Determines if the given <see cref="IEnumerable{T}"/> is empty.</summary>
    /// <typeparam name="T">The type of the <see cref="IEnumerable{T}"/>.</typeparam>
    /// <param name="enumerable">The <see cref="IEnumerable{T}"/> to check.</param>
    /// <returns>
    /// The value <see langword="true"/> if the <see cref="IEnumerable{T}"/>
    /// is empty; otherwise, <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool SequenceEqual<T>([InstantHandle, NotNullWhen(false)] IEnumerable<T>? enumerable)
#if NET20 || NET30
    {
        if (typeof(T) == typeof(char) && enumerable is "" ||
            enumerable is null or ICollection { Count: 0 } or ICollection<T> { Count: 0 })
            return true;

        using var e = enumerable.GetEnumerator();
        return !e.MoveNext();
    }
#else
        =>
            enumerable?.Any() is not true;
#endif

    /// <inheritdoc cref="object.Equals(object)"/>
    [CollectionAccess(None), Pure]
    public override bool Equals([NotNullWhen(true)] object? obj) => obj is Unit;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(Hash)]
    public override int GetHashCode() => Hash;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    public override string ToString() => Representation;

    /// <summary>Returns itself, which is an empty enumerator.</summary>
    /// <returns>The empty enumerator.</returns>
    [CollectionAccess(None), Pure]
    public Unit GetEnumerator() => this;

    /// <inheritdoc />
    [CollectionAccess(None)]
    void IDisposable.Dispose() { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ICollection.CopyTo(Array? array, int index) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ICollection<object>.Add(object? item) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ICollection<object>.Clear() { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ICollection<object>.CopyTo(object[]? array, int arrayIndex) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ICollection<Unit>.Add(Unit item) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ICollection<Unit>.Clear() { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ICollection<Unit>.CopyTo(Unit[]? array, int arrayIndex) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void IEnumerator.Reset() { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void IList<object>.Insert(int index, object? item) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void IList<object>.RemoveAt(int index) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void IList<Unit>.Insert(int index, Unit item) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void IList<Unit>.RemoveAt(int index) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ISet<object>.ExceptWith([InstantHandle] IEnumerable<object>? other) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ISet<object>.IntersectWith([InstantHandle] IEnumerable<object>? other) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ISet<object>.SymmetricExceptWith([InstantHandle] IEnumerable<object>? other) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ISet<object>.UnionWith([InstantHandle] IEnumerable<object>? other) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ISet<Unit>.ExceptWith([InstantHandle] IEnumerable<Unit>? other) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ISet<Unit>.IntersectWith([InstantHandle] IEnumerable<Unit>? other) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ISet<Unit>.SymmetricExceptWith([InstantHandle] IEnumerable<Unit>? other) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ISet<Unit>.UnionWith([InstantHandle] IEnumerable<Unit>? other) { }

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ICollection<object>.Contains(object item) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ICollection<object>.Remove(object? item) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ICollection<Unit>.Contains(Unit item) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ICollection<Unit>.Remove(Unit item) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IEnumerator.MoveNext() => false;

    /// <inheritdoc />
    bool IEqualityComparer.Equals(object? x, object? y) => false;

    /// <inheritdoc />
    bool IEqualityComparer<object>.Equals(object? x, object? y) => x is null && y is null || x is Unit && y is Unit;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IEqualityComparer<Unit>.Equals(Unit x, Unit y) => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IEquatable<Unit>.Equals(Unit other) => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<object>.IsProperSubsetOf(IEnumerable<object> other) => !SequenceEqual(other);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<object>.IsProperSupersetOf(IEnumerable<object> other) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<object>.IsSubsetOf(IEnumerable<object> other) => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<object>.IsSupersetOf(IEnumerable<object> other) => SequenceEqual(other);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<object>.Overlaps(IEnumerable<object> other) => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<object>.SetEquals([InstantHandle] IEnumerable<object> other) => SequenceEqual(other);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<object>.Contains(object? item) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<Unit>.IsProperSubsetOf([InstantHandle] IEnumerable<Unit>? other) => !SequenceEqual(other);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<Unit>.IsProperSupersetOf([InstantHandle] IEnumerable<Unit>? other) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<Unit>.IsSubsetOf([InstantHandle] IEnumerable<Unit>? other) => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<Unit>.IsSupersetOf([InstantHandle] IEnumerable<Unit>? other) => SequenceEqual(other);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<Unit>.Overlaps([InstantHandle] IEnumerable<Unit>? other) => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<Unit>.SetEquals([InstantHandle] IEnumerable<Unit>? other) => SequenceEqual(other);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IReadOnlySet<Unit>.Contains(Unit item) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<object>.Add(object item) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<object>.IsProperSubsetOf([InstantHandle] IEnumerable<object>? other) => !SequenceEqual(other);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<object>.IsProperSupersetOf([InstantHandle] IEnumerable<object>? other) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<object>.IsSubsetOf([InstantHandle] IEnumerable<object>? other) => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<object>.IsSupersetOf([InstantHandle] IEnumerable<object>? other) => SequenceEqual(other);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<object>.Overlaps([InstantHandle] IEnumerable<object>? other) => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<object>.SetEquals([InstantHandle] IEnumerable<object>? other) => SequenceEqual(other);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<Unit>.Add(Unit item) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<Unit>.IsProperSubsetOf([InstantHandle] IEnumerable<Unit>? other) => !SequenceEqual(other);

    /// <inheritdoc />
    bool ISet<Unit>.IsProperSupersetOf([InstantHandle] IEnumerable<Unit>? other) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<Unit>.IsSubsetOf([InstantHandle] IEnumerable<Unit>? other) => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<Unit>.IsSupersetOf([InstantHandle] IEnumerable<Unit>? other) => SequenceEqual(other);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<Unit>.Overlaps([InstantHandle] IEnumerable<Unit>? other) => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<Unit>.SetEquals([InstantHandle] IEnumerable<Unit>? other) => SequenceEqual(other);

#if !NET20 && !NET30 && !NET35
    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IStructuralEquatable.Equals(object? other, IEqualityComparer? comparer) =>
        comparer?.Equals(this, other) ?? other is Unit;
#endif

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IComparer.Compare(object? x, object? y) => 0;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IComparer<object>.Compare(object? x, object? y) =>
        x switch
        {
            null when y is null => 0,
            null when y is Unit => -1,
            Unit when y is null => 1,
            Unit when y is Unit => 0,
            _ => FallbackComparer.Compare(x, y),
        };

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(0)]
    int IComparer<Unit>.Compare(Unit x, Unit y) => 0;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IComparable.CompareTo(object? other) =>
        other switch
        {
            null => 1,
            Unit => 0,
            _ => FallbackComparer.Compare(this, other),
        };

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IComparable<object>.CompareTo(object? other) =>
        other switch
        {
            null => 1,
            Unit => 0,
            _ => FallbackComparer.Compare(this, other),
        };

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(0)]
    int IComparable<Unit>.CompareTo(Unit other) => 0;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(Hash)]
    int IEqualityComparer.GetHashCode(object? obj) => Hash;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(Hash)]
    int IEqualityComparer<object>.GetHashCode(object? obj) => Hash;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(Hash)]
    int IEqualityComparer<Unit>.GetHashCode(Unit obj) => Hash;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(-1)]
    int IList<object>.IndexOf(object? item) => -1;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(-1)]
    int IList<Unit>.IndexOf(Unit item) => -1;

#if !NET20 && !NET30 && !NET35
    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IStructuralComparable.CompareTo(object? other, IComparer? comparer) =>
        comparer?.Compare(this, other) ??
        other switch
        {
            null => 1,
            Unit => 0,
            _ => FallbackComparer.Compare(this, other),
        };

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IStructuralEquatable.GetHashCode(IEqualityComparer? comparer) => comparer?.GetHashCode(this) ?? Hash;
#endif

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    string IFormattable.ToString(string? format, IFormatProvider? formatProvider) => Representation;
#if NETFRAMEWORK || NETSTANDARD2_0_OR_GREATER || NETCOREAPP2_0_OR_GREATER
    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    object ICloneable.Clone() => this;
#endif

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<object>)[]).GetEnumerator();

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    IEnumerator<object> IEnumerable<object>.GetEnumerator() => ((IEnumerable<object>)[]).GetEnumerator();

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    IEnumerator<Unit> IEnumerable<Unit>.GetEnumerator() => ((IEnumerable<Unit>)[]).GetEnumerator();
}
