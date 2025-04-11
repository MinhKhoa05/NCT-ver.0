using System;
using System.Windows.Forms;
using GUI.ChildForms;

namespace GUI
{
    public partial class frmMain : Form
    {
        private Form currentForm;

        public frmMain()
        {
            InitializeComponent();
            ShowContent(null); // Reset on load
        }

        #region Content Management

        private void ShowContent(Form form = null, UserControl control = null)
        {
            CloseCurrentForm();
            panelDesktop.Controls.Clear();

            if (form != null)
            {
                currentForm = form;
                currentForm.TopLevel = false;
                currentForm.FormBorderStyle = FormBorderStyle.None;
                currentForm.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(currentForm);
                currentForm.BringToFront();
                currentForm.Show();
            }
            else if (control != null)
            {
                control.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(control);
            }
        }

        private void CloseCurrentForm()
        {
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm = null;
            }
        }

        #endregion

        #region Event Handlers

        private void picLogo_Click(object sender, EventArgs e) => ShowContent(); // Reset
        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            using (var loginForm = new frmLogin())
                loginForm.ShowDialog();
            Close();
        }

        private void LoadForm(string type)
        {
            var func = frmFunction.Instance;
            func.UpdateType(type);
            ShowContent(control: func);
        }

        private void btnPhong_Click(object sender, EventArgs e) => LoadForm("Room");
        private void btnKhach_Click(object sender, EventArgs e) => LoadForm("Tenant");

        private void btnHopDong_Click(object sender, EventArgs e) => ShowContent(new frmContract());
        private void btnVanTay_Click(object sender, EventArgs e) => ShowContent(new frmFingerprint());
        private void btnDienNuoc_Click(object sender, EventArgs e) => ShowContent(new frmElectricWater());
        private void btnThanhToan_Click(object sender, EventArgs e) => ShowContent(new frmPayment());
        private void btnThongke_Click(object sender, EventArgs e) => ShowContent(new frmStatistics());
        private void btnKhac_Click(object sender, EventArgs e) => ShowContent(new frmServices());
        private void btnInfoTro_Click(object sender, EventArgs e) => ShowContent(new frmInfoMotel());
        private void btnNhacNho_Click(object sender, EventArgs e) => ShowContent(new frmReminder());

        #endregion
    }
}
