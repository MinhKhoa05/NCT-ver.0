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

            _dgv.Columns["RoomName"].HeaderText = "Tên phòng";
            _dgv.Columns["RentPrice"].HeaderText = "Giá thuê";
            _dgv.Columns["Area"].HeaderText = "Diện tích";
            _dgv.Columns["RoomTypeValue"].HeaderText = "Loại phòng";
            _dgv.Columns["StatusValue"].HeaderText = "Tình trạng";
            _dgv.Columns["CreatedAt"].HeaderText = "Ngày thêm";
        }

        protected override Form CreateForm(bool isAdd, string id = null)
        {
            return new frmRoomInfo(isAdd, id);
        }
    }
}
