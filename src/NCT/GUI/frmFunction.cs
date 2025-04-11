using System;
using System.Windows.Forms;
using GUI.Commands;

namespace GUI
{
    public partial class frmFunction : UserControl
    {
        private ICommand cmd;
        private string currentType;

        private static frmFunction _instance;

        private frmFunction() => InitializeComponent();

        public static frmFunction Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new frmFunction();
                return _instance;
            }
        }

        public void UpdateType(string type)
        {
            if (type == currentType)
                return;

            currentType = type;
            cmd = CommandFactory.CreateCommand(type);
            ConfigureUIByType(type);
            cmd.SetDataGridView(dgv);
            lblTypeList.Text = $"Danh sách {cmd.LabelText}";
            cmd.Load();
        }

        private void ConfigureUIByType(string type)
        {
            bool isTenant = type == "Tenant";

            lblPhi.Visible = !isTenant;
            lblStatus.Visible = !isTenant;
            cbPhi.Visible = !isTenant;
            cbStatus.Visible = !isTenant;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => cmd?.Search(txtSearch.Text);
        private void btnSearch_Click(object sender, EventArgs e) => txtSearch.Focus();
        private void btnInsert_Click(object sender, EventArgs e) => cmd?.Insert();
        private void btnEdit_Click(object sender, EventArgs e) => cmd?.Edit();
        private void btnDelete_Click(object sender, EventArgs e) => cmd?.Delete();
    }
}
