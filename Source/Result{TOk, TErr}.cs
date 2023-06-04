// SPDX-License-Identifier: MPL-2.0
namespace Emik.Results;

using static CollectionAccessType;

/// <summary>
/// <see cref="Result{TOk, TErr}"/> is the type used for returning and propagating errors.
/// It is either <see cref="Ok"/>, representing success and containing a value, or <see cref="Err"/>,
/// representing error and containing an error value.
/// </summary>
/// <remarks><para>
/// The <see cref="Result{TOk, TErr}"/> type encourages that you move away from raising exceptions inside a method,
/// and instead return an error value.<br/>This is to allow the callee of some function to be consciously aware that...
/// </para><list type="bullet">
/// <item><description>a method can fail while not forcing control flow (e.g. try-catch).</description></item>
/// <item><description>let the callee decide the severity of this error.</description></item>
/// <item><description>omits the overhead of catching exceptions.</description></item>
/// </list></remarks>
/// <typeparam name="TOk">The type of the success value.</typeparam>
/// <typeparam name="TErr">The type of the error value.</typeparam>
[StructLayout(LayoutKind.Auto)]
#pragma warning disable MA0048, CA1710
public readonly partial struct Result<TOk, TErr> :
#pragma warning restore MA0048, CA1710
#if NET7_0_OR_GREATER
    IComparisonOperators<Result<TOk, TErr>, Result<TOk, TErr>, bool>,
    IUnaryNegationOperators<Result<TOk, TErr>, Result<TErr, TOk>>,
    IUnaryPlusOperators<Result<TOk, TErr>, Result<TOk, TErr>>,
#endif
#if NET471_OR_GREATER || NETSTANDARD2_1_OR_GREATER || NETCOREAPP2_0_OR_GREATER
    ITuple,
#endif
#if NET40 || NETSTANDARD1_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    IStructuralComparable,
#endif
    IBoxedResult,
    IComparable,
    IComparable<object>,
    IComparable<IBoxedResult>,
    IComparable<Result<TOk, TErr>>,
    IComparer,
    IComparer<object>,
    IComparer<IBoxedResult>,
    IComparer<Result<TOk, TErr>>,
    IEqualityComparer,
    ICollection,
    ICloneable,
    IEquatable<object>,
    IEquatable<IBoxedResult>,
    IEquatable<Result<TOk, TErr>>,
    IEqualityComparer<object>,
    IEqualityComparer<IBoxedResult>,
    IEqualityComparer<Result<TOk, TErr>>,
    IFormattable,
    IList<TOk>,
    IReadOnlyList<TOk>,
    IReadOnlySet<TOk>,
    ISet<TOk>
    where TOk : notnull
    where TErr : notnull
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Result{TOk, TErr}"/> struct. The error value is specified.
    /// </summary>
    /// <param name="err">The error value to pass in.</param>
    public Result(TErr err)
    {
        Err = err;
        IsOk = false;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Result{TOk, TErr}"/> struct. The success value is specified.
    /// </summary>
    /// <param name="ok">The success value to pass in.</param>
    public Result([ProvidesContext] TOk ok)
    {
        Ok = ok;
        IsOk = true;
    }

    /// <inheritdoc />
    [CollectionAccess(None), MemberNotNullWhen(false, nameof(Ok)), MemberNotNullWhen(true, nameof(Err)), Pure]
    public bool IsErr => !IsOk;

    /// <inheritdoc />
    [CollectionAccess(None), MemberNotNullWhen(false, nameof(Err)), MemberNotNullWhen(true, nameof(Ok)), Pure]
    public bool IsOk { get; }

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ICollection.IsSynchronized => true;

    /// <inheritdoc cref="ICollection{T}.IsReadOnly"/>
    [CollectionAccess(None), Pure]
    bool ICollection<TOk>.IsReadOnly => true;

    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(1)]
    int ICollection.Count => 1;

    /// <inheritdoc cref="ICollection{T}.Count"/>
    [CollectionAccess(None), Pure, ValueRange(1)]
    int ICollection<TOk>.Count => 1;
#if NETSTANDARD2_1_OR_GREATER || NET471_OR_GREATER || NETCOREAPP2_0_OR_GREATER
    /// <inheritdoc />
    [CollectionAccess(None), Pure, ValueRange(2)]
    int ITuple.Length => 2;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    object ITuple.this[[ValueRange(0, 1)] int index] =>
        index switch
        {
            0 => Ok,
            1 => Err, // ReSharper disable once UnreachableSwitchArmDueToIntegerAnalysis
            _ => (object?)null,
        } ??
        Result.None;
