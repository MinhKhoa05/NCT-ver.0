using System.Drawing;
using System.Windows.Forms;
using GUI.Commands;
using System;
using GUI.Helpers;

namespace GUI
{
    public partial class frmFunction : UserControl
    {
        private ICommand currentCommand;
        private string currentType;
        private static frmFunction _instance;

        private frmFunction()
        {
            InitializeComponent();
            InitializeEvents();
        }

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
            if (type == currentType) return;

            currentType = type;

            try
            {
                currentCommand = CommandFactory.CreateCommand(type);
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowError(ex.Message);
                return;
            }

            ConfigureUI(type);

            currentCommand.SetDataGridView(dgv);
            lblTypeList.Text = $"Quản lý {currentCommand.LabelText}";
            txtSearch.Text = string.Empty;

            dgv.DataBindingComplete -= Dgv_DataBindingComplete;
            dgv.DataBindingComplete += Dgv_DataBindingComplete;

            currentCommand.Load();
        }

        private void ConfigureUI(string type)
        {
            bool isRoom = false;
            lblPhi.Visible = isRoom;
            lblStatus.Visible = isRoom;
            cbPhi.Visible = isRoom;
            cbStatus.Visible = isRoom;
        }

        private void InitializeEvents()
        {
            txtSearch.TextChanged += (s, e) => currentCommand?.Search(txtSearch.Text.Trim());
            btnSearch.Click += (s, e) => txtSearch.Focus();
            btnInsert.Click += (s, e) => currentCommand?.Insert();
            btnEdit.Click += (s, e) => currentCommand?.Edit();
            btnDelete.Click += (s, e) => currentCommand?.Delete();

            dgv.CellMouseEnter += Dgv_CellMouseEnter;
            dgv.CellMouseLeave += Dgv_CellMouseLeave;
        }

        private void Dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgv.RowCount) return;

            var row = dgv.Rows[e.RowIndex];
            row.DefaultCellStyle.BackColor = Color.FromArgb(180, 200, 160);
            row.DefaultCellStyle.ForeColor = Color.FromArgb(20, 20, 20);
        }

        private void Dgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgv.RowCount) return;

            var row = dgv.Rows[e.RowIndex];
            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 245);
            row.DefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 60);
        }

        private void Dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv.ClearSelection();
            dgv.CurrentCell = null;
        }
    }
}
