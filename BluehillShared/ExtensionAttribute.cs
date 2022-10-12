#if NETFRAMEWORK && !NET35_OR_GREATER
using System;

namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Assembly)]
public sealed class ExtensionAttribute : Attribute { }
#endif