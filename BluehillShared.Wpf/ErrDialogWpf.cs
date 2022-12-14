using System.Windows;

namespace BluehillShared;

public static class ErrDialogWpf {
    public static void ErrMsg(string message, bool exit) {
        ErrMsg(message);
        if (exit) System.Windows.Application.Current.Shutdown(1);
    }

    public static MessageBoxResult ErrMsg(string message) => ErrMsg(message, MessageBoxButton.OK);
    public static MessageBoxResult ErrMsg(string message, MessageBoxButton button) => System.Windows.MessageBox.Show(message, "오류", button, MessageBoxImage.Error);
}