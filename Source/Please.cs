// <copyright file="Please.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>
namespace Emik.Results;

/// <summary>Methods to wrap try-catch into a <see cref="Result{TOk, TErr}"/>.</summary>
public static class Please
{
    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T">The type of the first parameter.</typeparam>
    /// <param name="predicate">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="predicate"/> with.</param>
    /// <returns>The result of <paramref name="predicate"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<bool, Exception> Try<T>([InstantHandle] Predicate<T> predicate, T first)
    {
        try
        {
            return predicate(first);
        }
        catch (Exception ex) when (ex.IsBenign())
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <param name="action">The <see cref="Delegate"/> to invoke.</param>
    /// <returns>The result of <paramref name="action"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<object?, Exception> Try([InstantHandle] Action action)
    {
        try
        {
            action();
            return Ok();
        }
        catch (Exception ex) when (ex.IsBenign())
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T">The type of the first parameter.</typeparam>
    /// <param name="action">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="action"/> with.</param>
    /// <returns>The result of <paramref name="action"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<object?, Exception> Try<T>([InstantHandle] Action<T> action, T first)
    {
        try
        {
            action(first);
            return Ok();
        }
        catch (Exception ex) when (ex.IsBenign())
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <param name="action">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="action"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="action"/> with.</param>
    /// <returns>The result of <paramref name="action"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<object?, Exception> Try<T1, T2>([InstantHandle] Action<T1, T2> action, T1 first, T2 second)
    {
        try
        {
            action(first, second);
            return Ok();
        }
        catch (Exception ex) when (ex.IsBenign())
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="T3">The type of the third parameter.</typeparam>
    /// <param name="action">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="action"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="action"/> with.</param>
    /// <param name="third">The third parameter to invoke <paramref name="action"/> with.</param>
    /// <returns>The result of <paramref name="action"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<object?, Exception> Try<T1, T2, T3>(
        [InstantHandle] Action<T1, T2, T3> action,
        T1 first,
        T2 second,
        T3 third
    )
    {
        try
        {
            action(first, second, third);
            return Ok();
        }
        catch (Exception ex) when (ex.IsBenign())
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="T3">The type of the third parameter.</typeparam>
    /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
    /// <param name="action">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="action"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="action"/> with.</param>
    /// <param name="third">The third parameter to invoke <paramref name="action"/> with.</param>
    /// <param name="fourth">The fourth parameter to invoke <paramref name="action"/> with.</param>
    /// <returns>The result of <paramref name="action"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<object?, Exception> Try<T1, T2, T3, T4>(
        [InstantHandle] Action<T1, T2, T3, T4> action,
        T1 first,
        T2 second,
        T3 third,
        T4 fourth
    )
    {
        try
        {
            action(first, second, third, fourth);
            return Ok();
        }
        catch (Exception ex) when (ex.IsBenign())
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="TResult">The type of the result of <paramref name="func"/>.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<TResult, Exception> Try<TResult>([InstantHandle] Func<TResult> func)
    {
        try
        {
            return func();
        }
        catch (Exception ex) when (ex.IsBenign())
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T">The type of the first parameter.</typeparam>
    /// <typeparam name="TResult">The type of the result of <paramref name="func"/>.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="func"/> with.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<TResult, Exception> Try<T, TResult>([InstantHandle] Func<T, TResult> func, T first)
    {
        try
        {
            return func(first);
        }
        catch (Exception ex) when (ex.IsBenign())
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="TResult">The type of the result of <paramref name="func"/>.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="func"/> with.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<TResult, Exception> Try<T1, T2, TResult>(
        [InstantHandle] Func<T1, T2, TResult> func,
        T1 first,
        T2 second
    )
    {
        try
        {
            return func(first, second);
        }
        catch (Exception ex) when (ex.IsBenign())
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="T3">The type of the third parameter.</typeparam>
    /// <typeparam name="TResult">The type of the result of <paramref name="func"/>.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="third">The third parameter to invoke <paramref name="func"/> with.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<TResult, Exception> Try<T1, T2, T3, TResult>(
        [InstantHandle] Func<T1, T2, T3, TResult> func,
        T1 first,
        T2 second,
        T3 third
    )
    {
        try
        {
            return func(first, second, third);
        }
        catch (Exception ex) when (ex.IsBenign())
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="T3">The type of the third parameter.</typeparam>
    /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
    /// <typeparam name="TResult">The type of the result of <paramref name="func"/>.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="third">The third parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="fourth">The fourth parameter to invoke <paramref name="func"/> with.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<TResult, Exception> Try<T1, T2, T3, T4, TResult>(
        [InstantHandle] Func<T1, T2, T3, T4, TResult> func,
        T1 first,
        T2 second,
        T3 third,
        T4 fourth
    )
    {
        try
        {
            return func(first, second, third, fourth);
        }
        catch (Exception ex) when (ex.IsBenign())
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T">The type of the first parameter.</typeparam>
    /// <typeparam name="TResult">The type of the result of <paramref name="converter"/>.</typeparam>
    /// <param name="converter">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="converter"/> with.</param>
    /// <returns>The result of <paramref name="converter"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<TResult, Exception> TryMap<T, TResult>(
        [InstantHandle] Converter<T, TResult> converter,
        T first
    )
    {
        try
        {
            return converter(first);
        }
        catch (Exception ex) when (ex.IsBenign())
        {
            return ex;
        }
    }
}
