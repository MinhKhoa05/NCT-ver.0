using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class RoomDTO
    {
        [Required(ErrorMessage = "Mã phòng không được để trống")]
        [RegularExpression(@"^[A-Z]\d{4}$", ErrorMessage = "Mã phòng phải có định dạng A/B/C + 4 số")]
        public string RoomID { get; set; }

        public string RoomName { get; set; }

        [Required(ErrorMessage = "Loại phòng không được để trống")]
        public bool RoomType { get; set; }

        [Range(1000, 1_000_000_000, ErrorMessage = "Giá thuê phải từ 1.000 đến 1.000.000.000")]
        public int RentPrice { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Diện tích phải lớn hơn 0")]
        public int Area { get; set; }

        public bool Status { get; set; } = false;


        // Thuộc tính phụ hiển thị - Dapper tự động bỏ qua
        public string RoomTypeValue => RoomType ? "Vật dụng cơ bản" : "Phòng trống";

        public string StatusValue => Status ? "Đang thuê" : "Trống";
        public DateTime CreatedAt { get; set; }

        public RoomDTO() { }

        public RoomDTO(string roomID, string roomName, int rentPrice, int area, bool roomType = false, bool status = false)
        {
            RoomID = roomID;
            RoomName = roomName;
            RoomType = roomType;
            RentPrice = rentPrice;
            Area = area;
            Status = status;
        }
    }
}
