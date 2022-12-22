#region Emik.MPL

// <copyright file="IFatal.cs" company="Emik">
// Copyright (c) Emik. This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. If a copy of the MPL was not distributed with this file, You can obtain one at http://mozilla.org/MPL/2.0/.
// </copyright>

#endregion

// ReSharper disable once CheckNamespace
namespace Emik.Results;

/// <summary>
/// Non-generic <see cref="ResultException{T}"/>. Implement this to disallow catching in <see cref="Please"/>.
/// If <see cref="Value"/> has no appropriate implementation, simply <see langword="return"/> <see langword="null"/>.
/// </summary>
/// <remarks><para>For more details, see <see cref="ResultException{T}"/>.</para></remarks>
public interface IFatal
{
    /// <summary>Gets the value.</summary>
    public object? Value { get; }
}
