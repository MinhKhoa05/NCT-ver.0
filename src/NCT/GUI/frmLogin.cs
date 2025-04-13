using System;
using System.Windows.Forms;
using BUS.Services;
using DTO;
using GUI.Helpers;

namespace GUI
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = new AccountBUS().Login(txtUsername.Text, txtPass.Text);
                MyMessageBox.ShowInformation("Đăng nhập thành công");

                Hide();

                using (frmMain frmMain = new frmMain(account))
                {
                    frmMain.ShowDialog();
                }

                Close();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowError(ex.Message);
                txtUsername.Focus();
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }
    }
}
