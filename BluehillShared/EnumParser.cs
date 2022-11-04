namespace BluehillShared;

#if NETCOREAPP2_0_OR_GREATER || NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
[Obsolete("System.Enum.Parse를 사용하세요.")]
#endif
public static class EnumParser {
#if NETCOREAPP2_0_OR_GREATER || NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
    [Obsolete("System.Enum.Parse를 사용하세요.")]
#endif
    public static TEnum Parse<TEnum>(string value) where TEnum : struct =>
#if NETFRAMEWORK || (NETCOREAPP && !NETCOREAPP2_0_OR_GREATER && !NETCOREAPP3_0_OR_GREATER) || (NETSTANDARD && !NETSTANDARD2_1_OR_GREATER)
        (TEnum)Enum.Parse(typeof(TEnum), value);
#else
        Enum.Parse<TEnum>(value);
#endif

#if NETCOREAPP2_0_OR_GREATER || NETCOREAPP3_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
    [Obsolete("System.Enum.Parse를 사용하세요.")]
#endif
    public static TEnum Parse<TEnum>(string value, bool ignoreCase) where TEnum : struct =>
#if NETFRAMEWORK || (NETCOREAPP && !NETCOREAPP2_0_OR_GREATER && !NETCOREAPP3_0_OR_GREATER) || (NETSTANDARD && !NETSTANDARD2_1_OR_GREATER)
        (TEnum)Enum.Parse(typeof(TEnum), value, ignoreCase);
#else
        Enum.Parse<TEnum>(value, ignoreCase);
#endif
}