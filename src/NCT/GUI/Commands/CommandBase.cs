using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS.Models;
using GUI.Helpers;

namespace GUI.Commands
{
    public abstract class CommandBase<T> : ICommand where T : class, new()
    {
        #region Fields

        protected readonly BaseBUS<T> _bus;
        protected DataGridView _dgv;

        #endregion

        #region Constructor

        protected CommandBase()
        {
            _bus = CreateBUS();
        }

        #endregion

        #region Abstract Members

        protected abstract BaseBUS<T> CreateBUS();
        protected abstract string IdColumnName { get; }
        protected abstract Form CreateForm(bool isAdd, string id = null);
        protected abstract void SetupHeaders();
        public abstract string LabelText { get; }

        #endregion

        #region Public Interface

        public void SetDataGridView(DataGridView dgv)
        {
            _dgv = dgv;
        }

        public void Load()
        {
            if (_dgv == null) return;

            _dgv.Columns.Clear();
            _dgv.AutoGenerateColumns = true;
            _dgv.DataSource = _bus.GetAll();

            SetupHeaders();
        }

        public void Search(string keyword)
        {
            if (_dgv == null) return;
            _dgv.DataSource = _bus.Search(keyword);
        }

        public void Insert() => ShowForm(isAdd: true);

        public void Edit()
        {
            if (!TryGetSelectedId(out var id)) return;
            ShowForm(isAdd: false, id);
        }

        public void Delete()
        {
            if (!TryGetSelectedId(out var id)) return;

            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa {LabelText} '{id}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                _bus.DeleteById(id);
                MyMessageBox.ShowInformation("Đã xóa thành công.");
                Load();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowError("Không thể xóa: " + ex.Message);
            }
        }

        #endregion

        #region Protected Helpers
        public virtual Dictionary<string, string> FormatMap => null;

        #endregion

        #region Private Helpers

        private void ShowForm(bool isAdd, string id = null)
        {
            if (_dgv == null) return;

            using (var form = CreateForm(isAdd, id))
            {
                form?.ShowDialog();
            }

            Load();
        }

        private bool TryGetSelectedId(out string id)
        {
            id = null;

            if (_dgv?.CurrentRow == null)
            {
                MyMessageBox.ShowWarning("Vui lòng chọn một dòng để thực hiện thao tác.");
                return false;
            }

            var cellValue = _dgv.CurrentRow.Cells[IdColumnName].Value;
            id = cellValue?.ToString();

            return true;
        }

        #endregion
    }
}
