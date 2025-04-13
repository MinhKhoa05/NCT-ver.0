using System;
using System.Windows.Forms;
using BUS.Services;
using DTO;
using GUI.Helpers;

namespace GUI.ChildForms
{
    public partial class frmTenantInfo : Form
    {
        private readonly bool _isAdd;
        private readonly Tenant tenant;
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

            if (_isAdd)
            {
                txtRoom.Visible = false;
                lblRoom.Visible = false;
            }

            LoadData();
        }

        private void OnlyAllowDigits(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
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
                txtRoom.Text = tenant.RoomID == null ? "-- None --" : tenant.RoomID;
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
                string fullname = StringHelper.FormatProperName(txtFullName.Text);
                string address = StringHelper.FormatProperName(txtAddress.Text);

                var tenant = new Tenant(
                    txtTenantID.Text,
                    fullname,
                    txtPhone.Text,
                    txtEmail.Text,
                    address,
                    txtCCCD.Text
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
