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
        }

        protected override Form CreateForm(bool isAdd, string id = null)
        {
            return new frmRoomInfo(isAdd, id);
        }
    }
}
