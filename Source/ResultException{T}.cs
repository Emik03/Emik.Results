// SPDX-License-Identifier: MPL-2.0
namespace Emik.Results;

/// <summary>Represents an <see cref="Exception"/> thrown by <see cref="Result{TOk, TErr}"/>.</summary>
/// <remarks><para>
/// Due to the philosophy of <see cref="ResultException{T}"/>, it is generally advised but not completely
/// disallowed to catch this type, as it strongly indicates an unsalvageable program state.
/// </para></remarks>
/// <typeparam name="T">The error value.</typeparam>
#if NETSTANDARD2_0_OR_GREATER || !NETSTANDARD
[Serializable]
#endif
public sealed class ResultException<T> : Exception, IFatal
{
#if NETSTANDARD2_0_OR_GREATER || !NETSTANDARD
    const BindingFlags Bindings = BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy;

    const string
        Implicit = "op_Implicit",
        Explicit = "op_Explicit";

    static readonly Converter<T, string?>? s_toStr = MakeCast<string>();

    static readonly Converter<T, Exception?>? s_toEx = MakeCast<Exception>();
#endif // ReSharper disable once UnusedMember.Local
    ResultException()
        : this(null) { }

    ResultException(string? message) // ReSharper disable once IntroduceOptionalParameters.Local
        : this(message, null) { }

    ResultException(string? message, Exception? innerException)
        : base(message, innerException) => // ReSharper disable once NullableWarningSuppressionIsUsed
        Value = default!;

    ResultException(string? message, T value)
        : base(message, value as Exception) =>
        Value = value;
#if NETSTANDARD2_0_OR_GREATER || !NETSTANDARD
    ResultException(SerializationInfo info, StreamingContext context)
        : base(info, context) => // ReSharper disable once NullableWarningSuppressionIsUsed
        Value = info.GetValue(nameof(Value), typeof(T)) is T t ? t : default!;
#endif

    /// <summary>Gets the value.</summary>
    [Pure]
    public T Value { get; }

    /// <inheritdoc />
    object? IFatal.Value => Value;

    /// <summary>Throws a <see cref="ResultException{T}"/>.</summary>
    /// <param name="message">The message of the exception.</param>
    /// <param name="value">The value of the exception.</param>
    /// <exception cref="ResultException{T}">Always.</exception>
    /// <returns>This method does not return.</returns>
    [DoesNotReturn]
    internal static object Throw(string? message, T value) => throw new ResultException<T>(message, value);

    /// <summary>
    /// Throws a <see cref="ResultException{T}"/>, but the <paramref name="message"/>
    /// may be replaced with <paramref name="value"/> from type coercion.
    /// </summary>
    /// <param name="message">
    /// The message of the exception, if <paramref name="value"/> isn't a <see langword="string"/>.
    /// </param>
    /// <param name="value">
    /// The value of the exception, and message if <typeparamref name="T"/> is <see langword="string"/>.
    /// </param>
    /// <exception cref="ResultException{T}">Always.</exception>
    /// <returns>This method does not return.</returns>
    [DoesNotReturn]
    internal static object CoerceThenThrow(string? message, T value) =>
#if !NETSTANDARD2_0_OR_GREATER && NETSTANDARD
        throw (value as Exception ?? new ResultException<T>(value as string ?? message ?? $"{value}", value));
#else
        throw (s_toEx?.Invoke(value) ?? new ResultException<T>(s_toStr?.Invoke(value) ?? message ?? $"{value}", value));
#endif

    /// <summary>Throws a <see cref="ResultException{T}"/>, format depending on <paramref name="message"/>.</summary>
    /// <param name="message">
    /// The message of the exception, if <paramref name="value"/> isn't a <see langword="string"/>.
    /// </param>
    /// <param name="value">
    /// The value of the exception, and message if <typeparamref name="T"/> is <see langword="string"/>.
    /// </param>
    /// <param name="defaultMessage">The message to use when <paramref name="message"/> is left unspecified.</param>
    /// <returns>This method does not return.</returns>
    [DoesNotReturn]
    internal static object SmartThrow(string? message, T value, string defaultMessage) =>
        message is null ? CoerceThenThrow(defaultMessage, value) : Throw(message, value);
#if NETSTANDARD2_0_OR_GREATER || !NETSTANDARD
    [MustUseReturnValue]
    static Converter<T, TOther?>? MakeCast<TOther>() =>
        Get<T, TOther>() is { } method && Create<TOther>(method) is { } converter ? converter : null;

    [MustUseReturnValue]
    static Converter<T, TOther?>? Create<TOther>(MethodInfo method) => // ReSharper disable once RedundantCast
        (Converter<T, TOther?>?)Delegate.CreateDelegate((Type)typeof(Converter<T, TOther>), method, false);

    [MustUseReturnValue] // ReSharper disable once SuggestBaseTypeForParameter
    static MethodInfo? Get<TFrom, TTo>() =>
        Array.Find(typeof(TFrom).GetMethods(Bindings), HasCast<TFrom, TTo>) ??
        Array.Find(typeof(TTo).GetMethods(Bindings), HasCast<TFrom, TTo>);

    static bool HasCast<TFrom, TTo>(MethodInfo x) =>
        x.Name is Implicit or Explicit &&
        x.ReturnType != typeof(TTo) &&
        x.GetParameters() is { Length: 1 } arr &&
        arr[0].ParameterType == typeof(TFrom);
#endif
}
