#if !NET7_0_OR_GREATER
using System;

namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
public sealed class CompilerFeatureRequiredAttribute : Attribute {
    public string FeatureName { get; }

    public CompilerFeatureRequiredAttribute(string featureName) => FeatureName = featureName;
}
#endif