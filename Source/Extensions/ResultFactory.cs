// SPDX-License-Identifier: MPL-2.0
namespace Emik.Results.Extensions;

/// <summary>Additional methods for <see cref="ResultException{T}"/> that are type- or generic-sensitive.</summary>
public static class ResultFactory
{
    /// <summary>Deconstructs the <see cref="IBoxedResult"/>.</summary>
    /// <param name="result">The <see cref="IBoxedResult"/> to deconstruct.</param>
    /// <param name="isOk">The parameter <paramref name="result"/>'s <see cref="IBoxedResult.IsOk"/>.</param>
    /// <param name="value">The parameter <paramref name="result"/>'s <see cref="IBoxedResult.Value"/>.</param>
    public static void Deconstruct(this IBoxedResult? result, out bool isOk, out object value)
    {
        if (result is null)
        {
            isOk = false;
            value = None;
            return;
        }

        isOk = result.IsOk;
        value = result.Value;
    }

    /// <summary>Creates a result from a boolean expression.</summary>
    /// <remarks><para>All parameters are eagerly evaluated.</para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="value">The <see cref="bool"/> value to check.</param>
    /// <param name="ifTrue">
    /// The value to <see langword="return"/> when <paramref name="value"/> is <see langword="true"/>.
    /// </param>
    /// <param name="ifFalse">
    /// The value to <see langword="return"/> when <paramref name="value"/> is <see langword="false"/>.
    /// </param>
    /// <returns>
    /// The parameter <paramref name="ifTrue"/> if <paramref name="value"/> is <see langword="true"/>,
    /// otherwise the parameter <paramref name="ifFalse"/>.
    /// </returns>
    [Pure]
    public static Result<TOk, TErr> Then<TOk, TErr>(this bool value, TOk ifTrue, TErr ifFalse)
        where TOk : notnull
        where TErr : notnull =>
        value ? ifTrue : ifFalse;
#if !NET20 && !NET30
    /// <summary>Creates a result from a boolean expression.</summary>
    /// <remarks><para>All parameters are lazily evaluated.</para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="value">The <see cref="bool"/> value to check.</param>
    /// <param name="onTrue">The value to invoke when <paramref name="value"/> is <see langword="true"/>.</param>
    /// <param name="onFalse">The value to invoke when <paramref name="value"/> is <see langword="false"/>.</param>
    /// <returns>
    /// The parameter <paramref name="onTrue"/> if <paramref name="value"/> is <see langword="true"/>,
    /// otherwise the parameter <paramref name="onFalse"/>.
    /// </returns>
    [MustUseReturnValue]
    public static Result<TOk, TErr> Then<TOk, TErr>(
        this bool value,
        [InstantHandle] Func<TOk> onTrue,
        [InstantHandle] Func<TErr> onFalse
    )
        where TOk : notnull
        where TErr : notnull =>
        value ? onTrue() : onFalse();
#endif

    /// <summary>
    /// Returns all <see cref="Result{TOk, TErr}.Ok"/> values,
    /// or the first-found <see cref="Result{TOk, TErr}.Err"/> if any exist.
    /// </summary>
    /// <remarks><para>The type must be an enumeration of results.</para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="enumerable">The iterable of results.</param>
    /// <returns>
    /// All <see cref="Result{TOk, TErr}.Ok"/> values, or the first <see cref="Result{TOk, TErr}.Err"/>.
    /// </returns>
    [Pure]
    public static Result<IList<TOk>, TErr> Flatten<TOk, TErr>(
        [InstantHandle] this IEnumerable<Result<TOk, TErr>> enumerable
    )
        where TOk : notnull
        where TErr : notnull
    {
        return enumerable.TryCount() is { } count ? Array(enumerable, count) : List(enumerable);

        [Pure]
        static Result<IList<TOk>, TErr> Array(
            [InstantHandle] IEnumerable<Result<TOk, TErr>> enumerable,
            [NonNegativeValue] int count
        )
        {
            var output = new TOk[count];
            var i = 0;

            foreach (var item in enumerable)
                if (item.IsErr)
                    return item.Err;
                else
                    output[i++] = item.Ok;

            return output;
        }

        [Pure]
        static Result<IList<TOk>, TErr> List([InstantHandle] IEnumerable<Result<TOk, TErr>> enumerable)
        {
            List<TOk> output = [];

            foreach (var item in enumerable)
                if (item.IsErr)
                    return item.Err;
                else
                    output.Add(item.Ok);

            return output;
        }
    }

