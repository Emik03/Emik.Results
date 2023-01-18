// SPDX-License-Identifier: MPL-2.0
namespace Emik.Results;

/// <summary>Methods to create result types from singular values.</summary>
public static class Result
{
    /// <summary>Creates an <see cref="Result{TOk, TErr}.Err"/> value.</summary>
    /// <returns>A <see cref="Result{TOk, TErr}"/> marked with <see cref="Result{TOk, TErr}.Err"/>.</returns>
    [Pure]
    public static Result<object?, object?> Err() => new(err: null);

    /// <summary>Creates an <see cref="Result{TOk, TErr}.Ok"/> value.</summary>
    /// <returns>A <see cref="Result{TOk, TErr}"/> marked with <see cref="Result{TOk, TErr}.Ok"/>.</returns>
    [Pure]
    public static Result<object?, object?> Ok() => new(ok: null);

    /// <summary>Creates an <see cref="Result{TOk, TErr}.Err"/> value.</summary>
    /// <typeparam name="TOk">The type of <see cref="Result{TOk, TErr}.Ok"/>.</typeparam>
    /// <typeparam name="TErr">The type of <see cref="Result{TOk, TErr}.Err"/>.</typeparam>
    /// <returns>A <see cref="Result{TOk, TErr}"/> marked with <see cref="Result{TOk, TErr}.Err"/>.</returns>
    [Pure]
    public static Result<TOk, TErr?> Err<TOk, TErr>() => new(err: default);

    /// <summary>Creates an <see cref="Result{TOk, TErr}.Ok"/> value.</summary>
    /// <typeparam name="TOk">The type of <see cref="Result{TOk, TErr}.Ok"/>.</typeparam>
    /// <typeparam name="TErr">The type of <see cref="Result{TOk, TErr}.Err"/>.</typeparam>
    /// <returns>A <see cref="Result{TOk, TErr}"/> marked with <see cref="Result{TOk, TErr}.Ok"/>.</returns>
    [Pure]
    public static Result<TOk?, TErr> Ok<TOk, TErr>() => new(ok: default);

    /// <summary>Creates an <see cref="Result{TOk, TErr}.Err"/> value.</summary>
    /// <typeparam name="T">The type of <see cref="Result{TOk, TErr}.Err"/>.</typeparam>
    /// <param name="err">The value to pass into the <see cref="Result"/>.</param>
    /// <returns>A <see cref="Result{TOk, TErr}"/> with <paramref name="err"/> passed in.</returns>
    [Pure]
    public static Result<object?, T> Err<T>(T err) => err;

    /// <summary>Creates an <see cref="Result{TOk, TErr}.Ok"/> value.</summary>
    /// <typeparam name="T">The type of <see cref="Result{TOk, TErr}.Ok"/>.</typeparam>
    /// <param name="ok">The value to pass into the <see cref="Result"/>.</param>
    /// <returns>A <see cref="Result{TOk, TErr}"/> with <paramref name="ok"/> passed in.</returns>
    [Pure]
    public static Result<T, object?> Ok<T>(T ok) => ok;

    /// <summary>Creates an <see cref="Result{TOk, TErr}.Err"/> value.</summary>
    /// <typeparam name="TOk">The type of <see cref="Result{TOk, TErr}.Ok"/>.</typeparam>
    /// <typeparam name="TErr">The type of <see cref="Result{TOk, TErr}.Err"/>.</typeparam>
    /// <param name="err">The value to pass into the <see cref="Result"/>.</param>
    /// <returns>A <see cref="Result{TOk, TErr}"/> with <paramref name="err"/> passed in.</returns>
    [Pure]
    public static Result<TOk, TErr> Err<TOk, TErr>(TErr err) => err;

    /// <summary>Creates an <see cref="Result{TOk, TErr}.Ok"/> value.</summary>
    /// <typeparam name="TOk">The type of <see cref="Result{TOk, TErr}.Ok"/>.</typeparam>
    /// <typeparam name="TErr">The type of <see cref="Result{TOk, TErr}.Err"/>.</typeparam>
    /// <param name="ok">The value to pass into the <see cref="Result"/>.</param>
    /// <returns>A <see cref="Result{TOk, TErr}"/> with <paramref name="ok"/> passed in.</returns>
    [Pure]
    public static Result<TOk, TErr> Ok<TOk, TErr>(TOk ok) => ok;
}
