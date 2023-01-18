// SPDX-License-Identifier: MPL-2.0
namespace Emik.Results.Extensions;

/// <summary>Additional methods for <see cref="ResultException{T}"/> that are type- or generic-sensitive.</summary>
public static class ResultFactory
{
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
    public static Result<TOk, TErr> Then<TOk, TErr>(this bool value, TOk ifTrue, TErr ifFalse) =>
        value ? ifTrue : ifFalse;

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
    ) =>
        value ? onTrue() : onFalse();

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
    public static Result<IEnumerable<TOk>, TErr> Flatten<TOk, TErr>(
        [InstantHandle] this IEnumerable<Result<TOk, TErr>> enumerable
    )
    {
        return enumerable is ICollection<Result<TOk, TErr>> collection
            ? Collection(collection)
            : Enumerable(enumerable);

        [Pure]
        static Result<IEnumerable<TOk>, TErr> Collection([InstantHandle] ICollection<Result<TOk, TErr>> collection)
        {
            List<TOk> output = new(collection.Count);
            var i = 0;

            foreach (var item in collection)
            {
                if (item.IsErr)
                    return item.Err;

                output[checked(i++)] = item.Ok;
            }

            return output;
        }

        [Pure]
        static Result<IEnumerable<TOk>, TErr> Enumerable([InstantHandle] IEnumerable<Result<TOk, TErr>> enumerable)
        {
            List<TOk> output = new();

            foreach (var item in enumerable)
            {
                if (item.IsErr)
                    return item.Err;

                output.Add(item.Ok);
            }

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
    public static Result<TOk, IEnumerable<TErr>> FlattenErr<TOk, TErr>(
        [InstantHandle] this IEnumerable<Result<TOk, TErr>> enumerable
    )
    {
        return enumerable is ICollection<Result<TOk, TErr>> collection
            ? Collection(collection)
            : Enumerable(enumerable);

        [Pure]
        static Result<TOk, IEnumerable<TErr>> Collection([InstantHandle] ICollection<Result<TOk, TErr>> collection)
        {
            List<TErr> output = new(collection.Count);
            var i = 0;

            foreach (var item in collection)
            {
                if (item.IsOk)
                    return item.Ok;

                output[checked(i++)] = item.Err;
            }

            return output;
        }

        [Pure]
        static Result<TOk, IEnumerable<TErr>> Enumerable([InstantHandle] IEnumerable<Result<TOk, TErr>> enumerable)
        {
            List<TErr> output = new();

            foreach (var item in enumerable)
            {
                if (item.IsOk)
                    return item.Ok;

                output.Add(item.Err);
            }

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
    public static Result<TOk, TErr> Flatten<TOk, TErr>(this Result<Result<TOk, TErr>, TErr> result) =>
        result.IsOk ? result.Ok : result.Err;

    /// <summary>Maps the nested results into one result.</summary>
    /// <remarks><para>The parameter must be a nested <see cref="Result{TOk, TErr}"/>.</para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="result">The result parameter.</param>
    /// <returns>The nested results collapsing into one result.</returns>
    [Pure]
    public static Result<TOk, TErr> Flatten<TOk, TErr>(this Result<TOk, Result<TOk, TErr>> result) =>
        result.IsOk ? result.Ok : result.Err;

    /// <summary>Maps the nested results into one result.</summary>
    /// <remarks><para>The parameter must be a nested <see cref="Result{TOk, TErr}"/>.</para></remarks>
    /// <typeparam name="TOk">The success type.</typeparam>
    /// <typeparam name="TErr">The error type.</typeparam>
    /// <param name="result">The result parameter.</param>
    /// <returns>The nested results collapsing into one result.</returns>
    [Pure]
    public static Result<TOk, TErr> Flatten<TOk, TErr>(this Result<Result<TOk, TErr>, Result<TOk, TErr>> result) =>
        result.IsOk ? result.Ok : result.Err;

    /// <summary>Maps <typeparamref name="T"/> into a <see cref="Result{TOk, TErr}"/>.</summary>
    /// <typeparam name="T">The error type.</typeparam>
    /// <param name="err">The value to pass in.</param>
    /// <returns>
    /// A <see cref="Result{TOk, TErr}"/> where <paramref name="err"/> is used if it isn't <see langword="null"/>,
    /// or else <see langword="null"/>.
    /// </returns>
    [Pure]
    public static Result<object?, T> IntoErr<T>(this T? err)
        where T : class =>
        err is null ? default(object?) : err;

    /// <summary>Maps <typeparamref name="T"/> into a <see cref="Result{TOk, TErr}"/>.</summary>
    /// <typeparam name="T">The error type.</typeparam>
    /// <param name="err">The value to pass in.</param>
    /// <returns>
    /// A <see cref="Result{TOk, TErr}"/> where <paramref name="err"/> is used if it isn't <see langword="null"/>,
    /// or else <see langword="null"/>.
    /// </returns>
    [Pure]
    public static Result<object?, T> IntoErr<T>(this T? err)
        where T : struct =>
        err is null ? default(object?) : err.Value;

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
    public static Result<T, object?> IntoOk<T>(this T? ok)
        where T : struct =>
        ok is null ? default(object?) : ok.Value;

    /// <summary>Maps <typeparamref name="T"/> into a <see cref="Result{TOk, TErr}"/>.</summary>
    /// <typeparam name="T">The success type.</typeparam>
    /// <param name="ok">The value to pass in.</param>
    /// <returns>
    /// A <see cref="Result{TOk, TErr}"/> where <paramref name="ok"/> is used if it isn't <see langword="null"/>,
    /// or else <see langword="null"/>.
    /// </returns>
    [Pure]
    public static Result<T, object?> IntoOk<T>(this T? ok)
        where T : class =>
        ok is null ? default(object?) : ok;

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
        where TOk : struct =>
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
        where TOk : class =>
        ok is null ? err : ok;

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
        where TOk : TErr =>
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
        where TErr : new() =>
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
#pragma warning disable CA1711
    public static TOk OkOrNew<TOk, TErr>(this Result<TOk, TErr> result)
#pragma warning restore CA1711
        where TOk : new() =>
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
    public static T OkOrErr<T>(this Result<T, T> result) => result.IsOk ? result.Ok : result.Err;
}
