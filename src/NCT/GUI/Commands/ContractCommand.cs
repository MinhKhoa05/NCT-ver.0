using System.Collections.Generic;
using System.Windows.Forms;
using BUS.Models;
using DTO;
using GUI.ChildForms;

namespace GUI.Commands
{
    public class ContractCommand : CommandBase<Contract>
    {
        protected override BaseBUS<Contract> CreateBUS() => new ContractBUS();

        public override string LabelText => "Hợp đồng";

        protected override string IdColumnName => "ContractID";

        public override Dictionary<string, string> FormatMap => new Dictionary<string, string>
        {
            ["RentPrice"] = "{0:N0} VNĐ",
            ["DepositAmount"] = "{0:N0} VNĐ"
        };

        protected override Dictionary<string, string> HeaderMap => new Dictionary<string, string>
        {
            ["ContractID"] = "ID",
            ["TenantID"] = "ID Khách thuê",
            ["RoomID"] = "Phòng",
            ["StartDate"] = "Ngày bắt đầu",
            ["EndDate"] = "Ngày hết hạn",
            ["RentPrice"] = "Giá thuê",
            ["DepositAmount"] = "Tiền cọc",
            ["Note"] = "Ghi chú"
        };

        protected override void SetupHeaders()
        {
            base.SetupHeaders();

            _dgv.Columns["DepositReturnDate"].Visible = false;
            _dgv.Columns["ContractID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            _dgv.Columns["RoomID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        protected override Form CreateForm(bool isAdd, string id = null)
        {
            return new frmContractInfo(isAdd, id);
        }
    }
}
