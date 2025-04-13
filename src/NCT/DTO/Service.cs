using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class Service
    {
        public string ServiceID { get; set; }

        [Required(ErrorMessage = "Tên dịch vụ không được để trống")]
        [StringLength(30, ErrorMessage = "Tên dịch vụ không được vượt quá 30 ký tự")]
        public string ServiceName { get; set; }

        public bool ServiceType { get; set; } // true = định kỳ, false = phát sinh
        public string Type => ServiceType ? "Định kỳ" : "Phát sinh";
        

        [Required(ErrorMessage = "Đơn giá không được để trống")]
        [Range(0, int.MaxValue, ErrorMessage = "Đơn giá phải lớn hơn hoặc bằng 0")]
        public int UnitPrice { get; set; }

        [Required(ErrorMessage = "Đơn vị tính không được để trống")]
        [StringLength(15, ErrorMessage = "Đơn vị tính không được vượt quá 15 ký tự")]
        public string Unit { get; set; }

        public Service() { }

        public Service(string serviceID, string serviceName, bool servicetype, int unitPrice, string unit)
        {
            ServiceID = serviceID;
            ServiceName = serviceName;
            ServiceType = servicetype;
            UnitPrice = unitPrice;
            Unit = unit;
        }
    }
}