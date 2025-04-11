using System;
using System.Windows.Forms;
using BUS.Services;
using GUI.ChildForms;
using GUI.Managers;

namespace GUI
{
    public partial class frmFunction : Form
    {
        private readonly string _type;

        public frmFunction(string type)
        {
            InitializeComponent();
            _type = type;
        }

        private void frmFunction_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            if (_type == "Room")
                LoadRoomList();
            else if (_type == "Tenant")
                LoadTenantList();
        }

        private void LoadRoomList()
        {
            lblTypeList.Text = "Danh sách phòng";
            dgv.DataSource = new RoomBUS().GetAllFromTable();

            dgv.Columns["RoomType"].Visible = false;
            dgv.Columns["Status"].Visible = false;

            dgv.Columns["RoomID"].HeaderText = "Mã phòng";
            dgv.Columns["RoomName"].HeaderText = "Tên phòng";
            dgv.Columns["RentPrice"].HeaderText = "Giá thuê";
            dgv.Columns["Area"].HeaderText = "Diện tích";
            dgv.Columns["RoomTypeValue"].HeaderText = "Loại phòng";
            dgv.Columns["StatusValue"].HeaderText = "Tình trạng";
            dgv.Columns["CreatedAt"].HeaderText = "Ngày tạo";
        }

        private void LoadTenantList()
        {
            lblTypeList.Text = "Danh sách khách thuê";
            dgv.DataSource = new TenantBUS().GetAllFromTable();

            dgv.Columns["TenantID"].HeaderText = "ID";
            dgv.Columns["TenantID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgv.Columns["FullName"].HeaderText = "Họ tên";
            dgv.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            dgv.Columns["Address"].HeaderText = "Địa chỉ";
            dgv.Columns["NationalID"].HeaderText = "CCCD";
            dgv.Columns["NationalID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgv.Columns["RoomID"].HeaderText = "Phòng";
            dgv.Columns["RoomID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            lblPhi.Visible = false;
            lblStatus.Visible = false;
            lblSearch.Text = "Tên";
            cbPhi.Visible = false;
            cbStatus.Visible = false;
        }

        private Form CreateForm(bool isAdd)
        {
            if (isAdd)
            {
                if (_type == "Room")
                    return new frmRoomInfo(true);
                if (_type == "Tenant")
                    return new frmTenantInfo(true);
            }
            else
            {
                if (dgv.CurrentRow == null) return null;

                string id = null;

                if (_type == "Room")
                    id = dgv.CurrentRow.Cells["RoomID"].Value?.ToString();
                else if (_type == "Tenant")
                    id = dgv.CurrentRow.Cells["TenantID"].Value?.ToString();

                if (_type == "Room")
                    return new frmRoomInfo(false, id);
                if (_type == "Tenant")
                    return new frmTenantInfo(false, id);
            }

            return null;
        }

        private void OpenForm(bool isAdd)
        {
            using (var form = CreateForm(isAdd))
            {
                if (form != null)
                    form.ShowDialog();
            }

            LoadList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenForm(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MyMessageBox.ShowWarning("Vui lòng chọn một dòng để chỉnh sửa.");
                return;
            }

            OpenForm(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MyMessageBox.ShowWarning("Vui lòng chọn một dòng để xóa.");
                return;
            }

            Delete();
        }

        private void Delete()
        {
            string id = null;
            string label = null;

            if (_type == "Room")
            {
                id = dgv.CurrentRow.Cells["RoomID"].Value?.ToString();
                label = "Phòng";
            }
            else if (_type == "Tenant")
            {
                id = dgv.CurrentRow.Cells["TenantID"].Value?.ToString();
                label = "Khách thuê";
            }

            if (string.IsNullOrEmpty(id)) return;

            var confirm = MessageBox.Show(
                $"Bạn có chắc muốn xóa {label} '{id}' không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                if (_type == "Room")
                    new RoomBUS().DeleteById(id);
                else if (_type == "Tenant")
                    new TenantBUS().DeleteById(id);

                MyMessageBox.ShowInformation("Đã xóa thành công.");
                LoadList();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowError("Không thể xóa: " + ex.Message);
            }
        }
    }
}
