using System.Collections.Generic;
using System.Windows.Forms;
using BUS.Models;
using DTO;
using GUI.ChildForms;

namespace GUI.Commands
{
    public class TenantCommand : CommandBase<Tenant>
    {
        protected override BaseBUS<Tenant> CreateBUS() => new TenantBUS();

        public override string LabelText => "Khách thuê";

        protected override string IdColumnName => "TenantID";

        protected override Dictionary<string, string> HeaderMap => new Dictionary<string, string>
        {
            ["RoomID"] = "Phòng",
            ["TenantID"] = "ID",
            ["FullName"] = "Họ tên",
            ["PhoneNumber"] = "Số điện thoại",
            ["Address"] = "Địa chỉ",
            ["NationalID"] = "CCCD"
        };

        protected override void SetupHeaders()
        {
            base.SetupHeaders();
            _dgv.Columns["RoomID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            _dgv.Columns["TenantID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            _dgv.Columns["NationalID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        protected override Form CreateForm(bool isAdd, string id = null)
        {
            return new frmTenantInfo(isAdd, id);
        }
    }
}
