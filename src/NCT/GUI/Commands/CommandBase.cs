using BUS.Services;
using GUI.Managers;
using System;
using System.Windows.Forms;

namespace GUI.Commands
{
    public abstract class CommandBase<T> : ICommand where T : class, new()
    {
        protected readonly BaseBUS<T> _bus;
        protected DataGridView _dgv;

        protected CommandBase() => _bus = CreateBUS();

        protected abstract BaseBUS<T> CreateBUS();
        protected abstract string IdColumnName { get; }
        protected abstract Form CreateForm(bool isAdd, string id = null);
        protected abstract void SetupHeaders();

        public virtual string LabelText => "Danh sách";

        public void SetDataGridView(DataGridView dgv)
        {
            _dgv = dgv;
        }

        public void Load()
        {
            if (_dgv == null) return;

            _dgv.DataSource = _bus.GetAllFromTable();
            SetupHeaders();
        }

        public void Search(string keyword)
        {
            if (_dgv == null) return;

            _dgv.DataSource = _bus.Search(keyword);
        }

        public void Insert() => ShowForm(true);
        public void Edit() => ShowForm(false);

        private void ShowForm(bool isAdd)
        {
            if (_dgv == null) return;

            string id = null;
            if (!isAdd && _dgv.CurrentRow != null)
                id = _dgv.CurrentRow.Cells[IdColumnName].Value?.ToString();

            using (var form = CreateForm(isAdd, id))
            {
                form?.ShowDialog();
            }

            Load();
        }

        public void Delete()
        {
            if (_dgv?.CurrentRow == null) return;

            var id = _dgv.CurrentRow.Cells[IdColumnName].Value?.ToString();
            if (string.IsNullOrEmpty(id)) return;

            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa {LabelText} '{id}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                _bus.DeleteById(id);
                MyMessageBox.ShowInformation("Đã xóa thành công.");
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowError("Không thể xóa: " + ex.Message);
            }

            Load();
        }
    }
}
