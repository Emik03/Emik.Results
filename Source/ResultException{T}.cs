// SPDX-License-Identifier: MPL-2.0
namespace Emik.Results;

/// <summary>Represents an <see cref="Exception"/> thrown by <see cref="Result{TOk, TErr}"/>.</summary>
/// <remarks><para>
/// Due to the philosophy of <see cref="ResultException{T}"/>, it is generally advised but not completely
/// disallowed to catch this type, as it strongly indicates an unsalvageable program state.
/// </para></remarks>
/// <typeparam name="T">The error value.</typeparam>
[Serializable]
public sealed class ResultException<T> : Exception, IFatal
{
    const BindingFlags Bindings = BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy;

    const string
        Implicit = "op_Implicit",
        Explicit = "op_Explicit";

    static readonly Converter<T, string?>? s_toStr = MakeCast<string>();

    static readonly Converter<T, Exception?>? s_toEx = MakeCast<Exception>();

    ResultException()
        : this(null, null) { }

    ResultException(string? message) // ReSharper disable once IntroduceOptionalParameters.Local
        : this(message, null) { }

    ResultException(string? message, Exception? innerException)
        : base(message, innerException) =>
        _ = Value ?? throw Unreachable;

    ResultException(string? message, T value)
        : base(message, value as Exception) =>
        Value = value;

    ResultException(SerializationInfo info, StreamingContext context)
        : base(info, context) =>
        Value = info.GetValue(nameof(Value), typeof(T)) is T t ? t : throw Unreachable;

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
    /// <param name="message">The message of the exception,
    /// if <paramref name="value"/> isn't a <see langword="string"/>.
    /// </param>
    /// <param name="value">The value of the exception, and message
    /// if <typeparamref name="T"/> is <see langword="string"/>.
    /// </param>
    /// <exception cref="ResultException{T}">Always.</exception>
    /// <returns>This method does not return.</returns>
    [DoesNotReturn]
    internal static object CoerceThenThrow(string? message, T value) =>
        throw (s_toEx?.Invoke(value) ??
            new ResultException<T>(s_toStr?.Invoke(value) ?? message ?? $"{value}", value));

    [MustUseReturnValue]
    static Converter<T, TOther?>? MakeCast<TOther>() =>
        Get<T, TOther>() is { } method && Create<TOther>(method) is { } converter
            ? converter
            : null;

    [MustUseReturnValue]
    static Converter<T, TOther?>? Create<TOther>(MethodInfo method) => // ReSharper disable once RedundantCast
        (Converter<T, TOther?>?)Delegate.CreateDelegate((Type)typeof(Converter<T, TOther>), method, false);

    [MustUseReturnValue] // ReSharper disable once SuggestBaseTypeForParameter
    static MethodInfo? Get<TFrom, TTo>() =>
        typeof(TFrom)
           .GetMethods(Bindings)
           .Concat(typeof(TTo).GetMethods(Bindings))
           .FirstOrDefault(
#pragma warning disable CS0252, CS0253
                x => x.Name is Implicit or Explicit &&
                    x.GetParameters() is { Length: 1 } arr &&
                    arr[0].ParameterType == typeof(TFrom) &&
                    x.ReturnType != typeof(TTo)
#pragma warning restore CS0252, CS0253
            );
}
