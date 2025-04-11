using System;
using System.Windows.Forms;
using GUI.Commands;
using GUI.Managers;

namespace GUI
{
    public partial class frmFunction : Form
    {
        private ICommand cmd;
        
        public frmFunction(string type)
        {
            InitializeComponent();
            InitializeCommand(type);
        }

        private void InitializeCommand(string type)
        {
            cmd = CommandFactory.CreateCommand(type);

            if (cmd == null)
            {
                MyMessageBox.ShowError("Không hỗ trợ loại: " + type);
                return;
            }

            if (type.Equals("Tenant"))
            {
                lblPhi.Visible = false;
                lblStatus.Visible = false;
                cbPhi.Visible = false;
                cbStatus.Visible = false;
            }

            cmd.SetDataGridView(dgv);
            lblTypeList.Text = "Danh sách " + cmd.LabelText;
        }

        private void frmFunction_Load(object sender, EventArgs e) => cmd?.Load();
        private void txtSearch_TextChanged(object sender, EventArgs e) => cmd?.Search(txtSearch.Text);
        private void btnSearch_Click(object sender, EventArgs e) => txtSearch.Focus();
        private void btnAdd_Click(object sender, EventArgs e) => cmd?.Insert();
        private void btnEdit_Click(object sender, EventArgs e) => cmd?.Edit();
        private void btnDelete_Click(object sender, EventArgs e) => cmd?.Delete();
    }
}
