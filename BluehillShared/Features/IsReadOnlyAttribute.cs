#if (NETFRAMEWORK && !NET471_OR_GREATER) || (NETCOREAPP && !NETCOREAPP2_0_OR_GREATER && !NETCOREAPP3_0_OR_GREATER) || (NETSTANDARD && !NETSTANDARD2_1_OR_GREATER)
using System.ComponentModel;

namespace System.Runtime.CompilerServices;

[EditorBrowsable(EditorBrowsableState.Never)]
[AttributeUsage(AttributeTargets.All, Inherited = false)]
public sealed class IsReadOnlyAttribute : Attribute { }
#endif