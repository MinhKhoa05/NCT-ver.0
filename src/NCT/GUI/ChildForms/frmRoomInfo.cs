﻿using System;
using System.Windows.Forms;
using BUS.Services;
using DTO;
using GUI.Managers;

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

            if (!_isAdd)
            {
                room = roomBUS.GetByID(id);
            }
        }

        private void frmRoomInfo_Load(object sender, EventArgs e)
        {
            txtGiaThue.KeyPress += OnlyAllowDigits;
            txtArea.KeyPress += OnlyAllowDigits;

            LoadCbRoomType();
            ToggleExtraFields(!_isAdd);
            LoadEdit();
        }

        private void OnlyAllowDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void LoadEdit()
        {
            if (room != null)
            {
                txtRoomID.Text = room.RoomID;
                txtRoomID.Enabled = false;

                txtRoomName.Text = room.RoomName;
                txtArea.Text = room.Area.ToString();
                cbRoomType.SelectedIndex = room.RoomType ? 1 : 0;
                txtGiaThue.Text = room.RentPrice.ToString();
                txtStatus.Text = room.StatusValue;
                txtCreatedAt.Text = room.CreatedAt.ToString();
            }
        }

        private void LoadCbRoomType()
        {
            cbRoomType.Items.Clear();
            cbRoomType.Items.Add("Phòng trống");
            cbRoomType.Items.Add("Vật dụng cơ bản");
            cbRoomType.SelectedIndex = 0;
        }

        private void ToggleExtraFields(bool visible)
        {
            txtCreatedAt.Visible = visible;
            lblCreatedAt.Visible = visible;
            txtStatus.Visible = visible;
            lblStatus.Visible = visible;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var roomID = txtRoomID.Text.Trim();
                var roomName = txtRoomName.Text.Trim();
                var roomType = cbRoomType.SelectedIndex == 1;

                if (!int.TryParse(txtGiaThue.Text.Trim(), out var rentPrice) ||
                    !int.TryParse(txtArea.Text.Trim(), out var area))
                {
                    MyMessageBox.ShowError("Giá thuê và diện tích không được để trống hoặc sai định dạng.");
                    return;
                }

                var room = new Room(roomID, roomName, rentPrice, area, roomType);

                if (_isAdd)
                {
                    roomBUS.Insert(room);
                    MyMessageBox.ShowInformation("Thêm phòng thành công");
                }
                else
                {
                    roomBUS.Update(room);
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
