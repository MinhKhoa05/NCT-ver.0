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
        
        protected override void SetupHeaders()
        {
            _dgv.Columns["ServiceType"].Visible = false;

            _dgv.Columns["ServiceID"].HeaderText = "ID";
            _dgv.Columns["ServiceID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            _dgv.Columns["ServiceName"].HeaderText = "Tên dịch vụ";
            _dgv.Columns["Type"].HeaderText = "Loại";
            _dgv.Columns["UnitPrice"].HeaderText = "Đơn giá";
            _dgv.Columns["Unit"].HeaderText = "Đơn vị tính";

            _dgv.CellFormatting += dgv_CellFormatting;
        }

        protected override Form CreateForm(bool isAdd, string id = null)
        {
            return new frmServiceInfo(isAdd, id);
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string columnName = _dgv.Columns[e.ColumnIndex].Name;

            if (e.Value == null) return;

            if (columnName == "UnitPrice" && double.TryParse(e.Value.ToString(), out double unitPrice))
            {
                e.Value = string.Format("{0:N0} VNĐ", unitPrice);
                e.FormattingApplied = true;
            }
        }
    }
}