    /// <summary>
    /// Returns all <see cref="Result{TOk, TErr}.Err"/> values,
    /// or the first-found <see cref="Result{TOk, TErr}.Ok"/> if any exist.
    /// </summary>
    /// <remarks><para>The type must be an enumeration of results.</para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="enumerable">The iterable of results.</param>
    /// <returns>
    /// All <see cref="Result{TOk, TErr}.Err"/> values, or the first <see cref="Result{TOk, TErr}.Ok"/>.
    /// </returns>
    [Pure]
    public static Result<TOk, IList<TErr>> FlattenErr<TOk, TErr>(
        [InstantHandle] this IEnumerable<Result<TOk, TErr>> enumerable
    )
        where TOk : notnull
        where TErr : notnull
    {
        return enumerable.TryCount() is { } count ? Array(enumerable, count) : List(enumerable);

        [Pure]
        static Result<TOk, IList<TErr>> Array(
            [InstantHandle] IEnumerable<Result<TOk, TErr>> collection,
            [NonNegativeValue] int count
        )
        {
            var output = new TErr[count];
            var i = 0;

            foreach (var item in collection)
                if (item.IsOk)
                    return item.Ok;
                else
                    output[i++] = item.Err;

            return output;
        }

        [Pure]
        static Result<TOk, IList<TErr>> List([InstantHandle] IEnumerable<Result<TOk, TErr>> enumerable)
        {
            List<TErr> output = [];

            foreach (var item in enumerable)
                if (item.IsOk)
                    return item.Ok;
                else
                    output.Add(item.Err);

            return output;
        }
    }

    /// <summary>Maps the nested results into one result.</summary>
    /// <remarks><para>The parameter must be a nested <see cref="Result{TOk, TErr}"/>.</para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="result">The result parameter.</param>
    /// <returns>The nested results collapsing into one result.</returns>
    [Pure]
    public static Result<TOk, TErr> Flatten<TOk, TErr>(this Result<Result<TOk, TErr>, TErr> result)
        where TOk : notnull
        where TErr : notnull =>
        result.IsOk ? result.Ok : result.Err;

    /// <summary>Maps the nested results into one result.</summary>
    /// <remarks><para>The parameter must be a nested <see cref="Result{TOk, TErr}"/>.</para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="result">The result parameter.</param>
    /// <returns>The nested results collapsing into one result.</returns>
    [Pure]
    public static Result<TOk, TErr> Flatten<TOk, TErr>(this Result<TOk, Result<TOk, TErr>> result)
        where TOk : notnull
        where TErr : notnull =>
        result.IsOk ? result.Ok : result.Err;

    /// <summary>Maps the nested results into one result.</summary>
    /// <remarks><para>The parameter must be a nested <see cref="Result{TOk, TErr}"/>.</para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="result">The result parameter.</param>
    /// <returns>The nested results collapsing into one result.</returns>
    [Pure]
    public static Result<TOk, TErr> Flatten<TOk, TErr>(this Result<Result<TOk, TErr>, Result<TOk, TErr>> result)
        where TOk : notnull
        where TErr : notnull =>
        result.IsOk ? result.Ok : result.Err;

    /// <summary>Maps <typeparamref name="T"/> into a <see cref="Result{TOk, TErr}"/>.</summary>
    /// <typeparam name="T">The error type.</typeparam>
    /// <param name="err">The value to pass in.</param>
    /// <returns>
    /// A <see cref="Result{TOk, TErr}"/> where <paramref name="err"/> is used if it isn't <see langword="null"/>,
    /// or else <see langword="null"/>.
    /// </returns>
    [Pure]
    public static Result<Unit, T> IntoErr<T>(this T? err)
        where T : class =>
        err is null ? Ok<T>() : new(err);

    /// <summary>Maps <typeparamref name="T"/> into a <see cref="Result{TOk, TErr}"/>.</summary>
    /// <typeparam name="T">The error type.</typeparam>
    /// <param name="err">The value to pass in.</param>
    /// <returns>
    /// A <see cref="Result{TOk, TErr}"/> where <paramref name="err"/> is used if it isn't <see langword="null"/>,
    /// or else <see langword="null"/>.
    /// </returns>
    [Pure]
    public static Result<Unit, T> IntoErr<T>(this T? err)
        where T : struct =>
        err is null ? Ok<T>() : new(err);

