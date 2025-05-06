using System;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class frmMain : Form
    {
        private string _currentType = string.Empty;
        private Account _account;

        public frmMain(Account account)
        {
            InitializeComponent();
            _account = account;
            ShowContent(new frmHome());
        }

        #region Content Display

        private void ShowContent(UserControl control)
        {
            panelDesktop.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(control);
            control.BringToFront();
        }

        private void ShowFunction(string type)
        {
            if (_currentType == type) return;

            _currentType = type;
            var functionControl = frmFunction.Instance;
            functionControl.UpdateType(type);
            ShowContent(functionControl);
        }

        #endregion

        #region Event Handlers

        private void picLogo_Click(object sender, EventArgs e)
        {
            _currentType = string.Empty;
            ShowContent(new frmHome());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            using (var loginForm = new frmLogin())
                loginForm.ShowDialog();
            Close();
        }

        private void btnPhong_Click(object sender, EventArgs e) => ShowFunction("Room");
        private void btnKhach_Click(object sender, EventArgs e) => ShowFunction("Tenant");
        private void btnHopDong_Click(object sender, EventArgs e) => ShowFunction("Contract");
        private void btnVanTay_Click(object sender, EventArgs e) => ShowFunction("VanTay");
        private void btnDienNuoc_Click(object sender, EventArgs e) => ShowFunction("DienNuoc");
        private void btnThanhToan_Click(object sender, EventArgs e) => ShowFunction("ThanhToan");
        private void btnThongke_Click(object sender, EventArgs e) => ShowFunction("ThongKe");
        private void btnKhac_Click(object sender, EventArgs e) => ShowFunction("Service");
        private void btnInfoTro_Click(object sender, EventArgs e) => ShowFunction("ThongTinTro");
        private void btnNhacNho_Click(object sender, EventArgs e) => ShowFunction("NhacNho");

        #endregion
    }
}
