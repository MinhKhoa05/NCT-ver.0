using System.Windows.Forms;
using BUS.Services;
using DTO;
using GUI.ChildForms;

namespace GUI.Commands
{
    public class RoomCommand : CommandBase<Room>
    {
        protected override BaseBUS<Room> CreateBUS() => new RoomBUS();

        public override string LabelText => "Phòng";

        protected override string IdColumnName => "RoomID";

        protected override void SetupHeaders()
        {
            _dgv.Columns["RoomType"].Visible = false;
            _dgv.Columns["Status"].Visible = false;

            _dgv.Columns["RoomID"].HeaderText = "ID";
            _dgv.Columns["RoomID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            _dgv.Columns["RentPrice"].HeaderText = "Giá thuê (VNĐ)";
            _dgv.Columns["Area"].HeaderText = "Diện tích (m²)";
            _dgv.Columns["RoomTypeValue"].HeaderText = "Loại";
            _dgv.Columns["StatusValue"].HeaderText = "Tình trạng";
            _dgv.Columns["CreatedAt"].HeaderText = "Ngày thêm";

            _dgv.CellFormatting += dgv_CellFormatting;
        }

        protected override Form CreateForm(bool isAdd, string id = null)
        {
            return new frmRoomInfo(isAdd, id);
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
            else if (columnName == "Area" && int.TryParse(e.Value.ToString(), out int area))
            {
                e.Value = string.Format("{0:N0} m²", area);
                e.FormattingApplied = true;
            }
        }
    }
}
