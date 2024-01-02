// SPDX-License-Identifier: MPL-2.0
namespace Emik.Results;
#pragma warning disable RCS1236
/// <summary>Methods to wrap try-catch into a <see cref="Result{TOk, TErr}"/>.</summary>
public static class Please
{
#if NETSTANDARD2_0_OR_GREATER || !NETSTANDARD
    static readonly
#if NET20
        Dictionary<Assembly, bool>
#else
        HashSet<Assembly?>
#endif
        s_scared = [];
#else
    const string No = $"{nameof(Please)}.{nameof(CatchFatalExceptions)} is not supported on .NET Standard 1.0 - 1.6.";
#endif

    /// <summary>
    /// Gets or sets a value indicating whether exception filters should be
    /// according to <see cref="Fatalities.IsFatal"/>, or have no filter at all.
    /// </summary>
    /// <remarks><para>
    /// This value is unique per assembly to allow for configuration, without altering the behavior of other assemblies.
    /// </para><para>
    /// It is encouraged to use a module initializer or static constructor to set this value.
    /// </para></remarks>
    /// <exception cref="NotSupportedException">The setter is used in .NET Standard 1.0 - 1.6.</exception>
    public static bool CatchFatalExceptions
    {
#if NET20
        [Pure] get => Caller is { } caller && s_scared.TryGetValue(caller, out _);
        set => _ = Caller is { } caller && (value ? s_scared[caller] = false : s_scared.Remove(caller));
#elif !NETSTANDARD2_0_OR_GREATER && NETSTANDARD
        [Pure] get => false;
        [DoesNotReturn, Obsolete(No, true)] set => throw new NotSupportedException(No);
#else
        [Pure] get => s_scared.Contains(Caller);
        set => _ = value ? s_scared.Add(Caller) : s_scared.Remove(Caller);
#endif
    }
#if NETSTANDARD2_0_OR_GREATER || !NETSTANDARD
    static Assembly? Caller
    {
        [Pure]
        get
        {
            for (var i = 2;; i++) // ReSharper disable once PossibleUnintendedReferenceComparison
                if (new StackFrame(i).GetMethod()?.DeclaringType?.Assembly is var assembly &&
                    assembly != typeof(Please).Assembly)
                    return assembly;
        }
    }
#endif

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
#if NET40_OR_GREATER || !NETFRAMEWORK
        catch (Exception ex) when (ex.IsBenign() || CatchFatalExceptions)
        {
#else
        catch (Exception ex)
        {
            if (ex.IsFatal() && !CatchFatalExceptions)
                throw;
#endif
            return ex;
        }
    }
#if !NET20 && !NET30
    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <param name="action">The <see cref="Delegate"/> to invoke.</param>
    /// <returns>The result of <paramref name="action"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<object, Exception> Try([InstantHandle] Action action)
    {
        try
        {
            action();
            return Ok<Exception>();
        }
#if NET40_OR_GREATER || !NETFRAMEWORK
        catch (Exception ex) when (ex.IsBenign() || CatchFatalExceptions)
        {
#else
        catch (Exception ex)
        {
            if (ex.IsFatal() && !CatchFatalExceptions)
                throw;
#endif
            return ex;
        }
    }
#endif

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T">The type of the first parameter.</typeparam>
    /// <param name="action">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="action"/> with.</param>
    /// <returns>The result of <paramref name="action"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<object, Exception> Try<T>([InstantHandle] Action<T> action, T first)
    {
        try
        {
            action(first);
            return Ok<Exception>();
        }
#if NET40_OR_GREATER || !NETFRAMEWORK
        catch (Exception ex) when (ex.IsBenign() || CatchFatalExceptions)
        {
#else
        catch (Exception ex)
        {
            if (ex.IsFatal() && !CatchFatalExceptions)
                throw;
#endif
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
        where TResult : notnull
    {
        try
        {
            return converter(first);
        }
#if NET40_OR_GREATER || !NETFRAMEWORK
        catch (Exception ex) when (ex.IsBenign() || CatchFatalExceptions)
        {
#else
        catch (Exception ex)
        {
            if (ex.IsFatal() && !CatchFatalExceptions)
                throw;
#endif
            return ex;
        }
    }
#if !NET20 && !NET30
    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <param name="action">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="action"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="action"/> with.</param>
    /// <returns>The result of <paramref name="action"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<object, Exception> Try<T1, T2>([InstantHandle] Action<T1, T2> action, T1 first, T2 second)
    {
        try
        {
            action(first, second);
            return Ok<Exception>();
        }
#if NET40_OR_GREATER || !NETFRAMEWORK
        catch (Exception ex) when (ex.IsBenign() || CatchFatalExceptions)
        {
#else
        catch (Exception ex)
        {
            if (ex.IsFatal() && !CatchFatalExceptions)
                throw;
#endif
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
    public static Result<object, Exception> Try<T1, T2, T3>(
        [InstantHandle] Action<T1, T2, T3> action,
        T1 first,
        T2 second,
        T3 third
    )
    {
        try
        {
            action(first, second, third);
            return Ok<Exception>();
        }
#if NET40_OR_GREATER || !NETFRAMEWORK
        catch (Exception ex) when (ex.IsBenign() || CatchFatalExceptions)
        {
#else
        catch (Exception ex)
        {
            if (ex.IsFatal() && !CatchFatalExceptions)
                throw;
#endif
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
    public static Result<object, Exception> Try<T1, T2, T3, T4>(
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
            return Ok<Exception>();
        }
#if NET40_OR_GREATER || !NETFRAMEWORK
        catch (Exception ex) when (ex.IsBenign() || CatchFatalExceptions)
        {
#else
        catch (Exception ex)
        {
            if (ex.IsFatal() && !CatchFatalExceptions)
                throw;
#endif
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="TResult">The type of the result of <paramref name="func"/>.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<TResult, Exception> Try<TResult>([InstantHandle] Func<TResult> func)
        where TResult : notnull
    {
        try
        {
            return func();
        }
#if NET40_OR_GREATER || !NETFRAMEWORK
        catch (Exception ex) when (ex.IsBenign() || CatchFatalExceptions)
        {
#else
        catch (Exception ex)
        {
            if (ex.IsFatal() && !CatchFatalExceptions)
                throw;
#endif
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
        where TResult : notnull
    {
        try
        {
            return func(first);
        }
#if NET40_OR_GREATER || !NETFRAMEWORK
        catch (Exception ex) when (ex.IsBenign() || CatchFatalExceptions)
        {
#else
        catch (Exception ex)
        {
            if (ex.IsFatal() && !CatchFatalExceptions)
                throw;
#endif
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
        where TResult : notnull
    {
        try
        {
            return func(first, second);
        }
#if NET40_OR_GREATER || !NETFRAMEWORK
        catch (Exception ex) when (ex.IsBenign() || CatchFatalExceptions)
        {
#else
        catch (Exception ex)
        {
            if (ex.IsFatal() && !CatchFatalExceptions)
                throw;
#endif
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
        where TResult : notnull
    {
        try
        {
            return func(first, second, third);
        }
#if NET40_OR_GREATER || !NETFRAMEWORK
        catch (Exception ex) when (ex.IsBenign() || CatchFatalExceptions)
        {
#else
        catch (Exception ex)
        {
            if (ex.IsFatal() && !CatchFatalExceptions)
                throw;
#endif
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
        where TResult : notnull
    {
        try
        {
            return func(first, second, third, fourth);
        }
#if NET40_OR_GREATER || !NETFRAMEWORK
        catch (Exception ex) when (ex.IsBenign() || CatchFatalExceptions)
        {
#else
        catch (Exception ex)
        {
            if (ex.IsFatal() && !CatchFatalExceptions)
                throw;
#endif
            return ex;
        }
    }
#endif
}
