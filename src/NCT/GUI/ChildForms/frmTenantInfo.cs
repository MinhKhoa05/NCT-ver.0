using System;
using System.Windows.Forms;
using BUS.Models;
using DTO;
using GUI.Helpers;

namespace GUI.ChildForms
{
    public partial class frmTenantInfo : Form
    {
        private readonly bool _isAdd;
        private readonly Tenant _tenant;
        private readonly TenantBUS _tenantBUS = new TenantBUS();

        public frmTenantInfo(bool isAdd, string tenantId = null)
        {
            InitializeComponent();
            _isAdd = isAdd;

            if (!_isAdd)
                _tenant = _tenantBUS.GetByID(tenantId);
        }

        private void frmTenantInfo_Load(object sender, EventArgs e)
        {
            txtCCCD.KeyPress += FormHelper.OnlyAllowDigits;
            txtPhone.KeyPress += FormHelper.OnlyAllowDigits;

            txtRoom.Visible = !_isAdd;
            lblRoom.Visible = !_isAdd;

            txtFullName.Focus();
            LoadData();
        }

        private void LoadData()
        {
            if (_tenant != null)
            {
                txtTenantID.Text = _tenant.TenantID;
                txtFullName.Text = _tenant.FullName;
                txtPhone.Text = _tenant.PhoneNumber;
                txtEmail.Text = _tenant.Email;
                txtAddress.Text = _tenant.Address;
                txtCCCD.Text = _tenant.NationalID;
                txtRoom.Text = string.IsNullOrEmpty(_tenant.RoomID) ? "-- None --" : _tenant.RoomID;
            }
            else
            {
                txtTenantID.Text = _tenantBUS.GenerateID();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var tenant = new Tenant(
                    txtTenantID.Text.Trim(),
                    FormHelper.FormatProperName(txtFullName.Text),
                    txtPhone.Text.Trim(),
                    txtEmail.Text.Trim(),
                    FormHelper.FormatProperName(txtAddress.Text),
                    txtCCCD.Text.Trim()
                );

                if (_isAdd)
                {
                    _tenantBUS.Insert(tenant);
                    MyMessageBox.ShowInformation("Thêm khách thuê thành công");
                }
                else
                {
                    _tenantBUS.Update(tenant);
                    MyMessageBox.ShowInformation("Đã cập nhật thông tin khách thuê");
                }

                Close();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowError(ex.Message);
            }
        }
    }
}
