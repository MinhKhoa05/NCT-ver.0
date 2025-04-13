using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class Account
    {
        public int AccountID { get; set; }

        [Required(ErrorMessage = "Tên tài khoản không được để trống")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string Pass { get; set; }

        public Account() { }

        public Account(string username, string pass)
        {
            Username = username;
            Pass = pass;
        }
    }
}
