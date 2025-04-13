using System.Windows.Forms;
using BUS.Services;
using DTO;
using GUI.ChildForms;

namespace GUI.Commands
{
    public class ContractCommand : CommandBase<Contract>
    {
        protected override BaseBUS<Contract> CreateBUS() => new ContractBUS();
        
        public override string LabelText => "Hợp đồng";

        protected override string IdColumnName => "ContractID";

        protected override void SetupHeaders()
        {
            _dgv.Columns["DepositReturnDate"].Visible = false;

            _dgv.Columns["ContractID"].HeaderText = "ID";
            _dgv.Columns["ContractID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            _dgv.Columns["TenantID"].HeaderText = "ID Khách thuê";
            _dgv.Columns["RoomID"].HeaderText = "Phòng";
            _dgv.Columns["RoomID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            _dgv.Columns["StartDate"].HeaderText = "Ngày bắt đầu";
            _dgv.Columns["EndDate"].HeaderText = "Ngày hết hạn";
            _dgv.Columns["RentPrice"].HeaderText = "Giá thuê";
            _dgv.Columns["DepositAmount"].HeaderText = "Tiền cọc";
            _dgv.Columns["Note"].HeaderText = "Ghi chú";

            _dgv.CellFormatting += dgv_CellFormatting;
        }

        protected override Form CreateForm(bool isAdd, string id = null)
        {
            return new frmContractInfo(isAdd, id);
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = _dgv.Columns[e.ColumnIndex].Name;

            if (e.Value == null) return;

            if (columnName == "RentPrice" && int.TryParse(e.Value.ToString(), out int rentPrice))
            {
                e.Value = string.Format("{0:N0} VNĐ", rentPrice);
                e.FormattingApplied = true;
            }
            else if (columnName == "DepositAmount" && int.TryParse(e.Value.ToString(), out int tienCoc))
            {
                e.Value = string.Format("{0:N0} VNĐ", tienCoc);
                e.FormattingApplied = true;
            }
        }
    }
}
