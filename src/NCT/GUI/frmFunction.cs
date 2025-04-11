using System;
using System.Windows.Forms;
using BUS.Services;
using GUI.ChildForms;
using GUI.Managers;

namespace GUI
{
    public partial class frmFunction : Form
    {       
        public frmFunction()
        {
            InitializeComponent();
        }

        private void LoadDgv()
        {
            LoadRoomList();
        }

        private void frmFunction_Load(object sender, System.EventArgs e)
        {
            LoadDgv();
        }

        private void LoadRoomList()
        {
            var roomBUS = new RoomBUS();
            dgv.DataSource = roomBUS.GetAllFromTable();
            
            // Ẩn các cột không cần thiết
            dgv.Columns["RoomType"].Visible = false;
            dgv.Columns["Status"].Visible = false;

            // Đổi HeaderText
            dgv.Columns["RoomID"].HeaderText = "Mã phòng";
            dgv.Columns["RoomName"].HeaderText = "Tên phòng";
            dgv.Columns["RentPrice"].HeaderText = "Giá thuê";
            dgv.Columns["Area"].HeaderText = "Diện tích";
            dgv.Columns["RoomTypeValue"].HeaderText = "Loại phòng";
            dgv.Columns["StatusValue"].HeaderText = "Tình trạng";
            dgv.Columns["CreatedAt"].HeaderText = "Ngày tạo";
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            using (var dlg = new frmRoomInfo(true))
            {
                dlg.ShowDialog();
            }

            LoadDgv();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MyMessageBox.ShowWarning("Vui lòng chọn một dòng để chỉnh sửa.");
                return;
            }

            string roomID = dgv.CurrentRow.Cells["RoomID"].Value?.ToString();

            using (var dlg = new frmRoomInfo(false, roomID))
            {
                // TODO: truyền roomID nếu cần xử lý update
                dlg.ShowDialog();
            }

            LoadDgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                MyMessageBox.ShowWarning("Vui lòng chọn một dòng để xóa.");
                return;
            }

            string roomID = dgv.CurrentRow.Cells["RoomID"].Value?.ToString();

            var confirm = MessageBox.Show($"Bạn có chắc muốn xóa phòng '{roomID}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    RoomBUS roomBUS = new RoomBUS();
                    roomBUS.DeleteById(roomID);
                    MyMessageBox.ShowInformation("Đã xóa phòng thành công.");
                    LoadDgv();
                }
                catch (Exception ex)
                {
                    MyMessageBox.ShowError("Không thể xóa: " + ex.Message);
                }
            }
        }
    }
}
