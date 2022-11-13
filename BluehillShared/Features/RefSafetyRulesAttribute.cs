namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
public sealed class RefSafetyRulesAttribute : Attribute {
    public readonly int Version;

    public RefSafetyRulesAttribute(int A_1) => Version = A_1;
}