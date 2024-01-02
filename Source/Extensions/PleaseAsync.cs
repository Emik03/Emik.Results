// SPDX-License-Identifier: MPL-2.0
#if !NETFRAMEWORK
#pragma warning disable ASYNC0001, S5034, VSTHRD002, VSTHRD003, VSTHRD200
namespace Emik.Results.Extensions;

/// <summary>Methods to wrap try-catch into a <see cref="Result{TOk, TErr}"/>.</summary>
public static class PleaseAsync
{
    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async Task<Result<object, Exception>> Try([InstantHandle] Func<Task> func)
    {
        try
        {
            await func();
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T">The type of the first parameter.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="func"/> with.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async Task<Result<object, Exception>> Try<T>(
        [InstantHandle, RequireStaticDelegate] Func<T, Task> func,
        T first
    )
    {
        try
        {
            await func(first);
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="func"/> with.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async Task<Result<object, Exception>> Try<T1, T2>(
        [InstantHandle, RequireStaticDelegate] Func<T1, T2, Task> func,
        T1 first,
        T2 second
    )
    {
        try
        {
            await func(first, second);
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="T3">The type of the third parameter.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="third">The third parameter to invoke <paramref name="func"/> with.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async Task<Result<object, Exception>> Try<T1, T2, T3>(
        [InstantHandle, RequireStaticDelegate] Func<T1, T2, T3, Task> func,
        T1 first,
        T2 second,
        T3 third
    )
    {
        try
        {
            await func(first, second, third);
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="T3">The type of the third parameter.</typeparam>
    /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="third">The third parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="fourth">The fourth parameter to invoke <paramref name="func"/> with.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async Task<Result<object, Exception>> Try<T1, T2, T3, T4>(
        [InstantHandle, RequireStaticDelegate] Func<T1, T2, T3, T4, Task> func,
        T1 first,
        T2 second,
        T3 third,
        T4 fourth
    )
    {
        try
        {
            await func(first, second, third, fourth);
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="TResult">The type of the result of <paramref name="func"/>.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async Task<Result<TResult, Exception>> Try<TResult>(
        [InstantHandle] Func<Task<TResult>> func
    )
        where TResult : notnull
    {
        try
        {
            return await func();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
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
    [Pure]
    public static async Task<Result<TResult, Exception>> Try<T, TResult>(
        [InstantHandle, RequireStaticDelegate] Func<T, Task<TResult>> func,
        T first
    )
        where TResult : notnull
    {
        try
        {
            return await func(first);
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
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
    [Pure]
    public static async Task<Result<TResult, Exception>> Try<T1, T2, TResult>(
        [InstantHandle, RequireStaticDelegate] Func<T1, T2, Task<TResult>> func,
        T1 first,
        T2 second
    )
        where TResult : notnull
    {
        try
        {
            return await func(first, second);
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
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
    [Pure]
    public static async Task<Result<TResult, Exception>> Try<T1, T2, T3, TResult>(
        [InstantHandle, RequireStaticDelegate] Func<T1, T2, T3, Task<TResult>> func,
        T1 first,
        T2 second,
        T3 third
    )
        where TResult : notnull
    {
        try
        {
            return await func(first, second, third);
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
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
    [Pure]
    public static async Task<Result<TResult, Exception>> Try<T1, T2, T3, T4, TResult>(
        [InstantHandle, RequireStaticDelegate] Func<T1, T2, T3, T4, Task<TResult>> func,
        T1 first,
        T2 second,
        T3 third,
        T4 fourth
    )
        where TResult : notnull
    {
        try
        {
            return await func(first, second, third, fourth);
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="Task"/> within a try-catch.</summary>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async Task<Result<object, Exception>> Try([InstantHandle] this Task task)
    {
        try
        {
            await task;
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="Task{T}"/> within a try-catch.</summary>
    /// <typeparam name="T">The returned value of the <see cref="Task{T}"/>.</typeparam>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async Task<Result<T, Exception>> Try<T>([InstantHandle] this Task<T> task)
        where T : notnull
    {
        try
        {
            return await task;
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP
    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async ValueTask<Result<object, Exception>> Try([InstantHandle] Func<ValueTask> func)
    {
        try
        {
            await func();
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T">The type of the first parameter.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="func"/> with.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async ValueTask<Result<object, Exception>> Try<T>(
        [InstantHandle, RequireStaticDelegate] Func<T, ValueTask> func,
        T first
    )
    {
        try
        {
            await func(first);
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="func"/> with.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async ValueTask<Result<object, Exception>> Try<T1, T2>(
        [InstantHandle, RequireStaticDelegate] Func<T1, T2, ValueTask> func,
        T1 first,
        T2 second
    )
    {
        try
        {
            await func(first, second);
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="T3">The type of the third parameter.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="third">The third parameter to invoke <paramref name="func"/> with.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async ValueTask<Result<object, Exception>> Try<T1, T2, T3>(
        [InstantHandle, RequireStaticDelegate] Func<T1, T2, T3, ValueTask> func,
        T1 first,
        T2 second,
        T3 third
    )
    {
        try
        {
            await func(first, second, third);
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="T3">The type of the third parameter.</typeparam>
    /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <param name="first">The first parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="second">The second parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="third">The third parameter to invoke <paramref name="func"/> with.</param>
    /// <param name="fourth">The fourth parameter to invoke <paramref name="func"/> with.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async ValueTask<Result<object, Exception>> Try<T1, T2, T3, T4>(
        [InstantHandle, RequireStaticDelegate] Func<T1, T2, T3, T4, ValueTask> func,
        T1 first,
        T2 second,
        T3 third,
        T4 fourth
    )
    {
        try
        {
            await func(first, second, third, fourth);
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Attempts to invoke a <see cref="Delegate"/>.</summary>
    /// <typeparam name="TResult">The type of the result of <paramref name="func"/>.</typeparam>
    /// <param name="func">The <see cref="Delegate"/> to invoke.</param>
    /// <returns>The result of <paramref name="func"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async ValueTask<Result<TResult, Exception>> Try<TResult>(
        [InstantHandle] Func<ValueTask<TResult>> func
    )
        where TResult : notnull
    {
        try
        {
            return await func();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
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
    [Pure]
    public static async ValueTask<Result<TResult, Exception>> Try<T, TResult>(
        [InstantHandle, RequireStaticDelegate] Func<T, ValueTask<TResult>> func,
        T first
    )
        where TResult : notnull
    {
        try
        {
            return await func(first);
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
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
    [Pure]
    public static async ValueTask<Result<TResult, Exception>> Try<T1, T2, TResult>(
        [InstantHandle, RequireStaticDelegate] Func<T1, T2, ValueTask<TResult>> func,
        T1 first,
        T2 second
    )
        where TResult : notnull
    {
        try
        {
            return await func(first, second);
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
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
    [Pure]
    public static async ValueTask<Result<TResult, Exception>> Try<T1, T2, T3, TResult>(
        [InstantHandle, RequireStaticDelegate] Func<T1, T2, T3, ValueTask<TResult>> func,
        T1 first,
        T2 second,
        T3 third
    )
        where TResult : notnull
    {
        try
        {
            return await func(first, second, third);
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
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
    [Pure]
    public static async ValueTask<Result<TResult, Exception>> Try<T1, T2, T3, T4, TResult>(
        [InstantHandle, RequireStaticDelegate] Func<T1, T2, T3, T4, ValueTask<TResult>> func,
        T1 first,
        T2 second,
        T3 third,
        T4 fourth
    )
        where TResult : notnull
    {
        try
        {
            return await func(first, second, third, fourth);
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="Task"/> within a try-catch.</summary>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async ValueTask<Result<object, Exception>> Try([InstantHandle] this ValueTask task)
    {
        try
        {
            await task;
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="Task{T}"/> within a try-catch.</summary>
    /// <typeparam name="T">The returned value of the <see cref="Task{T}"/>.</typeparam>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [Pure]
    public static async ValueTask<Result<T, Exception>> Try<T>([InstantHandle] this ValueTask<T> task)
        where T : notnull
    {
        try
        {
            return await task;
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="Task"/> within a try-catch.</summary>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<TaskAwaiter, Exception> TryAwaiter(this Task task)
    {
        try
        {
            return task.GetAwaiter();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="Task{T}"/> within a try-catch.</summary>
    /// <typeparam name="T">The returned value of the <see cref="Task{T}"/>.</typeparam>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<TaskAwaiter<T>, Exception> TryAwaiter<T>(this Task<T> task)
    {
        try
        {
            return task.GetAwaiter();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="Task"/> within a try-catch.</summary>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<ValueTaskAwaiter, Exception> TryAwaiter(this ValueTask task)
    {
        try
        {
            return task.GetAwaiter();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="Task{T}"/> within a try-catch.</summary>
    /// <typeparam name="T">The returned value of the <see cref="Task{T}"/>.</typeparam>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<ValueTaskAwaiter<T>, Exception> TryAwaiter<T>(this ValueTask<T> task)
    {
        try
        {
            return task.GetAwaiter();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="Task"/> within a try-catch.</summary>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<object, Exception> TryResult(this Task task)
    {
        try
        {
            task.GetAwaiter().GetResult();
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="Task{T}"/> within a try-catch.</summary>
    /// <typeparam name="T">The returned value of the <see cref="Task{T}"/>.</typeparam>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<T, Exception> TryResult<T>(this Task<T> task)
        where T : notnull
    {
        try
        {
            return task.GetAwaiter().GetResult();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="TaskAwaiter"/> within a try-catch.</summary>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<object, Exception> TryResult(this TaskAwaiter task)
    {
        try
        {
            task.GetResult();
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="TaskAwaiter{T}"/> within a try-catch.</summary>
    /// <typeparam name="T">The returned value of the <see cref="TaskAwaiter{T}"/>.</typeparam>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<T, Exception> TryResult<T>(this TaskAwaiter<T> task)
        where T : notnull
    {
        try
        {
            return task.GetResult();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="Task"/> within a try-catch.</summary>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<object, Exception> TryResult(this ValueTask task)
    {
        try
        {
            task.GetAwaiter().GetResult();
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="Task{T}"/> within a try-catch.</summary>
    /// <typeparam name="T">The returned value of the <see cref="Task{T}"/>.</typeparam>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<T, Exception> TryResult<T>(this ValueTask<T> task)
        where T : notnull
    {
        try
        {
            return task.GetAwaiter().GetResult();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="TaskAwaiter"/> within a try-catch.</summary>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<object, Exception> TryResult(this ValueTaskAwaiter task)
    {
        try
        {
            task.GetResult();
            return Ok<Exception>();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }

    /// <summary>Wraps a <see cref="TaskAwaiter{T}"/> within a try-catch.</summary>
    /// <typeparam name="T">The returned value of the <see cref="TaskAwaiter{T}"/>.</typeparam>
    /// <param name="task">The <see cref="Task"/> to invoke.</param>
    /// <returns>The result of <paramref name="task"/>, or the <see cref="Exception"/> thrown.</returns>
    [MustUseReturnValue]
    public static Result<T, Exception> TryResult<T>(this ValueTaskAwaiter<T> task)
        where T : notnull
    {
        try
        {
            return task.GetResult();
        }
        catch (Exception ex) when (ex.IsBenign() || Please.CatchFatalExceptions)
        {
            return ex;
        }
    }
#endif
}
#endif
