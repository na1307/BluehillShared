#nullable enable
namespace BluehillShared;

/// <summary>
/// 확장 메서드 모음
/// </summary>
public static class Extensions {
    /// <summary>
    /// <paramref name="source"/> 문자열에서 왼쪽으로 <paramref name="length"/>만큼의 문자열을 반환
    /// </summary>
    /// <param name="source">원본 문자열</param>
    /// <param name="length">자를 길이</param>
    /// <returns><paramref name="source"/>에서 <paramref name="length"/>만큼 자른 문자열</returns>
    public static string Left(this string source, int length) => source.Substring(0, length);

    /// <summary>
    /// <paramref name="source"/> 문자열에서 오른쪽으로 <paramref name="length"/>만큼의 문자열을 반환
    /// </summary>
    /// <param name="source">원본 문자열</param>
    /// <param name="length">자를 길이</param>
    /// <returns><paramref name="source"/>에서 <paramref name="length"/>만큼 자른 문자열</returns>
    public static string Right(this string source, int length) => source.Substring(source.Length - length);

    /// <summary>
    /// WindowsVersion 값을 윈도우 이름으로 변환
    /// </summary>
    /// <param name="version">WindowsVersion</param>
    /// <returns>해당하는 윈도우 이름</returns>
    public static string ToName(this WindowsVersion version) => version switch {
        WindowsVersion.Unknown or WindowsVersion.NT or WindowsVersion.Me or WindowsVersion.XP or WindowsVersion.Vista => version.ToString(),
        WindowsVersion.EightPointOne => "8.1",
        _ => ((int)version).ToString(),
    };
}