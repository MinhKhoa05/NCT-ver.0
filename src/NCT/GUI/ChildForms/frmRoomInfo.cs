using System;
using System.Windows.Forms;
using BUS.Services;
using DTO;
using GUI.Helpers;

namespace GUI.ChildForms
{
    public partial class frmRoomInfo : Form
    {
        private readonly bool _isAdd;
        private readonly Room room;
        private readonly RoomBUS roomBUS = new RoomBUS();

        public frmRoomInfo(bool isAdd = true, string id = null)
        {
            InitializeComponent();
            _isAdd = isAdd;
            if (!_isAdd) room = roomBUS.GetByID(id);
        }

        private void frmRoomInfo_Load(object sender, EventArgs e)
        {
            InitRoomTypeComboBox();
            BindEvents();
            ToggleExtraFields(!_isAdd);
            if (!_isAdd) FillRoomData();
        }

        private void InitRoomTypeComboBox()
        {
            cbRoomType.Items.AddRange(new[] { "Phòng trống", "Vật dụng cơ bản" });
            cbRoomType.SelectedIndex = 0;
        }

        private void BindEvents()
        {
            txtGiaThue.KeyPress += FormHelper.OnlyAllowDigits;
            txtGiaThue.TextChanged += txtGiaThue_TextChanged;
            txtArea.KeyPress += FormHelper.OnlyAllowDigits;
        }

        private void txtGiaThue_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtGiaThue.Text.Replace(",", ""), out int value))
            {
                txtGiaThue.TextChanged -= txtGiaThue_TextChanged;
                txtGiaThue.Text = value.ToString("N0");
                txtGiaThue.SelectionStart = txtGiaThue.Text.Length;
                txtGiaThue.TextChanged += txtGiaThue_TextChanged;
            }
        }

        private void ToggleExtraFields(bool visible)
        {
            txtCreatedAt.Visible = lblCreatedAt.Visible = visible;
            txtStatus.Visible = lblStatus.Visible = visible;
        }

        private void FillRoomData()
        {
            if (room == null) return;

            txtRoomID.Text = room.RoomID;
            txtRoomID.Enabled = false;
            txtArea.Text = room.Area.ToString();
            cbRoomType.SelectedIndex = room.RoomType ? 1 : 0;
            txtGiaThue.Text = room.RentPrice.ToString("N0");
            txtStatus.Text = room.StatusValue;
            txtCreatedAt.Text = room.CreatedAt.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var newRoom = new Room(
                    txtRoomID.Text.Trim(),
                    FormHelper.TryParseInt(txtGiaThue.Text),
                    FormHelper.TryParseInt(txtArea.Text)
                );

                if (_isAdd)
                {
                    roomBUS.Insert(newRoom);
                    MyMessageBox.ShowInformation("Thêm phòng thành công");
                }
                else
                {
                    roomBUS.Update(newRoom);
                    MyMessageBox.ShowInformation("Đã cập nhật thông tin phòng");
                }

                Close();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowError(ex.Message);
            }
        }
    }
}
