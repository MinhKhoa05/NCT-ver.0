using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class Tenant
    {
        public string TenantID { get; set; }

        [Required(ErrorMessage = "Họ tên không được để trống")]
        [StringLength(30, ErrorMessage = "Họ tên tối đa 30 ký tự")]
        public string FullName { get; set; }

        [MinLength(10, ErrorMessage = "Số điện thoại phải có ít nhất 10 ký tự")]
        [StringLength(20, ErrorMessage = "Số điện thoại tối đa 20 ký tự")]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        [StringLength(100, ErrorMessage = "Email tối đa 100 ký tự")]
        public string Email { get; set; }

        [StringLength(255, ErrorMessage = "Địa chỉ tối đa 255 ký tự")]
        public string Address { get; set; }

        [RegularExpression(@"^\d{12}$", ErrorMessage = "CCCD phải gồm đúng 12 chữ số")]
        [StringLength(12, ErrorMessage = "CCCD phải gồm đúng 12 ký tự")]
        public string NationalID { get; set; }

        [RegularExpression(@"^[A-Z]\d{4}$", ErrorMessage = "Mã phòng phải có định dạng A/B/C + 4 số")]
        public string RoomID { get; set; }

        public Tenant() { }

        public Tenant(string tenantID, string fullName, string phoneNumber, string email = null, string address = null, string nationalID = null, string roomID = null)
        {
            TenantID = tenantID;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            NationalID = nationalID;
            RoomID = roomID;
        }
    }
}