    /// <summary>Maps <typeparamref name="TErr"/> into a <see cref="Result{TOk, TErr}"/>.</summary>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="err">The value to pass in.</param>
    /// <param name="ok">The value to use instead if <paramref name="err"/> is <see langword="null"/>.</param>
    /// <returns>
    /// A <see cref="Result{TOk, TErr}"/> where <paramref name="err"/> is used if it isn't <see langword="null"/>,
    /// or else <paramref name="ok"/>.
    /// </returns>
    [Pure]
    public static Result<TOk, TErr> IntoErrOr<TOk, TErr>(this TErr? err, TOk ok)
        where TOk : notnull
        where TErr : class =>
        err is null ? ok : err;

    /// <summary>Maps <typeparamref name="TErr"/> into a <see cref="Result{TOk, TErr}"/>.</summary>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="err">The value to pass in.</param>
    /// <param name="ok">The value to use instead if <paramref name="err"/> is <see langword="null"/>.</param>
    /// <returns>
    /// A <see cref="Result{TOk, TErr}"/> where <paramref name="err"/> is used if it isn't <see langword="null"/>,
    /// or else <paramref name="ok"/>.
    /// </returns>
    [Pure]
    public static Result<TOk, TErr> IntoErrOr<TOk, TErr>(this TErr? err, TOk ok)
        where TOk : notnull
        where TErr : struct =>
        err is null ? ok : err.Value;

    /// <summary>Maps <typeparamref name="T"/> into a <see cref="Result{TOk, TErr}"/>.</summary>
    /// <typeparam name="T">The success type.</typeparam>
    /// <param name="ok">The value to pass in.</param>
    /// <returns>
    /// A <see cref="Result{TOk, TErr}"/> where <paramref name="ok"/> is used if it isn't <see langword="null"/>,
    /// or else <see langword="null"/>.
    /// </returns>
    [Pure]
    public static Result<T, Unit> IntoOk<T>(this T? ok)
        where T : struct =>
        ok is null ? Err<T>() : new(ok);

    /// <summary>Maps <typeparamref name="T"/> into a <see cref="Result{TOk, TErr}"/>.</summary>
    /// <typeparam name="T">The success type.</typeparam>
    /// <param name="ok">The value to pass in.</param>
    /// <returns>
    /// A <see cref="Result{TOk, TErr}"/> where <paramref name="ok"/> is used if it isn't <see langword="null"/>,
    /// or else <see langword="null"/>.
    /// </returns>
    [Pure]
    public static Result<T, Unit> IntoOk<T>(this T? ok)
        where T : class =>
        ok is null ? Err<T>() : new(ok);

    /// <summary>Maps <typeparamref name="TOk"/> into a <see cref="Result{TOk, TErr}"/>.</summary>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="ok">The value to pass in.</param>
    /// <param name="err">The value to use instead if <paramref name="ok"/> is <see langword="null"/>.</param>
    /// <returns>
    /// A <see cref="Result{TOk, TErr}"/> where <paramref name="ok"/> is used if it isn't <see langword="null"/>,
    /// or else <paramref name="err"/>.
    /// </returns>
    [Pure]
    public static Result<TOk, TErr> IntoOkOr<TOk, TErr>(this TOk? ok, TErr err)
        where TOk : struct
        where TErr : notnull =>
        ok is null ? err : ok.Value;

    /// <summary>Maps <typeparamref name="TOk"/> into a <see cref="Result{TOk, TErr}"/>.</summary>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="ok">The value to pass in.</param>
    /// <param name="err">The value to use instead if <paramref name="ok"/> is <see langword="null"/>.</param>
    /// <returns>
    /// A <see cref="Result{TOk, TErr}"/> where <paramref name="ok"/> is used if it isn't <see langword="null"/>,
    /// or else <paramref name="err"/>.
    /// </returns>
    [Pure]
    public static Result<TOk, TErr> IntoOkOr<TOk, TErr>(this TOk? ok, TErr err)
        where TOk : class
        where TErr : notnull =>
        ok is null ? err : ok;

    /// <summary>
    /// Gets the value of the <see cref="Result{TOk, TErr}"/> by casting into <typeparamref name="TErr"/>.
    /// </summary>
    /// <remarks><para>
    /// The generic parameter <typeparamref name="TErr"/> must implement or inherit <typeparamref name="TOk"/>.
    /// </para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="result">The result parameter.</param>
    /// <returns>
    /// The value <see cref="Result{TOk, TErr}.Ok"/> as <typeparamref name="TErr"/>,
    /// or <see cref="Result{TOk, TErr}.Err"/>.
    /// </returns>
    [Pure]
    public static TErr ErrOr<TOk, TErr>(this Result<TOk, TErr> result)
        where TOk : TErr
        where TErr : notnull =>
        result.IsOk ? result.Ok : result.Err;

