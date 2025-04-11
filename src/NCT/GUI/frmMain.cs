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
            ResetPanel();
        }

        #region Panel Handling

        private void OpenChildForm(Form childForm)
        {
            if (childForm == null)
            {
                ResetPanel();
                return;
            }

            if (currentForm != null && currentForm.GetType() == childForm.GetType())
                return;

            CloseCurrentForm();

            currentForm = childForm;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Clear();
            panelDesktop.Controls.Add(currentForm);
            currentForm.BringToFront();
            currentForm.Show();
        }

        private void CloseCurrentForm()
        {
            currentForm?.Close();
            currentForm = null;
        }

        private void LoadControl(UserControl control)
        {
            if (control == null) return;

            panelDesktop.SuspendLayout();
            panelDesktop.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(control);
            panelDesktop.ResumeLayout();
        }

        private void ResetPanel()
        {
            CloseCurrentForm();
            panelDesktop.Controls.Clear();
        }

        #endregion

        #region Form Events

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            using (var loginForm = new frmLogin())
                loginForm.ShowDialog();
            Close();
        }

        private void picLogo_Click(object sender, EventArgs e) => ResetPanel();

        #endregion

        #region Menu Events

        private void LoadForm(string type)
        {
            var func = frmFunction.Instance;
            func.UpdateType(type);
            LoadControl(func);
        }

        private void btnPhong_Click(object sender, EventArgs e) => LoadForm("Room");
        private void btnHopDong_Click(object sender, EventArgs e) => OpenChildForm(new frmContract());
        private void btnKhach_Click(object sender, EventArgs e) => LoadForm("Tenant");
        private void btnVanTay_Click(object sender, EventArgs e) => OpenChildForm(new frmFingerprint());
        private void btnDienNuoc_Click(object sender, EventArgs e) => OpenChildForm(new frmElectricWater());
        private void btnThanhToan_Click(object sender, EventArgs e) => OpenChildForm(new frmPayment());
        private void btnThongke_Click(object sender, EventArgs e) => OpenChildForm(new frmStatistics());
        private void btnKhac_Click(object sender, EventArgs e) => OpenChildForm(new frmServices());
        private void btnInfoTro_Click(object sender, EventArgs e) => OpenChildForm(new frmInfoMotel());
        private void btnNhacNho_Click(object sender, EventArgs e) => OpenChildForm(new frmReminder());

        #endregion
    }
}
