using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.Commands;
using GUI.Helpers;

namespace GUI
{
    public partial class frmFunction : UserControl
    {
        #region Fields

        private ICommand currentCommand;
        private string currentType;
        private static frmFunction _instance;

        #endregion

        #region Singleton

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

        #endregion

        #region Public Methods

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

            dgv.DataBindingComplete -= dgv_DataBindingComplete;
            dgv.DataBindingComplete += dgv_DataBindingComplete;

            dgv.CellFormatting -= dgv_CellFormatting;
            dgv.CellFormatting += dgv_CellFormatting;

            currentCommand.Load();
        }

        #endregion

        #region UI Initialization

        private void InitializeEvents()
        {
            txtSearch.TextChanged += (s, e) => currentCommand?.Search(txtSearch.Text.Trim());
            btnSearch.Click += (s, e) => txtSearch.Focus();
            btnInsert.Click += (s, e) => currentCommand?.Insert();
            btnEdit.Click += (s, e) => currentCommand?.Edit();
            btnDelete.Click += (s, e) => currentCommand?.Delete();
        }

        private void ConfigureUI(string type)
        {
            bool isRoom = false; // Update logic if needed
            lblPhi.Visible = isRoom;
            lblStatus.Visible = isRoom;
            cbPhi.Visible = isRoom;
            cbStatus.Visible = isRoom;
        }

        #endregion

        #region DataGridView Events

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || currentCommand == null) return;

            string columnName = dgv.Columns[e.ColumnIndex].Name;
            var formatMap = currentCommand.FormatMap;

            if (formatMap == null) return;

            if (formatMap.TryGetValue(columnName, out string format)
                && int.TryParse(e.Value.ToString(), out int value))
            {
                e.Value = string.Format(format, value);
                e.FormattingApplied = true;
            }
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgv.ClearSelection();
            dgv.CurrentCell = null;
        }

        private void dgv_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgv.RowCount) return;

            var row = dgv.Rows[e.RowIndex];
            row.DefaultCellStyle.BackColor = Color.FromArgb(180, 200, 160);
            row.DefaultCellStyle.ForeColor = Color.FromArgb(20, 20, 20);
        }

        private void dgv_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgv.RowCount) return;

            var row = dgv.Rows[e.RowIndex];
            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 245);
            row.DefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 60);
        }

        #endregion
    }
}
