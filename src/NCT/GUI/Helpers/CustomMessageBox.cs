using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace GUI.Managers
{
    public partial class CustomMessageBox : Form
    {
        // Fields
        private Color primaryColor = Color.CornflowerBlue;
        private readonly int borderSize = 2;

        // Constructor
        public CustomMessageBox(string message, string caption, MessageBoxIcon icon)
        {
            InitializeComponent();
            InitCustom(message, caption, icon);
        }

        public static DialogResult Show(string message, string caption, MessageBoxIcon icon)
        {
            using (CustomMessageBox msgBox = new CustomMessageBox(message, caption, icon))
            {
                return msgBox.ShowDialog();
            }
        }

        #region InitCustom
        private void InitCustom(string message, string caption, MessageBoxIcon icon)
        {
            InitializeItems();
            labelMessage.Text = message;
            labelCaption.Text = caption;
            SetFormSize();
            SetIcon(icon);

            BackColor = primaryColor;
        }

        private void InitializeItems()
        {
            Padding = new Padding(borderSize);
            labelMessage.MaximumSize = new Size(550, 0);
            btnOK.DialogResult = DialogResult.Cancel;
            btnOK.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e) => Close();

        private void SetFormSize()
        {
            // Đảm bảo label có kích thước phù hợp
            labelMessage.AutoSize = true;
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.AutoSize;

            // Tính toán kích thước form
            int width = Math.Max(labelMessage.Width + pictureBoxIcon.Width + panelBody.Padding.Horizontal + 40, 250);
            int height = panelTitleBar.Height + labelMessage.Height + panelButtons.Height + panelBody.Padding.Vertical + 50;

            ClientSize = new Size(width, height);

            // Căn giữa nút OK
            btnOK.Location = new Point(
                Math.Max((panelButtons.Width - btnOK.Width) / 2, 10),
                Math.Max((panelButtons.Height - btnOK.Height) / 2, 5)
            );

            // Căn giữa từng thành phần theo chiều dọc
            CenterIcon();
            CenterLabel();

            MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
        }

        private void CenterIcon()
        {
            int centerY = (panelBody.Height - pictureBoxIcon.Height) / 2;
            pictureBoxIcon.Location = new Point(pictureBoxIcon.Location.X, centerY);
        }

        private void CenterLabel()
        {
            int centerY = (panelBody.Height - labelMessage.Height) / 2;
            labelMessage.Location = new Point(labelMessage.Location.X, centerY - 3);
        }

        private void SetIcon(MessageBoxIcon icon)
        {
            var iconSettings = new Dictionary<MessageBoxIcon, (IconChar, Color)>
            {
                { MessageBoxIcon.Error, (IconChar.TimesCircle, Color.FromArgb(224, 79, 95)) },
                { MessageBoxIcon.Information, (IconChar.InfoCircle, Color.FromArgb(38, 191, 166)) },
                { MessageBoxIcon.Question, (IconChar.QuestionCircle, Color.FromArgb(10, 119, 232)) },
                { MessageBoxIcon.Exclamation, (IconChar.ExclamationTriangle, Color.FromArgb(255, 140, 0)) },
                { MessageBoxIcon.None, (IconChar.HandsHelping, Color.CornflowerBlue) }
            };

            // Lấy giá trị hoặc mặc định
            var (iconChar, color) = iconSettings.ContainsKey(icon) ? iconSettings[icon] : iconSettings[MessageBoxIcon.None];

            pictureBoxIcon.IconChar = iconChar;
            primaryColor = color;
        }

        #endregion
    }
}