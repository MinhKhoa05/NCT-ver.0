using System.Collections.Generic;
using System.Windows.Forms;
using BUS.Models;
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

        protected override Dictionary<string, string> HeaderMap => new Dictionary<string, string>
        {
            ["ServiceID"] = "ID",
            ["ServiceName"] = "Tên dịch vụ",
            ["Type"] = "Loại",
            ["UnitPrice"] = "Đơn giá",
            ["Unit"] = "Đơn vị tính"
        };

        protected override void SetupHeaders()
        {
            base.SetupHeaders();
            _dgv.Columns["ServiceType"].Visible = false;
            _dgv.Columns["ServiceID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            _dgv.Columns["Type"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            _dgv.Columns["UnitPrice"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            _dgv.Columns["Unit"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        protected override Form CreateForm(bool isAdd, string id = null)
        {
            return new frmServiceInfo(isAdd, id);
        }
    }
}
