#nullable enable
using static BluehillShared.WindowsVersion;
using static System.Environment;

namespace BluehillShared;

/// <summary>
/// 윈도우 버전 관련 함수 목록
/// </summary>
public static class Winver {
    /// <summary>
    /// 현재 윈도우 버전
    /// </summary>
    public static WindowsVersion WindowsVersion => OSVersion.Platform switch {
        PlatformID.Win32Windows => OSVersion.Version.Minor switch {
            0 => NinetyFive,
            10 => NinetyEight,
            90 => Me,
            _ => Unknown
        },
        PlatformID.Win32NT => OSVersion.Version.Major switch {
            4 => NT,
            5 => OSVersion.Version.Minor == 0 ? TwoKilo : XP,
            6 => OSVersion.Version.Minor switch {
                0 => Vista,
                1 => Seven,
                2 => Eight,
                3 => EightPointOne,
                4 => Ten,
                _ => Unknown
            },
            10 => Ten,
            _ => Unknown
        },
        _ => Unknown
    };

    /// <summary>
    /// 현재 윈도우 버전의 문자열
    /// </summary>
    public static string WindowsName => WindowsVersion.ToName();

    /// <summary>
    /// 현재 윈도우 서비스 팩 버전
    /// </summary>
    public static string WindowsServicePack => OSVersion.Version.Major != 4 || OSVersion.Version.Minor != 10 || OSVersion.Version.Build != 2222 ? OSVersion.ServicePack : "Second Edition";

    /// <summary>
    /// 윈도우 서버인지 여부
    /// </summary>
    public static bool IsWindowsServer { get; } = IsOS(29);

    [System.Runtime.InteropServices.DllImport("shlwapi.dll", EntryPoint = "#437", SetLastError = true)]
    private static extern bool IsOS(uint os);
}