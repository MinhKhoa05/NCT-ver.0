﻿using BUS.Services;
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

        public void SetDataGridView(DataGridView dgv) => _dgv = dgv;

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
                MyMessageBox.ShowWarning("Vui lòng chọn 1 ô để thực hiện thao tác.");
                return false;
            }

            id = _dgv.CurrentRow.Cells[IdColumnName].Value?.ToString();
            return !string.IsNullOrEmpty(id);
        }
    }
}
