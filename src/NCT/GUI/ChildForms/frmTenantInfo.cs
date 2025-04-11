using System;
using System.Windows.Forms;
using BUS.Services;
using DTO;
using GUI.Managers;

namespace GUI.ChildForms
{
    public partial class frmTenantInfo : Form
    {
        private readonly bool _isAdd;
        private readonly TenantDTO tenant;
        private readonly TenantBUS tenantBUS = new TenantBUS();
        private readonly RoomBUS roomBUS = new RoomBUS();

        public frmTenantInfo(bool isAdd, string id = null)
        {
            InitializeComponent();
            _isAdd = isAdd;

            if (!_isAdd)
                tenant = tenantBUS.GetByID(id);
        }

        private void frmTenantInfo_Load(object sender, EventArgs e)
        {
            txtCCCD.KeyPress += OnlyAllowDigits;
            txtPhone.KeyPress += OnlyAllowDigits;

            LoadCbRoom();
            LoadData();
        }

        private void OnlyAllowDigits(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void LoadCbRoom()
        {
            var rooms = roomBUS.GetAllFromTable();

            // Thêm dòng mặc định
            rooms.Insert(0, new RoomDTO
            {
                RoomID = string.Empty,
                RoomName = "-- Chọn phòng --"
            });

            cbRoom.DataSource = rooms;
            cbRoom.DisplayMember = "RoomName";
            cbRoom.ValueMember = "RoomID";
        }

        private void LoadData()
        {
            if (tenant != null)
            {
                txtTenantID.Text = tenant.TenantID;
                txtFullName.Text = tenant.FullName;
                txtPhone.Text = tenant.PhoneNumber;
                txtEmail.Text = tenant.Email;
                txtAddress.Text = tenant.Address;
                txtCCCD.Text = tenant.NationalID;
                if (tenant.RoomID != null)
                {
                    cbRoom.SelectedValue = tenant.RoomID;
                }
            }
            else
            {
                txtTenantID.Text = tenantBUS.GenerateID();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string roomID = null;
                if (!string.IsNullOrEmpty(cbRoom.SelectedValue?.ToString()))
                {
                    roomID = cbRoom.SelectedValue.ToString();
                }

                var tenant = new TenantDTO(
                    txtTenantID.Text,
                    txtFullName.Text,
                    txtPhone.Text,
                    txtEmail.Text,
                    txtAddress.Text,
                    txtCCCD.Text,
                    roomID
                );

                if (_isAdd)
                {
                    tenantBUS.Insert(tenant);
                    MyMessageBox.ShowInformation("Thêm khách thuê thành công");
                }
                else
                {
                    tenantBUS.Update(tenant);
                    MyMessageBox.ShowInformation("Đã cập nhật thông tin khách thuê");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowError(ex.Message);
            }
        }
    }
}
