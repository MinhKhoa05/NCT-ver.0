using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class Contract
    {
        public string ContractID { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn Khách thuê")]
        public string TenantID { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn Phòng")]
        public string RoomID { get; set; }

        [Required(ErrorMessage = "Ngày bắt đầu là bắt buộc.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Thời hạn hợp đồng là bắt buộc.")]
        public DateTime EndDate { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Giá thuê phải là giá trị dương.")]
        public int RentPrice { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Số tiền cọc phải là giá trị dương.")]
        public int DepositAmount { get; set; }

        public DateTime DepositReturnDate { get; set; }

        [MaxLength(255, ErrorMessage = "Ghi chú không được vượt quá 255 ký tự.")]
        public string Note { get; set; }

        public Contract() { }

        public Contract(string contractID, string tenantID, string roomID,
                        DateTime startDate, DateTime endDate,
                        int rentPrice, int depositAmount,
                        DateTime depositReturnDate, string note)
        {
            ContractID = contractID;
            TenantID = tenantID;
            RoomID = roomID;
            StartDate = startDate;
            EndDate = endDate;
            RentPrice = rentPrice;
            DepositAmount = depositAmount;
            DepositReturnDate = depositReturnDate;
            Note = note;
        }
    }
}
