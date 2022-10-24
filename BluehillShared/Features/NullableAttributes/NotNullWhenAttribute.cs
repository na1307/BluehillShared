#if NETFRAMEWORK || (NETCOREAPP && !NETCOREAPP3_0_OR_GREATER) || (NETSTANDARD && !NETSTANDARD2_1_OR_GREATER)
namespace System.Diagnostics.CodeAnalysis;

[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
public sealed class NotNullWhenAttribute : Attribute {
    public NotNullWhenAttribute(bool returnValue) => ReturnValue = returnValue;

    public bool ReturnValue { get; }
}
#endif