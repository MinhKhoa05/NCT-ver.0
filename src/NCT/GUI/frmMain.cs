using System;
using System.Windows.Forms;
using GUI.ChildForms;

namespace GUI
{
    public partial class frmMain : Form
    {
        //private AccountDTO _currentAccount;
        private Form currentForm = null;

        public frmMain()
        {
            InitializeComponent();
            ResetPanel();
        }

        //public frmMain(AccountDTO account)
        //{
        //    InitializeComponent();
        //    _currentAccount = account;
        //    ResetPanel();
        //}

        #region Panel Handling

        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
                currentForm.Close();

            panelDesktop.Controls.Clear();
            currentForm = childForm;

            if (childForm != null)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                panelDesktop.Controls.Add(childForm);
                panelDesktop.Tag = childForm;

                childForm.BringToFront();
                childForm.Show();
            }
        }

        private void ResetPanel() => OpenChildForm(null);

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

        private void btnPhong_Click(object sender, EventArgs e) => OpenChildForm(new frmFunction("Room"));
        private void btnHopDong_Click(object sender, EventArgs e) => OpenChildForm(new frmContract());
        private void btnKhach_Click(object sender, EventArgs e) => OpenChildForm(new frmFunction("Tenant"));
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
