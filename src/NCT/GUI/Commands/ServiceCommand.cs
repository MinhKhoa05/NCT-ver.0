using System.Collections.Generic;
using System.Windows.Forms;
using BUS.Services;
using DTO;
using GUI.ChildForms;

namespace GUI.Commands
{
    public class ServiceCommand : CommandBase<Service>
    {
        protected override BaseBUS<Service> CreateBUS() => new ServiceBUS();
        
        public override string LabelText => "Dịch vụ";

        protected override string IdColumnName => "ServiceID";

        public override Dictionary<string, string> FormatMap => new Dictionary<string, string>
        {
            ["UnitPrice"] = "{0:N0} VNĐ",
        };

        protected override void SetupHeaders()
        {
            _dgv.Columns["ServiceType"].Visible = false;

            _dgv.Columns["ServiceID"].HeaderText = "ID";
            _dgv.Columns["ServiceID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            _dgv.Columns["ServiceName"].HeaderText = "Tên dịch vụ";
            _dgv.Columns["Type"].HeaderText = "Loại";
            _dgv.Columns["UnitPrice"].HeaderText = "Đơn giá";
            _dgv.Columns["Unit"].HeaderText = "Đơn vị tính";
        }

        protected override Form CreateForm(bool isAdd, string id = null)
        {
            return new frmServiceInfo(isAdd, id);
        }
    }
}
