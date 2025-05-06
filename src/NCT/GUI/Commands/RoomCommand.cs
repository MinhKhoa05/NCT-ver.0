using System.Collections.Generic;
using System.Windows.Forms;
using BUS.Models;
using DTO;
using GUI.ChildForms;

namespace GUI.Commands
{
    public class RoomCommand : CommandBase<Room>
    {
        protected override BaseBUS<Room> CreateBUS() => new RoomBUS();

        public override string LabelText => "Phòng";

        protected override string IdColumnName => "RoomID";

        public override Dictionary<string, string> FormatMap => new Dictionary<string, string>
        {
            ["RentPrice"] = "{0:N0} VNĐ",
            ["Area"] = "{0:N0} m²"
        };

        protected override Dictionary<string, string> HeaderMap => new Dictionary<string, string>
        {
            ["RoomID"] = "ID",
            ["RoomTypeValue"] = "Loại",
            ["RentPrice"] = "Giá thuê (VNĐ)",
            ["Area"] = "Diện tích (m²)",
            ["StatusValue"] = "Tình trạng",
            ["CreatedAt"] = "Ngày thêm"
        };

        protected override void SetupHeaders()
        {
            base.SetupHeaders();

            _dgv.Columns["RoomType"].Visible = false;
            _dgv.Columns["Status"].Visible = false;
            _dgv.Columns["RoomID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        protected override Form CreateForm(bool isAdd, string id = null)
        {
            return new frmRoomInfo(isAdd, id);
        }
    }
}
