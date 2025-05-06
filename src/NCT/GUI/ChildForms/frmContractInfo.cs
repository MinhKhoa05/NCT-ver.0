using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS.Models;
using DTO;
using GUI.Helpers;

namespace GUI.ChildForms
{
    public partial class frmContractInfo : Form
    {
        private readonly bool _isAdd;
        private readonly Contract contract;
        private readonly ContractBUS contractBUS = new ContractBUS();
        private readonly RoomBUS roomBUS = new RoomBUS();
        private readonly TenantBUS tenantBUS = new TenantBUS();

        public frmContractInfo(bool isAdd, string contractId = null)
        {
            InitializeComponent();
            _isAdd = isAdd;
            if (!_isAdd) contract = contractBUS.GetByID(contractId);

            txtRentPrice.KeyPress += FormHelper.OnlyAllowDigits;
            txtRentPrice.TextChanged += txtRentPrice_TextChanged;
            txtTienCoc.KeyPress += FormHelper.OnlyAllowDigits;
            txtTienCoc.TextChanged += txtTienCoc_TextChanged;
        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTienCoc.Text.Replace(",", ""), out int value))
            {
                txtTienCoc.TextChanged -= txtTienCoc_TextChanged;
                txtTienCoc.Text = value.ToString("N0");
                txtTienCoc.SelectionStart = txtTienCoc.Text.Length;
                txtTienCoc.TextChanged += txtTienCoc_TextChanged;
            }
        }

        private void txtRentPrice_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtRentPrice.Text.Replace(",", ""), out int value))
            {
                txtRentPrice.TextChanged -= txtRentPrice_TextChanged;
                txtRentPrice.Text = value.ToString("N0");
                txtRentPrice.SelectionStart = txtRentPrice.Text.Length;
                txtRentPrice.TextChanged += txtRentPrice_TextChanged;
            }
        }

        private void frmContractInfo_Load(object sender, EventArgs e)
        {
            InitTenantComboBox();
            InitRoomComboBox();

            if (_isAdd)
            {
                txtContractID.Text = contractBUS.GenerateID();
                dtpStartDate.Value = DateTime.Today;
                dtpEndDate.Value = DateTime.Today.AddMonths(3); // hợp đồng 3 tháng
            }
            else
            {
                FillContractData();
            }
        }

        private void InitTenantComboBox()
        {
            var tenants = tenantBUS.GetAll();
            var usedTenantIDs = new HashSet<string>(contractBUS.GetAll().ConvertAll(c => c.TenantID));
            var currentTenantID = contract?.TenantID;

            var availableTenants = tenants.FindAll(t =>
                string.IsNullOrEmpty(t.TenantID) ||
                !usedTenantIDs.Contains(t.TenantID) ||
                t.TenantID == currentTenantID
            );

            if (_isAdd)
            {
                availableTenants.Insert(0, new Tenant { TenantID = "", FullName = "-- Chọn khách thuê --" });
            }

            cbTenant.DataSource = availableTenants;
            cbTenant.DisplayMember = "FullName";
            cbTenant.ValueMember = "TenantID";
        }

        private void InitRoomComboBox()
        {
            var rooms = roomBUS.GetAll();

            if (_isAdd)
            {
                rooms.Insert(0, new Room { RoomID = "-- Chọn phòng --" });
            }

            cbRoom.DataSource = rooms;
            cbRoom.DisplayMember = "RoomID";
            cbRoom.ValueMember = "RoomID";
        }

        private void FillContractData()
        {
            if (contract == null) return;

            txtContractID.Text = contract.ContractID;
            cbTenant.SelectedValue = contract.TenantID;
            cbRoom.SelectedValue = contract.RoomID;
            dtpStartDate.Value = contract.StartDate;
            dtpEndDate.Value = contract.EndDate;
            txtRentPrice.Text = contract.RentPrice.ToString("N0");
            txtTienCoc.Text = contract.DepositAmount.ToString("N0");
            txtNote.Text = contract.Note;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var newContract = new Contract
                {
                    ContractID = txtContractID.Text.Trim(),
                    TenantID = cbTenant.SelectedValue?.ToString(),
                    RoomID = cbRoom.SelectedValue?.ToString(),
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Value,
                    RentPrice = FormHelper.TryParseInt(txtRentPrice.Text),
                    DepositAmount = FormHelper.TryParseInt(txtTienCoc.Text),
                    Note = txtNote.Text.Trim()
                };

                if (_isAdd)
                {
                    contractBUS.Insert(newContract);
                    MyMessageBox.ShowInformation("Thêm hợp đồng thành công");
                }
                else
                {
                    contractBUS.Update(newContract);
                    MyMessageBox.ShowInformation("Đã cập nhật hợp đồng");
                }

                Close();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowError(ex.Message);
            }
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            var room = roomBUS.GetByID(cbRoom.SelectedValue?.ToString());
            if (room != null)
            {
                txtRentPrice.Text = room.RentPrice.ToString("N0");
                txtTienCoc.Text = (room.RentPrice * 2).ToString("N0");
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
            dtpEndDate.Value = dtpEndDate.MinDate.AddMonths(3); // hợp đồng 3 tháng
        }
    }
}
