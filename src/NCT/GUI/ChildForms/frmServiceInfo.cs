using System;
using System.Windows.Forms;
using BUS.Services;
using DTO;
using GUI.Helpers;

namespace GUI.ChildForms
{
    public partial class frmServiceInfo : Form
    {
        private readonly bool _isAdd;
        private readonly ServiceBUS serviceBUS = new ServiceBUS();
        private readonly Service service;

        public frmServiceInfo(bool isAdd, string serviceId = null)
        {
            InitializeComponent();
            _isAdd = isAdd;

            if (!_isAdd)
                service = serviceBUS.GetByID(serviceId);

            txtUnitPrice.KeyPress += OnlyAllowDigits;
        }

        private void frmServiceInfo_Load(object sender, EventArgs e)
        {
            LoadServiceTypeOptions();
            LoadUnitOptions();

            if (_isAdd)
            {
                txtServiceID.Text = serviceBUS.GenerateID();
            }
            else
            {
                LoadFormData();
            }
        }

        private void LoadServiceTypeOptions()
        {
            cbServiceType.Items.Clear();
            cbServiceType.Items.AddRange(new object[]
            {
                "Phát sinh",
                "Định kỳ"
            });
            cbServiceType.SelectedIndex = 0;
        }

        private void LoadUnitOptions()
        {
            cbUnit.Items.Clear();
            cbUnit.Items.AddRange(new object[]
            {
                "lần",          // dọn phòng, bảo trì
                "kWh",          // điện
                "m³",           // nước
                "tháng",        // wifi, rác thải, truyền hình cáp
                "chiếc/tháng",  // gửi xe
                "kg",           // giặt ủi
                "bình"          // nước uống
            });
            cbUnit.SelectedIndex = 0;
        }

        private void LoadFormData()
        {
            if (service == null) return;

            txtServiceID.Text = service.ServiceID;
            txtServiceName.Text = service.ServiceName;
            cbServiceType.SelectedIndex = service.ServiceType ? 1 : 0;
            txtUnitPrice.Text = service.UnitPrice.ToString("N0");

            int index = cbUnit.Items.IndexOf(service.Unit);
            if (index >= 0)
                cbUnit.SelectedIndex = index;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new Service(
                    txtServiceID.Text,
                    StringHelper.FormatProperName(txtServiceName.Text.Trim()),
                    cbServiceType.SelectedIndex == 1,
                    int.Parse(txtUnitPrice.Text.Replace(",", "")),
                    cbUnit.SelectedItem.ToString()
                );

                if (_isAdd)
                {
                    serviceBUS.Insert(service);
                    MyMessageBox.ShowInformation("Thêm dịch vụ thành công");
                }
                else
                {
                    serviceBUS.Update(service);
                    MyMessageBox.ShowInformation("Đã cập nhật dịch vụ");
                }

                Close();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowError(ex.Message);
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtUnitPrice.Text.Replace(",", ""), out int value))
            {
                txtUnitPrice.TextChanged -= txtUnitPrice_TextChanged;
                txtUnitPrice.Text = value.ToString("N0");
                txtUnitPrice.SelectionStart = txtUnitPrice.Text.Length;
                txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
            }
        }

        private void OnlyAllowDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
