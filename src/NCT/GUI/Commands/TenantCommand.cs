using System.Windows.Forms;
using BUS.Services;
using DTO;
using GUI.ChildForms;

namespace GUI.Commands
{
    public class TenantCommand : CommandBase<Tenant>
    {
        protected override BaseBUS<Tenant> CreateBUS() => new TenantBUS();

        public override string LabelText => "Khách thuê";

        protected override string IdColumnName => "TenantID";

        protected override void SetupHeaders()
        {
            _dgv.Columns["TenantID"].HeaderText = "ID";
            _dgv.Columns["TenantID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            _dgv.Columns["FullName"].HeaderText = "Họ tên";
            _dgv.Columns["FullName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            _dgv.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            _dgv.Columns["Address"].HeaderText = "Địa chỉ";
            _dgv.Columns["Address"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            _dgv.Columns["NationalID"].HeaderText = "CCCD";
            _dgv.Columns["NationalID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            _dgv.Columns["RoomID"].HeaderText = "Phòng";
            _dgv.Columns["RoomID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        protected override Form CreateForm(bool isAdd, string id = null)
        {
            return new frmTenantInfo(isAdd, id);
        }
    }
}
