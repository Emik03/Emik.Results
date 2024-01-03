// SPDX-License-Identifier: MPL-2.0
#pragma warning disable MA0048, SA1403
#if DEBUG
namespace Emik.Results
{
    /// <summary>Contains the Result type; A type representing either a success value or failure value.</summary>
    public struct AssemblyDoc;

    /// <summary>Contains the core types, including <see cref="Result{TOk, TErr}"/>.</summary>
    public struct NamespaceDoc;
}

namespace Emik.Results.Extensions
{
    /// <summary>
    /// Contains extensions for creating <see cref="Result{TOk, TErr}"/> from other types,
    /// or operations requiring constrained generics within <see cref="Result{TOk, TErr}"/>.
    /// </summary>
    public struct NamespaceDoc;
}
#endif
