#nullable disable
namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
public sealed class NullableAttribute : Attribute {
#pragma warning disable S3887 // Mutable, non-private fields should not be "readonly"
    public readonly byte[] NullableFlags;
#pragma warning restore S3887 // Mutable, non-private fields should not be "readonly"

    public NullableAttribute(byte A_1) => NullableFlags = new byte[] { A_1 };
    public NullableAttribute(byte[] A_1) => NullableFlags = A_1;
}