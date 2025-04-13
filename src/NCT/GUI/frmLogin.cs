using System;
using System.Windows.Forms;
using BUS.Services;
using DTO;
using GUI.Managers;

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

                this.Hide();

                using (frmMain frmMain = new frmMain(account))
                {
                    frmMain.ShowDialog();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowError(ex.Message);
                txtUsername.Focus();
            }
        }
    }
}