    /// <summary>
    /// Gets the value of the <see cref="Result{TOk, TErr}"/> by casting into <typeparamref name="TErr"/>.
    /// </summary>
    /// <remarks><para>
    /// The generic parameter <typeparamref name="TOk"/> must implement or inherit <typeparamref name="TErr"/>.
    /// </para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="result">The result parameter.</param>
    /// <returns>
    /// The value <see cref="Result{TOk, TErr}.Err"/>, or <see cref="Result{TOk, TErr}.Ok"/> as <typeparamref name="TErr"/>.
    /// </returns>
    [Pure]
    public static TErr ErrOrCast<TOk, TErr>(this Result<TOk, TErr> result)
        where TOk : TErr
        where TErr : notnull =>
        result.IsErr ? result.Err : result.Ok;

    /// <summary>
    /// Gets <see cref="Result{TOk, TErr}.Err"/>, or calls the default constructor for <typeparamref name="TErr"/>.
    /// </summary>
    /// <remarks><para>
    /// The generic parameter <typeparamref name="TErr"/> must have a public default constructor.
    /// </para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="result">The result parameter.</param>
    /// <returns>
    /// The value <see cref="Result{TOk, TErr}.Err"/>, or the default constructor for <typeparamref name="TErr"/>.
    /// </returns>
    [Pure]
    public static TErr ErrOrNew<TOk, TErr>(this Result<TOk, TErr> result)
        where TOk : notnull
        where TErr : notnull, new() =>
        result.IsErr ? result.Err : new();

    /// <summary>
    /// Gets the value of the <see cref="Result{TOk, TErr}"/> by casting into <typeparamref name="TOk"/>.
    /// </summary>
    /// <remarks><para>
    /// The generic parameter <typeparamref name="TErr"/> must implement or inherit <typeparamref name="TOk"/>.
    /// </para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="result">The result parameter.</param>
    /// <returns>
    /// The value <see cref="Result{TOk, TErr}.Ok"/>,
    /// or <see cref="Result{TOk, TErr}.Err"/> as <typeparamref name="TOk"/>.
    /// </returns>
    [Pure]
    public static TOk OkOrCast<TOk, TErr>(this Result<TOk, TErr> result)
        where TOk : notnull
        where TErr : TOk =>
        result.IsOk ? result.Ok : result.Err;

    /// <summary>
    /// Gets the value of the <see cref="Result{TOk, TErr}"/> by casting into <typeparamref name="TOk"/>.
    /// </summary>
    /// <remarks><para>
    /// The generic parameter <typeparamref name="TErr"/> must implement or inherit <typeparamref name="TOk"/>.
    /// </para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="result">The result parameter.</param>
    /// <returns>
    /// The value <see cref="Result{TOk, TErr}.Ok"/>,
    /// or <see cref="Result{TOk, TErr}.Err"/> as <typeparamref name="TOk"/>.
    /// </returns>
    [Pure]
    public static TOk OkOr<TOk, TErr>(this Result<TOk, TErr> result)
        where TOk : notnull
        where TErr : TOk =>
        result.IsOk ? result.Ok : result.Err;

    /// <summary>
    /// Gets <see cref="Result{TOk, TErr}.Ok"/>, or calls the default constructor for <typeparamref name="TOk"/>.
    /// </summary>
    /// <remarks><para>
    /// The generic parameter <typeparamref name="TOk"/> must have a public default constructor.
    /// </para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="result">The result parameter.</param>
    /// <returns>
    /// The value <see cref="Result{TOk, TErr}.Ok"/>, or the default constructor for <typeparamref name="TOk"/>.
    /// </returns>
    [Pure]
    public static TOk OkOrNew<TOk, TErr>(this Result<TOk, TErr> result)
        where TOk : notnull, new()
        where TErr : notnull =>
        result.IsOk ? result.Ok : new();

    /// <summary>
    /// Returns the value, but unlike <see cref="Result{TOk, TErr}.Value"/>,
    /// nothing is boxed since both types are the same.
    /// </summary>
    /// <remarks><para>Both the success and error types must be the same.</para></remarks>
    /// <typeparam name="T">The success and error type.</typeparam>
    /// <param name="result">The result parameter.</param>
    /// <returns>The value of <paramref name="result"/>.</returns>
    [Pure]
    public static T OkOrErr<T>(this Result<T, T> result)
        where T : notnull =>
        result.IsOk ? result.Ok : result.Err;
}
