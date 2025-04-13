using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS.Services;
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

            if (!_isAdd)
            {
                contract = contractBUS.GetByID(contractId);
            }

            txtRentPrice.KeyPress += OnlyAllowDigits;
            txtTienCoc.KeyPress += OnlyAllowDigits;
        }

        private void frmContractInfo_Load(object sender, EventArgs e)
        {
            LoadCbTenant();
            LoadCbRoom();

            if (_isAdd)
            {
                txtContractID.Text = contractBUS.GenerateID();
                dtpStartDate.Value = DateTime.Today;
                dtpEndDate.Value = DateTime.Today.AddMonths(6); // Mặc định 6 tháng
            }
            else
            {
                LoadData();
            }
        }

        private void LoadCbTenant()
        {
            var tenants = tenantBUS.GetAll();
            var contracts = contractBUS.GetAll(); // Lấy tất cả hợp đồng

            // Lấy danh sách TenantID đã có hợp đồng
            var usedTenantIDs = new HashSet<string>();
            foreach (var c in contracts)
            {
                usedTenantIDs.Add(c.TenantID);
            }

            // Nếu đang cập nhật thì giữ lại Tenant hiện tại để không bị lọc mất
            string currentTenantID = contract?.TenantID;

            var availableTenants = tenants.FindAll(t =>
                string.IsNullOrEmpty(t.TenantID) ||
                !usedTenantIDs.Contains(t.TenantID) ||
                t.TenantID == currentTenantID
            );

            // Thêm dòng mặc định
            availableTenants.Insert(0, new Tenant
            {
                TenantID = string.Empty,
                FullName = "-- Chọn khách thuê --",
            });

            cbTenant.DataSource = availableTenants;
            cbTenant.DisplayMember = "FullName";
            cbTenant.ValueMember = "TenantID";
        }

        private void LoadCbRoom()
        {
            var rooms = roomBUS.GetAll();

            // Thêm dòng mặc định
            rooms.Insert(0, new Room
            {
                RoomID = "-- Chọn phòng --",
            });

            cbRoom.DataSource = rooms;
            cbRoom.DisplayMember = "RoomID";
            cbRoom.ValueMember = "RoomID";
        }

        private void LoadData()
        {
            if (contract != null)
            {
                txtContractID.Text = contract.ContractID;

                cbTenant.SelectedValue = contract.TenantID;
                cbRoom.SelectedValue = contract.RoomID;

                dtpStartDate.Value = contract.StartDate;
                dtpEndDate.Value = contract.EndDate;
                txtRentPrice.Text = contract.RentPrice.ToString("N0");
                txtTienCoc.Text = contract.DepositAmount.ToString("N0");
                txtNote.Text = contract.Note;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var contract = new Contract
                {
                    ContractID = txtContractID.Text.Trim(),
                    TenantID = cbTenant.SelectedValue?.ToString(),
                    RoomID = cbRoom.SelectedValue?.ToString(),
                    StartDate = dtpStartDate.Value,
                    EndDate = dtpEndDate.Value,
                    RentPrice = int.TryParse(txtRentPrice.Text.Replace(",", ""), out var rent) ? rent : 0,
                    DepositAmount = int.TryParse(txtTienCoc.Text.Replace(",", ""), out var deposit) ? deposit : 0,
                    Note = txtNote.Text.Trim()
                };

                if (_isAdd)
                {
                    contractBUS.Insert(contract);
                    MyMessageBox.ShowInformation("Thêm hợp đồng thành công");
                }
                else
                {
                    contractBUS.Update(contract);
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
            Room room = roomBUS.GetByID(cbRoom.SelectedValue?.ToString());
            if (room != null)
            {
                txtRentPrice.Text = room.RentPrice.ToString("N0");
                txtTienCoc.Text = (room.RentPrice * 2).ToString("N0"); // cọc mặc định 2 tháng
            }
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.MinDate = dtpStartDate.Value;
        }

        private void txtTienCoc_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTienCoc.Text.Replace(",", ""), out var value))
            {
                txtTienCoc.TextChanged -= txtTienCoc_TextChanged;
                txtTienCoc.Text = value.ToString("N0");
                txtTienCoc.SelectionStart = txtTienCoc.Text.Length;
                txtTienCoc.TextChanged += txtTienCoc_TextChanged;
            }
        }

        private void OnlyAllowDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