#endif

    /// <inheritdoc cref="IReadOnlyCollection{T}.Count"/>
    [CollectionAccess(None), Pure, ValueRange(1)]
    int IReadOnlyCollection<TOk>.Count => 1;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    object ICollection.SyncRoot => new();

    /// <inheritdoc cref="IBoxedResult.Value"/>
    [CollectionAccess(Read), Pure]
    public object Value => (IsOk ? (object)Ok : Err) ?? Result.None;

    /// <summary>Gets the error value. This value may not be set and is therefore optional.</summary>
    [CollectionAccess(None), Pure]
    public TErr? Err { get; }

    /// <summary>Gets the success value. This value may not be set and is therefore optional.</summary>
    [CollectionAccess(Read), ProvidesContext, Pure]
    public TOk? Ok { get; }

    /// <inheritdoc cref="IList{T}.this"/>
    TOk IList<TOk>.this[int _]
    {
        [CollectionAccess(Read), MustUseReturnValue] get => Expect();
        [CollectionAccess(None)] set { }
    }

    /// <inheritdoc cref="IList{T}.this"/>
    TOk IReadOnlyList<TOk>.this[int _]
    {
        [CollectionAccess(Read), MustUseReturnValue] get => Expect();
    }

    /// <summary>
    /// Implicitly converts <typeparamref name="TErr"/> into <see cref="Result{TOk, TErr}"/>.
    /// The error value is specified.
    /// </summary>
    /// <param name="err">The error value to pass in.</param>
    /// <returns>An encapsulation of the parameter <paramref name="err"/>.</returns>
    [Pure]
    public static implicit operator Result<TOk, TErr>(TErr err) => new(err);

    /// <summary>
    /// Implicitly converts <typeparamref name="TOk"/> into <see cref="Result{TOk, TErr}"/>.
    /// The success value is specified.
    /// </summary>
    /// <param name="ok">The success value to pass in.</param>
    /// <returns>An encapsulation of the parameter <paramref name="ok"/>.</returns>
    [Pure]
    public static implicit operator Result<TOk, TErr>([ProvidesContext] TOk ok) => new(ok);

    /// <inheritdoc cref="ResultFactory.Flatten{TOk, TErr}(Result{Result{TOk, TErr}, TErr})"/>
    [Pure]
    public static implicit operator Result<TOk, TErr>(Result<Result<TOk, TErr>, TErr> result) => result.Flatten();

    /// <inheritdoc cref="ResultFactory.Flatten{TOk, TErr}(Result{TOk, Result{TOk, TErr}})"/>
    [Pure]
    public static implicit operator Result<TOk, TErr>(Result<TOk, Result<TOk, TErr>> result) => result.Flatten();

    /// <inheritdoc cref="ResultFactory.Flatten{TOk, TErr}(Result{Result{TOk, TErr}, Result{TOk, TErr}})"/>
    [Pure]
    public static implicit operator Result<TOk, TErr>(Result<Result<TOk, TErr>, Result<TOk, TErr>> result) =>
        result.Flatten();

    /// <summary>Implicitly converts <see cref="Result{TOk, TErr}"/> into <typeparamref name="TErr"/>.</summary>
    /// <param name="result">The result to pass in.</param>
    /// <returns>The property <see cref="Err"/>.</returns>
    [Pure]
    public static explicit operator TErr?(Result<TOk, TErr> result) => result.Err;

    /// <summary>Implicitly converts <see cref="Result{TOk, TErr}"/> into <typeparamref name="TErr"/>.</summary>
    /// <param name="result">The result to pass in.</param>
    /// <returns>The property <see cref="Err"/>, coalesced.</returns>
    [Pure]
    public static explicit operator TErr?(Result<TOk, TErr>? result) => result.HasValue ? result.Value.Err : default;

    /// <summary>Implicitly converts <see cref="Result{TOk, TErr}"/> into <typeparamref name="TOk"/>.</summary>
    /// <param name="result">The result to pass in.</param>
    /// <returns>The property <see cref="Ok"/>.</returns>
    [Pure]
    public static explicit operator TOk?(Result<TOk, TErr> result) => result.Ok;

    /// <summary>Implicitly converts <see cref="Result{TOk, TErr}"/> into <typeparamref name="TOk"/>.</summary>
    /// <param name="result">The result to pass in.</param>
    /// <returns>The property <see cref="Ok"/>, coalesced.</returns>
    [Pure]
    public static explicit operator TOk?(Result<TOk, TErr>? result) => result.HasValue ? result.Value.Ok : default;

    /// <inheritdoc cref="IsOk"/>
    [Pure]
    public static bool operator true(Result<TOk, TErr> result) => result.IsOk;

    /// <inheritdoc cref="IsErr"/>
    [Pure]
    public static bool operator false(Result<TOk, TErr> result) => result.IsErr;

    /// <summary>
    /// Determines if both results have the same value.
    /// <see cref="Ok"/> and <see cref="Err"/> are evaluated separately.
    /// </summary>
    /// <param name="left">The left-hand side parameter.</param>
    /// <param name="right">The right-hand side parameter.</param>
    /// <returns>
    /// The value <see langword="true"/> if both are <see cref="Ok"/> or <see cref="Err"/> and
    /// contain the same inner value, otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool operator ==(Result<TOk, TErr> left, Result<TOk, TErr> right) => left.Equals(right);

    /// <summary>
    /// Determines if both results do not have the same value.
    /// <see cref="Ok"/> and <see cref="Err"/> are evaluated separately.
    /// </summary>
    /// <param name="left">The left-hand side parameter.</param>
    /// <param name="right">The right-hand side parameter.</param>
    /// <returns>
    /// The value <see langword="false"/> if both are <see cref="Ok"/> or <see cref="Err"/> and
    /// contain the same inner value, otherwise <see langword="true"/>.
    /// </returns>
    [Pure]
    public static bool operator !=(Result<TOk, TErr> left, Result<TOk, TErr> right) => !(left == right);

    /// <summary>Determines if the left result is lesser than the right.</summary>
    /// <param name="left">The left-hand side parameter.</param>
    /// <param name="right">The right-hand side parameter.</param>
    /// <returns>
    /// The value <see langword="true"/> if either <paramref name="left"/> is <see cref="Err"/> and
    /// <paramref name="right"/> is <see cref="Ok"/>, or both are <see cref="Ok"/> or <see cref="Err"/>
    /// and <paramref name="left"/>'s inner value is lesser than the <paramref name="right"/>'s inner
    /// value, otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool operator <(Result<TOk, TErr> left, Result<TOk, TErr> right) => left.CompareTo(right) < 0;

    /// <summary>Determines if the left result is lesser or equal to the right.</summary>
    /// <param name="left">The left-hand side parameter.</param>
    /// <param name="right">The right-hand side parameter.</param>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="left"/> is lesser or equal to <paramref name="right"/>,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool operator <=(Result<TOk, TErr> left, Result<TOk, TErr> right) => left.CompareTo(right) <= 0;

    /// <summary>Determines if the left result is greater than the right.</summary>
    /// <param name="left">The left-hand side parameter.</param>
    /// <param name="right">The right-hand side parameter.</param>
    /// <returns>
    /// The value <see langword="true"/> if either <paramref name="left"/> is <see cref="Err"/> and
    /// <paramref name="right"/> is <see cref="Ok"/>, or both are <see cref="Ok"/> or <see cref="Err"/>
    /// and <paramref name="left"/>'s inner value is greater than the <paramref name="right"/>'s inner
    /// value, otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool operator >(Result<TOk, TErr> left, Result<TOk, TErr> right) => left.CompareTo(right) > 0;

    /// <summary>Determines if the left result is greater or equal to the right.</summary>
    /// <param name="left">The left-hand side parameter.</param>
    /// <param name="right">The right-hand side parameter.</param>
    /// <returns>
    /// The value <see langword="true"/> if <paramref name="left"/> is greater or equal to <paramref name="right"/>,
    /// otherwise <see langword="false"/>.
    /// </returns>
    [Pure]
    public static bool operator >=(Result<TOk, TErr> left, Result<TOk, TErr> right) => left.CompareTo(right) >= 0;

    /// <inheritdoc cref="Or(Converter{TErr, Result{TOk, TErr}})"/>
    [Pure]
    public static Result<TOk, TErr> operator |(
        Result<TOk, TErr> result,
        Converter<TErr, Result<TOk, TErr>> converter
    ) =>
        result.Or(converter);

    /// <inheritdoc cref="Or(Result{TOk, TErr})"/>
    [Pure]
    public static Result<TOk, TErr> operator |(Result<TOk, TErr> result, Result<TOk, TErr> def) => result.Or(def);

    /// <inheritdoc cref="ErrOr(Converter{TOk, TErr})"/>
    [Pure]
    public static TErr operator |(Result<TOk, TErr> result, Converter<TOk, TErr> def) => result.ErrOr(def);

    /// <inheritdoc cref="ErrOr(TErr)"/>
    [Pure]
    public static TErr operator |(Result<TOk, TErr> result, TErr def) => result.ErrOr(def);

    /// <inheritdoc cref="OkOr(Converter{TErr, TOk})"/>
    [Pure]
    public static TOk operator |(Result<TOk, TErr> result, Converter<TErr, TOk> def) => result.OkOr(def);

    /// <inheritdoc cref="OkOr(TOk)"/>
    [Pure]
    public static TOk operator |(Result<TOk, TErr> result, TOk def) => result.OkOr(def);

    /// <inheritdoc cref="And(Converter{TOk, Result{TOk, TErr}})"/>
    [Pure]
    public static Result<TOk, TErr> operator &(Result<TOk, TErr> result, Converter<TOk, Result<TOk, TErr>> converter) =>
        result.And(converter);

    /// <inheritdoc cref="And(Result{TOk, TErr})"/>
    [Pure]
    public static Result<TOk, TErr> operator &(Result<TOk, TErr> result, Result<TOk, TErr> def) => result.And(def);

    /// <inheritdoc cref="Swap"/>
    [Pure]
    public static Result<TErr, TOk> operator -(Result<TOk, TErr> result) => result.Swap();

    /// <summary>Returns itself.</summary>
    /// <param name="result">The parameter to return.</param>
    /// <returns>The parameter <paramref name="result"/>.</returns>
    [Pure]
    public static Result<TOk, TErr> operator +(Result<TOk, TErr> result) => result;

    /// <inheritdoc />
    [CollectionAccess(Read)]
    public void CopyTo(Array array, int index)
    {
        if (IsOk)
            array.SetValue(Ok, index);
    }

    /// <inheritdoc />
    [CollectionAccess(Read)]
    public void CopyTo(TOk[] array, int arrayIndex)
    {
        if (IsOk)
            array[arrayIndex] = Ok;
    }

    /// <summary>
    /// Destructures the <see cref="Result{TOk, TErr}"/> into 2 optional values, <see cref="Ok"/> and <see cref="Err"/>.
    /// </summary>
    /// <param name="ok">The success value.</param>
    /// <param name="err">The error value.</param>
    [CollectionAccess(Read), Pure]
    public void Deconstruct(out TOk? ok, out TErr? err)
    {
        ok = Ok;
        err = Err;
    }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ICollection<TOk>.Add(TOk? item) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ICollection<TOk>.Clear() { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void IList<TOk>.Insert(int index, TOk? item) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void IList<TOk>.RemoveAt(int index) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ISet<TOk>.ExceptWith(IEnumerable<TOk>? other) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ISet<TOk>.IntersectWith(IEnumerable<TOk>? other) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ISet<TOk>.SymmetricExceptWith(IEnumerable<TOk>? other) { }

    /// <inheritdoc />
    [CollectionAccess(None)]
    void ISet<TOk>.UnionWith(IEnumerable<TOk>? other) { }

    /// <inheritdoc cref="object.Equals(object)"/>
    [CollectionAccess(Read), Pure]
    public override bool Equals([NotNullWhen(true)] object? obj) => Equals(obj as IBoxedResult);

    /// <summary>
    /// Performs an equality comparison between <see cref="Result{TOk, TErr}.Ok"/> and the parameter,
    /// or <see langword="false"/>.
    /// </summary>
    /// <param name="item">The value to compare.</param>
    /// <returns>
    /// The result of the comparison of <see cref="Result{TOk, TErr}.Ok"/>, or <see langword="false"/>.
    /// </returns>
    [CollectionAccess(Read), MemberNotNullWhen(true, nameof(Ok)), Pure]
    public bool Contains([NotNullWhen(true)] TOk? item) => IsOk && IsEqual(Ok, item);

    /// <summary>
    /// Performs an equality comparison between <see cref="Result{TOk, TErr}.Err"/> and the parameter,
    /// or <see langword="false"/>.
    /// </summary>
    /// <param name="item">The value to compare.</param>
    /// <returns>
    /// The result of the comparison of <see cref="Result{TOk, TErr}.Err"/>, or <see langword="false"/>.
    /// </returns>
    [CollectionAccess(None), MemberNotNullWhen(true, nameof(Err)), Pure]
    public bool ContainsErr([NotNullWhen(true)] TErr? item) => IsErr && IsEqual(Err, item);

    /// <inheritdoc />
    [CollectionAccess(Read), Pure]
    public bool Equals([NotNullWhen(true)] IBoxedResult? other) =>
        other is not null &&
        (other.IsOk ? other.Value is TOk ok && Contains(ok) : other.Value is TErr err && ContainsErr(err));

    /// <inheritdoc/>
    [CollectionAccess(Read), Pure]
    public bool Equals(Result<TOk, TErr> other) =>
        other.IsOk && Contains(other.Ok) || other.IsErr && ContainsErr(other.Err);

    /// <summary>
    /// Calls a <see cref="Predicate{T}"/> for <see cref="Err"/> if <see cref="Err"/> is set,
    /// or returns <see langword="false"/>.
    /// </summary>
    /// <param name="predicate">The predicate to match the inner value with.</param>
    /// <returns>
    /// Returns <see langword="true"/> if this <see cref="Result{TOk, TErr}"/> has
    /// <see cref="Err"/> and the value of it matches <paramref name="predicate"/>.
    /// </returns>
    [CollectionAccess(None), MemberNotNullWhen(true, nameof(Err)), MustUseReturnValue]
    public bool IsErrAnd(Predicate<TErr> predicate) => IsErr && predicate(Err);

    /// <summary>
    /// Calls a <see cref="Predicate{T}"/> for <see cref="Ok"/> if <see cref="Ok"/> is set,
    /// or returns <see langword="false"/>.
    /// </summary>
    /// <param name="predicate">The predicate to match the inner value with.</param>
    /// <returns>
    /// Returns <see langword="true"/> if this <see cref="Result{TOk, TErr}"/> has
    /// <see cref="Ok"/> and the value of it matches <paramref name="predicate"/>.
    /// </returns>
    [CollectionAccess(Read | ModifyExistingContent), MemberNotNullWhen(true, nameof(Ok)), MustUseReturnValue]
    public bool IsOkAnd(Predicate<TOk> predicate) => IsOk && predicate(Ok);

    /// <inheritdoc cref="ISet{T}.IsProperSubsetOf" />
    [CollectionAccess(Read), MemberNotNullWhen(true, nameof(Ok)), Pure]
    public bool IsProperSubsetOf([InstantHandle] IEnumerable<TOk> other) =>
        other.ToCollectionLazily() is { Count: > 1 } c && Overlaps(c);

    /// <inheritdoc cref="ISet{T}.IsProperSupersetOf" />
    [CollectionAccess(Read), Pure]
    public bool IsProperSupersetOf([InstantHandle] IEnumerable<TOk> other) =>
#if NET20 || NET30
        !other.GetEnumerator().MoveNext();
#else
        !other.Any();
#endif

    /// <inheritdoc cref="ISet{T}.IsSubsetOf" />
    [CollectionAccess(Read), MemberNotNullWhen(true, nameof(Ok)), Pure]
    public bool IsSubsetOf([InstantHandle] IEnumerable<TOk> other) => Overlaps(other);

    /// <inheritdoc cref="ISet{T}.IsSupersetOf" />
    [CollectionAccess(Read), MemberNotNullWhen(true, nameof(Ok)), Pure]
    public bool IsSupersetOf([InstantHandle] IEnumerable<TOk> other) =>
        other.ToCollectionLazily() is { Count: <= 1 } c && Overlaps(c);

    /// <summary>
    /// Destructures the <see cref="Result{TOk, TErr}"/> into 2 optional values, <see cref="Ok"/> and <see cref="Err"/>.
    /// </summary>
    /// <param name="ok">The success value.</param>
    /// <param name="err">The error value.</param>
    /// <returns>The value <see cref="IsOk"/>, with nullability awareness for the out parameters.</returns>
    [CollectionAccess(Read), MemberNotNullWhen(false, nameof(Err)), MemberNotNullWhen(true, nameof(Ok)), Pure]
    public bool Out([NotNullWhen(true)] out TOk? ok, [NotNullWhen(false)] out TErr? err)
    {
        (ok, err) = this;
        return IsOk;
    }

    /// <summary>Useful for ternary operators to use a temporary value when <see cref="Err"/> is set.</summary>
    /// <param name="err">The error value.</param>
    /// <returns>The value <see cref="IsErr"/>, with nullability awareness for the out parameter.</returns>
    [CollectionAccess(None), MemberNotNullWhen(true, nameof(Err)), MemberNotNullWhen(false, nameof(Ok)), Pure]
    public bool OutErr([NotNullWhen(true)] out TErr? err)
    {
        err = Err;
        return IsErr;
    }

    /// <summary>Useful for ternary operators to use a temporary value when <see cref="Ok"/> is set.</summary>
    /// <param name="ok">The success value.</param>
    /// <returns>The value <see cref="IsOk"/>, with nullability awareness for the out parameter.</returns>
    [CollectionAccess(Read), MemberNotNullWhen(false, nameof(Err)), MemberNotNullWhen(true, nameof(Ok)), Pure]
    public bool OutOk([NotNullWhen(true)] out TOk? ok)
    {
        ok = Ok;
        return IsOk;
    }

    /// <inheritdoc cref="ISet{T}.Overlaps" />
    [CollectionAccess(Read), MemberNotNullWhen(true, nameof(Ok)), Pure]
    public bool Overlaps([InstantHandle] IEnumerable<TOk> other) =>
        IsOk &&
        other
#if NET20 || NET30
           .ToCollectionLazily()
#endif
           .Contains(Ok);

    /// <inheritdoc cref="ISet{T}.SetEquals" />
    [CollectionAccess(Read), Pure]
    public bool SetEquals([InstantHandle] IEnumerable<TOk> other) =>
#if NET20 || NET30
        other.GetEnumerator() is var e && e.MoveNext() && e.Current is { } current ? Contains(current) : IsErr;
#else
        other.SequenceEqual(this);
#endif

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ICollection<TOk>.Remove(TOk item) => false;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IEqualityComparer.Equals(object? x, object? y) =>
        x is IBoxedResult xResult && y is IBoxedResult yResult ? xResult.Equals(yResult) : IsEqual(x, y);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IEqualityComparer<object>.Equals(object? x, object? y) => x is null ? y is null : y is not null && x.Equals(y);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool IEqualityComparer<IBoxedResult>.Equals(IBoxedResult? x, IBoxedResult? y) =>
        x switch
        {
            Result<TOk, TErr> xResult when y is Result<TOk, TErr> yResult => xResult.Equals(yResult),
            not null when y is not null => x.IsOk == y.IsOk && IsEqual(x.Value, y.Value),
            _ => y is null,
        };

    /// <inheritdoc/>
    [CollectionAccess(None), Pure]
    bool IEqualityComparer<Result<TOk, TErr>>.Equals(Result<TOk, TErr> x, Result<TOk, TErr> y) => x.Equals(y);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    bool ISet<TOk>.Add(TOk? item) => false;

    /// <inheritdoc/>
    [CollectionAccess(Read), Pure]
    public override int GetHashCode() => IsOk ? Ok.GetHashCode() ^ 0x6b6f7961 : Err.GetHashCode() ^ 0x7265726f;

    /// <inheritdoc cref="IComparable{T}.CompareTo" />
    [CollectionAccess(Read), Pure]
    public int CompareTo(object? obj) => obj is IBoxedResult x ? CompareTo(x) : DoCompare(obj, this);

#if NET40 || NETSTANDARD1_0_OR_GREATER || NETCOREAPP1_0_OR_GREATER
    /// <inheritdoc />
    [CollectionAccess(Read), Pure]
    public int CompareTo(object? other, IComparer? comparer) =>
        other is IBoxedResult result ? CompareTo(result) : (comparer ?? Comparer.Default).Compare(this, other);
#endif

    /// <inheritdoc />
    [CollectionAccess(Read), Pure]
    public int CompareTo(IBoxedResult? other) =>
        other switch
        {
            Result<TOk, TErr> result => CompareTo(result),
            { Value: var value } => IsOk ?
                other.IsOk ? value is TOk ok ? DoCompare(Ok, ok) : DoCompare(Ok, value) : -1 :
                other.IsOk ? 1 :
                    value is TErr err ? DoCompare(Err, err) : DoCompare(Err, value),
            _ => 1,
        };

    /// <inheritdoc />
    [CollectionAccess(Read), Pure]
    public int CompareTo(Result<TOk, TErr> other) =>
        IsOk ? other.IsOk ? DoCompare(Ok, other.Ok) : -1 :
        other.IsOk ? 1 : DoCompare(Err, other.Err);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IComparer<IBoxedResult>.Compare(IBoxedResult? x, IBoxedResult? y) => DoCompare(x, y);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IComparer.Compare(object? x, object? y) =>
        x is IBoxedResult xResult && y is IBoxedResult yResult ? DoCompare(xResult, yResult) : DoCompare(x, y);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IComparer<object>.Compare(object? x, object? y) => Comparer.Default.Compare(x, y);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IComparer<Result<TOk, TErr>>.Compare(Result<TOk, TErr> x, Result<TOk, TErr> y) => x.CompareTo(y);

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IEqualityComparer.GetHashCode(object? obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IEqualityComparer<object>.GetHashCode(object? obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc />
    [CollectionAccess(None), Pure]
    int IEqualityComparer<IBoxedResult>.GetHashCode(IBoxedResult? obj) => obj?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    [CollectionAccess(None), Pure]
    int IEqualityComparer<Result<TOk, TErr>>.GetHashCode(Result<TOk, TErr> obj) => obj.GetHashCode();

    /// <inheritdoc />
    [CollectionAccess(Read), Pure, ValueRange(-1, 0)]
    int IList<TOk>.IndexOf(TOk? item) => Contains(item) ? 0 : -1;

    /// <inheritdoc/>
    [CollectionAccess(Read), Pure]
    public override string ToString() => IsOk ? $"Ok({Ok})" : $"Err({Err})";

    /// <inheritdoc />
    [CollectionAccess(Read), Pure]
    public string ToString(string? format, IFormatProvider? formatProvider) =>
        IsOk ? Ok is IFormattable fOk ? $"Ok({fOk.ToString(format, formatProvider)})" : ToString() :
        Err is IFormattable fErr ? $"Err({fErr.ToString(format, formatProvider)})" : ToString();

    /// <inheritdoc/>
    [CollectionAccess(None), Pure]
    public object Clone() => this;

    /// <summary>Creates an enumeration for <see cref="Ok"/>.</summary>
    /// <remarks><para>For more details, see <see cref="Enumerator"/>.</para></remarks>
    /// <returns>An <see cref="Enumerator"/> that doesn't return anything, or returns <see cref="Ok"/> once.</returns>
    [CollectionAccess(Read), Pure]
    public Enumerator GetEnumerator() => IsOk ? new(Ok) : default;

    /// <inheritdoc/>
    [CollectionAccess(Read), Pure]
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc/>
    [CollectionAccess(Read), Pure]
    IEnumerator<TOk> IEnumerable<TOk>.GetEnumerator() => GetEnumerator();

    /// <summary>Gets itself, or the returned value of the parameter.</summary>
    /// <remarks><para>
    /// The default value is lazily evaluated, use <see cref="And(Result{TOk, TErr})"/> for eager evaluation.
    /// </para></remarks>
    /// <param name="converter">
    /// The delegate to invoke and return if this <see cref="Result{TOk, TErr}"/> is <see cref="Ok"/>.
    /// </param>
    /// <returns>Itself or the result of <paramref name="converter"/>.</returns>
    [CollectionAccess(None), MustUseReturnValue]
    public Result<TOk, TErr> And([InstantHandle] Converter<TOk, Result<TOk, TErr>> converter) =>
        IsOk ? converter(Ok) : this;

    /// <summary>
    /// Applies a selector to <see cref="Ok"/> if <see cref="Ok"/> is set, leaving <see cref="Err"/> untouched.
    /// </summary>
    /// <typeparam name="T">The new <typeparamref name="TOk"/> type.</typeparam>
    /// <param name="converter">The selector to change <see cref="Ok"/>.</param>
    /// <returns>
    /// Another <see cref="Result{TOk, TErr}"/> with the result of <paramref name="converter"/>
    /// if this <see cref="Result{TOk, TErr}"/> is <see cref="Ok"/>, otherwise <see cref="Err"/>.
    /// </returns>
    [CollectionAccess(Read | ModifyExistingContent), MustUseReturnValue]
    public Result<T, TErr> And<T>([InstantHandle] Converter<TOk, Result<T, TErr>> converter)
        where T : notnull =>
        IsOk ? converter(Ok) : Err;

    /// <summary>Gets itself, or the parameter.</summary>
    /// <remarks><para>
    /// The default value is eagerly evaluated,
    /// use <see cref="And(Converter{TOk, Result{TOk, TErr}})"/> for lazy evaluation.
    /// </para></remarks>
    /// <param name="def">The default value if this <see cref="Result{TOk, TErr}"/> is <see cref="Ok"/>.</param>
    /// <returns>Itself or <paramref name="def"/>.</returns>
    [CollectionAccess(None), Pure]
    public Result<TOk, TErr> And(Result<TOk, TErr> def) => IsOk ? def : this;

    /// <summary>
    /// Invokes a delegate if this <see cref="Result{TOk, TErr}"/> is <see cref="Ok"/>, and returns itself.
    /// </summary>
    /// <param name="action">The delegate to invoke if this <see cref="Result{TOk, TErr}"/> is <see cref="Ok"/>.</param>
    /// <returns>Itself.</returns>
    [CollectionAccess(Read | ModifyExistingContent), MustUseReturnValue]
    public Result<TOk, TErr> Inspect([InstantHandle] Action<TOk> action)
    {
        if (IsOk)
            action(Ok);

        return this;
    }

    /// <summary>Performs a non-exhaustive match statement.</summary>
    /// <param name="onOk">The delegate to invoke when <see cref="Ok"/>.</param>
    /// <param name="onErr">The delegate to invoke when <see cref="Err"/>.</param>
    /// <returns>Itself.</returns>
    [CollectionAccess(Read | ModifyExistingContent), MustUseReturnValue]
    public Result<TOk, TErr> Inspect([InstantHandle] Action<TOk> onOk, [InstantHandle] Action<TErr> onErr)
    {
        if (IsOk)
            onOk(Ok);
        else
            onErr(Err);

        return this;
    }

    /// <summary>
    /// Invokes a delegate if this <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>, and returns itself.
    /// </summary>
    /// <param name="action">
    /// The delegate to invoke if this <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>.
    /// </param>
    /// <returns>Itself.</returns>
    [CollectionAccess(None), MustUseReturnValue]
    public Result<TOk, TErr> InspectErr([InstantHandle] Action<TErr> action)
    {
        if (IsErr)
            action(Err);

        return this;
    }

    /// <summary>
    /// Applies a selector to <see cref="Ok"/> if <see cref="Ok"/> is set, leaving <see cref="Err"/> untouched.
    /// </summary>
    /// <typeparam name="T">The new <typeparamref name="TOk"/> type.</typeparam>
    /// <param name="converter">The selector to change <see cref="Ok"/>.</param>
    /// <returns>
    /// Another <see cref="Result{TOk, TErr}"/> with the result of <paramref name="converter"/>
    /// if this <see cref="Result{TOk, TErr}"/> is <see cref="Ok"/>, otherwise <see cref="Err"/>.
    /// </returns>
    [CollectionAccess(Read | ModifyExistingContent), MustUseReturnValue]
    public Result<T, TErr> Map<T>([InstantHandle] Converter<TOk, T> converter)
        where T : notnull =>
        IsOk ? converter(Ok) : Err;

    /// <summary>
    /// Applies a selector to <see cref="Err"/> if <see cref="Err"/> is set, leaving <see cref="Ok"/> untouched.
    /// </summary>
    /// <typeparam name="T">The new <typeparamref name="TErr"/> type.</typeparam>
    /// <param name="converter">The selector to change <see cref="Err"/>.</param>
    /// <returns>
    /// Another <see cref="Result{TOk, TErr}"/> with the result of <paramref name="converter"/>
    /// if this <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>, otherwise <see cref="Ok"/>.
    /// </returns>
    [CollectionAccess(Read), MustUseReturnValue]
    public Result<TOk, T> MapErr<T>([InstantHandle] Converter<TErr, T> converter)
        where T : notnull =>
        IsErr ? converter(Err) : Ok;

    /// <summary>Gets itself, or the returned value of the parameter.</summary>
    /// <remarks><para>
    /// The default value is lazily evaluated, use <see cref="Or(Result{TOk, TErr})"/> for eager evaluation.
    /// </para></remarks>
    /// <param name="converter">
    /// The delegate to invoke and return if this <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>.
    /// </param>
    /// <returns>Itself or the result of <paramref name="converter"/>.</returns>
    [CollectionAccess(None), MustUseReturnValue]
    public Result<TOk, TErr> Or([InstantHandle] Converter<TErr, Result<TOk, TErr>> converter) =>
        IsOk ? this : converter(Err);

    /// <summary>
    /// Applies a selector to <see cref="Err"/> if <see cref="Err"/> is set, leaving <see cref="Ok"/> untouched.
    /// </summary>
    /// <typeparam name="T">The new <typeparamref name="TErr"/> type.</typeparam>
    /// <param name="converter">The selector to change <see cref="Err"/>.</param>
    /// <returns>
    /// Another <see cref="Result{TOk, TErr}"/> with the result of <paramref name="converter"/>
    /// if this <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>, otherwise <see cref="Ok"/>.
    /// </returns>
    [CollectionAccess(Read), MustUseReturnValue]
    public Result<TOk, T> Or<T>([InstantHandle] Converter<TErr, Result<TOk, T>> converter)
        where T : notnull =>
        IsErr ? converter(Err) : Ok;

    /// <summary>Gets itself, or the parameter.</summary>
    /// <remarks><para>
    /// The default value is eagerly evaluated,
    /// use <see cref="Or(Converter{TErr, Result{TOk, TErr}})"/> for lazy evaluation.
    /// </para></remarks>
    /// <param name="def">The default value if this <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>.</param>
    /// <returns>Itself or <paramref name="def"/>.</returns>
    [CollectionAccess(None), Pure]
    public Result<TOk, TErr> Or(Result<TOk, TErr> def) => IsOk ? this : def;

    /// <summary>
    /// Applies a selector to <see cref="Ok"/> if <see cref="Ok"/> is set, leaving <see cref="Err"/> untouched.
    /// </summary>
    /// <param name="action">The selector to change <see cref="Ok"/>.</param>
    /// <returns>
    /// Another <see cref="Result{TOk, TErr}"/> with the result of <paramref name="action"/>
    /// if this <see cref="Result{TOk, TErr}"/> is <see cref="Ok"/>, otherwise <see cref="Err"/>.
    /// </returns>
    [CollectionAccess(Read | ModifyExistingContent), MustUseReturnValue]
    public Result<Result<object, Exception>, TErr> Try([InstantHandle] Action<TOk> action) =>
        IsOk ? Please.Try(action, Ok) : Err;

    /// <summary>
    /// Applies a selector to <see cref="Ok"/> if <see cref="Ok"/> is set, leaving <see cref="Err"/> untouched.
    /// </summary>
    /// <typeparam name="T">The new <typeparamref name="TOk"/> type.</typeparam>
    /// <param name="converter">The selector to change <see cref="Ok"/>.</param>
    /// <returns>
    /// Another <see cref="Result{TOk, TErr}"/> with the result of <paramref name="converter"/>
    /// if this <see cref="Result{TOk, TErr}"/> is <see cref="Ok"/>, otherwise <see cref="Err"/>.
    /// </returns>
    [CollectionAccess(Read | ModifyExistingContent), MustUseReturnValue]
    public Result<Result<T, Exception>, TErr> Try<T>([InstantHandle] Converter<TOk, T> converter)
        where T : notnull =>
        IsOk ? Please.TryMap(converter, Ok) : Err;

    /// <summary>
    /// Applies a selector to <see cref="Err"/> if <see cref="Err"/> is set, leaving <see cref="Ok"/> untouched.
    /// </summary>
    /// <param name="action">The selector to change <see cref="Err"/>.</param>
    /// <returns>
    /// Another <see cref="Result{TOk, TErr}"/> with the result of <paramref name="action"/>
    /// if this <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>, otherwise <see cref="Ok"/>.
    /// </returns>
    [CollectionAccess(Read), MustUseReturnValue]
    public Result<TOk, Result<object, Exception>> TryErr([InstantHandle] Action<TErr> action) =>
        IsErr ? Please.Try(action, Err) : Ok;

    /// <summary>
    /// Applies a selector to <see cref="Err"/> if <see cref="Err"/> is set, leaving <see cref="Ok"/> untouched.
    /// </summary>
    /// <typeparam name="T">The new <typeparamref name="TErr"/> type.</typeparam>
    /// <param name="converter">The selector to change <see cref="Err"/>.</param>
    /// <returns>
    /// Another <see cref="Result{TOk, TErr}"/> with the result of <paramref name="converter"/>
    /// if this <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>, otherwise <see cref="Ok"/>.
    /// </returns>
    [CollectionAccess(Read), MustUseReturnValue]
    public Result<TOk, Result<T, Exception>> TryErr<T>([InstantHandle] Converter<TErr, T> converter)
        where T : notnull =>
        IsErr ? Please.TryMap(converter, Err) : Ok;

    /// <summary>Performs an exhaustive match statement.</summary>
    /// <param name="onOk">The delegate to invoke when <see cref="Ok"/>.</param>
    /// <param name="onErr">The delegate to invoke when <see cref="Err"/>.</param>
    /// <returns>
    /// The result of <paramref name="onOk"/> if <see cref="Ok"/>, otherwise the result of <paramref name="onErr"/>.
    /// </returns>
    [CollectionAccess(Read | ModifyExistingContent), MustUseReturnValue]
    public Result<object, Exception> TryMatch(
        [InstantHandle] Action<TOk> onOk,
        [InstantHandle] Action<TErr> onErr
    ) =>
        IsOk ? Please.Try(onOk, Ok) : Please.Try(onErr, Err);

    /// <summary>Performs an exhaustive match statement.</summary>
    /// <typeparam name="T">The return value of both converters.</typeparam>
    /// <param name="onOk">The delegate to invoke when <see cref="Ok"/>.</param>
    /// <param name="onErr">The delegate to invoke when <see cref="Err"/>.</param>
    /// <returns>
    /// The result of <paramref name="onOk"/> if <see cref="Ok"/>, otherwise the result of <paramref name="onErr"/>.
    /// </returns>
    [CollectionAccess(Read | ModifyExistingContent), MustUseReturnValue]
    public Result<T, Exception> TryMatch<T>(
        [InstantHandle] Converter<TOk, T> onOk,
        [InstantHandle] Converter<TErr, T> onErr
    )
        where T : notnull =>
        IsOk ? Please.TryMap(onOk, Ok) : Please.TryMap(onErr, Err);

    /// <summary>Swaps the success and error value.</summary>
    /// <returns>Itself with the generics and values swapped.</returns>
    [CollectionAccess(Read), Pure]
    public Result<TErr, TOk> Swap() => IsOk ? Ok : Err;

    /// <summary>Performs an exhaustive match statement.</summary>
    /// <typeparam name="T">The return value of both converters.</typeparam>
    /// <param name="onOk">The delegate to invoke when <see cref="Ok"/>.</param>
    /// <param name="onErr">The delegate to invoke when <see cref="Err"/>.</param>
    /// <returns>
    /// The result of <paramref name="onOk"/> if <see cref="Ok"/>, otherwise the result of <paramref name="onErr"/>.
    /// </returns>
    [CollectionAccess(Read | ModifyExistingContent), MustUseReturnValue]
    public T Match<T>([InstantHandle] Converter<TOk, T> onOk, [InstantHandle] Converter<TErr, T> onErr) =>
        IsOk ? onOk(Ok) : onErr(Err);

    /// <summary>Gets the <see cref="Ok"/> value, or the parameter.</summary>
    /// <remarks><para>
    /// The default value is eagerly evaluated, use <see cref="OkOr(Converter{TErr, TOk})"/> for lazy evaluation.
    /// </para></remarks>
    /// <param name="def">The default value if this <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>.</param>
    /// <returns>The value <see cref="Ok"/>, or <paramref name="def"/>.</returns>
    [CollectionAccess(None), Pure]
    public TErr ErrOr(TErr def) => IsErr ? Err : def;

    /// <summary>Gets the <see cref="Ok"/> value, or the returned value of the parameter.</summary>
    /// <remarks><para>
    /// The default value is lazily evaluated, use <see cref="OkOr(TOk)"/> for eager evaluation.
    /// </para></remarks>
    /// <param name="converter">
    /// The delegate to invoke and return if this <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>.
    /// </param>
    /// <returns>The value <see cref="Ok"/>, or the result of <paramref name="converter"/>.</returns>
    [CollectionAccess(Read | ModifyExistingContent), MustUseReturnValue]
    public TErr ErrOr([InstantHandle] Converter<TOk, TErr> converter) => IsErr ? Err : converter(Ok);

    /// <summary>Gets the error value. Throws if this value is not set.</summary>
    /// <param name="message">The message to send into <see cref="ResultException{T}"/>.</param>
    /// <exception cref="ResultException{T}">This <see cref="Result{TOk, TErr}"/> is <see cref="Ok"/>.</exception>
    /// <returns>The value <see cref="Err"/>.</returns>
    [CollectionAccess(Read), MemberNotNull(nameof(Err))]
    public TErr ExpectErr(string? message = null) =>
        IsErr
            ? Err
            : (TErr)ResultException<TOk>.SmartThrow(message, Ok, $"Received an {nameof(Ok)} on {nameof(ExpectErr)}.");

    /// <summary>Gets the success value. Throws if this value is not set.</summary>
    /// <param name="message">The message to send into <see cref="ResultException{T}"/>.</param>
    /// <exception cref="ResultException{T}">This <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>.</exception>
    /// <returns>The value <see cref="Ok"/>.</returns>
    [CollectionAccess(Read), MemberNotNull(nameof(Ok))]
    public TOk Expect(string? message = null) =>
        IsOk
            ? Ok
            : (TOk)ResultException<TErr>.SmartThrow(message, Err, $"Received an {nameof(Err)} on {nameof(Expect)}.");

    /// <summary>Gets the <see cref="Ok"/> value, or the parameter.</summary>
    /// <remarks><para>
    /// The default value is eagerly evaluated, use <see cref="OkOr(Converter{TErr, TOk})"/> for lazy evaluation.
    /// </para></remarks>
    /// <param name="def">The default value if this <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>.</param>
    /// <returns>The value <see cref="Ok"/>, or <paramref name="def"/>.</returns>
    [CollectionAccess(Read), Pure]
    public TOk OkOr(TOk def) => IsOk ? Ok : def;

    /// <summary>Gets the <see cref="Ok"/> value, or the returned value of the parameter.</summary>
    /// <remarks><para>
    /// The default value is lazily evaluated, use <see cref="OkOr(TOk)"/> for eager evaluation.
    /// </para></remarks>
    /// <param name="converter">
    /// The delegate to invoke and return if this <see cref="Result{TOk, TErr}"/> is <see cref="Err"/>.
    /// </param>
    /// <returns>The value <see cref="Ok"/>, or the result of <paramref name="converter"/>.</returns>
    [CollectionAccess(Read), MustUseReturnValue]
    public TOk OkOr([InstantHandle] Converter<TErr, TOk> converter) => IsOk ? Ok : converter(Err);

    [Pure]
    static bool IsEqual<T>(T? x, T? y) =>
        x is null || y is null ? x is null && y is null : EqualityComparer<T>.Default.Equals(x, y);

    [CollectionAccess(None), Pure]
    static int DoCompare(IBoxedResult? x, IBoxedResult? y)
    {
        if (x is null || y is null)
            return x is null && y is null ? 0 :
                x is null ? -1 : 1;

        if (x is Result<TOk, TErr> xResult && y is Result<TOk, TErr> yResult)
            return xResult.CompareTo(yResult);

        var isXOk = x.IsOk;
        var xValue = x.Value;

        var isYOk = y.IsOk;
        var yValue = y.Value;

        return isXOk != isYOk
            ? isXOk ? -1 : 1
            : xValue switch
            {
                TOk xOk when yValue is TOk yOk => DoCompare(xOk, yOk),
                TErr xErr when yValue is TErr yErr => DoCompare(xErr, yErr),
                _ => DoCompare(xValue, yValue),
            };
    }

    [CollectionAccess(None), Pure]
    static int DoCompare<T>(T? x, T? y) =>
        x switch
        {
            null when y is null => 0,
            null => -1,
            _ when y is null => 1,
            _ => Comparer<T>.Default.Compare(x, y),
        };

    /// <summary>Represents an enumeration that is either empty or returns a value once.</summary>
    [StructLayout(LayoutKind.Auto)]
    public struct Enumerator : IEnumerator<TOk>
    {
        /// <summary>Initializes a new instance of the <see cref="Enumerator"/> struct.</summary>
        /// <param name="ok">The value to <see langword="yield"/> once.</param>
        public Enumerator([ProvidesContext] TOk ok)
        {
            Current = ok;
            IsOk = true;
        }

        /// <summary>
        /// Gets a value indicating whether <see cref="MoveNext"/> will
        /// return <see langword="true"/> or <see langword="false"/>.
        /// </summary>
        [Pure]
        public readonly bool CanMoveNext => IsOk && !IsEnd;

        /// <summary>
        /// Gets a value indicating whether this <see cref="Enumerator"/> has been used.
        /// </summary>
        [Pure]
        public bool IsEnd { get; private set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="Enumerator"/> has an <see cref="Ok"/> value.
        /// </summary>
        [Pure]
        public bool IsOk { get; }

        /// <inheritdoc />
        [ProvidesContext, Pure]
        public TOk Current { get; }

        /// <inheritdoc />
        [Pure]
        readonly object IEnumerator.Current => Current;

        /// <inheritdoc />
        readonly void IDisposable.Dispose() { }

        /// <inheritdoc />
        public void Reset() => IsEnd = false;

        /// <inheritdoc />
        [MustUseReturnValue]
        public bool MoveNext() => CanMoveNext && (IsEnd = true);
    }
}
