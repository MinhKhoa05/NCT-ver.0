using System.Windows.Forms;

namespace GUI.Helpers
{
    public static class MyMessageBox
    {
        public static void Show(string message, string caption, MessageBoxIcon icon)
        {
            CustomMessageBox.Show(message, caption, icon);
        }

        public static void ShowInformation(string message)
        {
            Show(message, "Thông báo!", MessageBoxIcon.Information);
        }

        public static void ShowWarning(string message)
        {
            Show(message, "Chú ý!", MessageBoxIcon.Warning);
        }

        public static void ShowError(string message)
        {
            Show(message, "Lỗi!", MessageBoxIcon.Error);
        }
    }
}