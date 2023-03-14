// SPDX-License-Identifier: MPL-2.0

// ReSharper disable once CheckNamespace
namespace Emik.Results.Extensions;

/// <summary>Methods to determine the severity of an <see cref="Exception"/>.</summary>
public static class Fatalities
{
    /// <summary>Determines whether an <see cref="Exception"/> can be handled by <see cref="Please"/>.</summary>
    /// <remarks>
    /// <para>List of fatal exceptions:</para>
    /// <list type="bullet">
    /// <item><description><see cref="AbandonedMutexException"/></description></item>
    /// <item><description><see cref="AccessViolationException"/></description></item>
    /// <item><description><see cref="ArithmeticException"/></description></item>
    /// <item><description><see cref="ArgumentNullException"/></description></item>
    /// <item><description><see cref="ArgumentOutOfRangeException"/></description></item>
    /// <item><description><see cref="ArrayTypeMismatchException"/></description></item>
    /// <item><description><see cref="ExecutionEngineException"/></description></item>
    /// <item><description><see cref="ExternalException"/></description></item>
    /// <item><description><see cref="IFatal"/></description></item>
    /// <item><description><see cref="IndexOutOfRangeException"/></description></item>
    /// <item><description><c>InsufficientExecutionStackException</c> (.NET Framework 3.5 only)</description></item>
    /// <item><description><see cref="InvalidCastException"/></description></item>
    /// <item><description><see cref="KeyNotFoundException"/></description></item>
    /// <item><description><see cref="NotImplementedException"/></description></item>
    /// <item><description><see cref="NullReferenceException"/></description></item>
    /// <item><description><see cref="OutOfMemoryException"/></description></item>
    /// <item><description><see cref="OverflowException"/></description></item>
    /// <item><description><see cref="RankException"/></description></item>
    /// <item><description><see cref="StackOverflowException"/></description></item>
    /// <item><description><see cref="ThreadAbortException"/></description></item>
    /// <item><description><see cref="TypeInitializationException"/></description></item>
    /// <item><description><c>UnreachableException</c> (including polyfills)</description></item>
    /// </list>
    /// </remarks>
    /// <param name="ex">The exception to determine whether it can be handled.</param>
    /// <returns>
    /// The value <see langword="true"/> if the parameter <paramref name="ex"/> is of an <see cref="Exception"/>
    /// <see cref="Type"/> that is considered fatal, otherwise <see langword="false"/>.
    /// </returns>
    public static bool IsFatal([NotNullWhen(false)] this Exception? ex) =>
        ex is null or
            AbandonedMutexException or
            AccessViolationException or
            ArithmeticException or
            ArgumentNullException or
            ArgumentOutOfRangeException or
            ArrayTypeMismatchException or
#pragma warning disable CS0618
            ExecutionEngineException or
#pragma warning restore CS0618
            ExternalException or
            IFatal or
            IndexOutOfRangeException or
#if NET40_OR_GREATER || !NETFRAMEWORK
            InsufficientExecutionStackException or
#endif
            InvalidCastException or
            KeyNotFoundException or
            NotImplementedException or
            NullReferenceException or
            OutOfMemoryException or
            OverflowException or
            RankException or
            StackOverflowException or
            ThreadAbortException or
            TypeInitializationException ||
        ex.GetType().Name is nameof(UnreachableException);

    /// <summary>Negated version of <see cref="IsFatal"/>.</summary>
    /// <param name="ex">The exception to determine whether it can be handled.</param>
    /// <returns>
    /// The value <see langword="true"/> if the parameter <paramref name="ex"/> is of an <see cref="Exception"/>
    /// <see cref="Type"/> that is considered recoverable, otherwise <see langword="false"/>.
    /// </returns>
    /// <inheritdoc cref="IsFatal"/>
    public static bool IsBenign([NotNullWhen(true)] this Exception? ex) => !ex.IsFatal();
}
