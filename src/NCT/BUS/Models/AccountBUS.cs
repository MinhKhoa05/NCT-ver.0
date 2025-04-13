using BUS.Helpers;
using DTO;
using DAL.Repositories;
using System;

namespace BUS.Models
{
    public class AccountBUS
    {
        private readonly AccountDAL accountDAL;

        public AccountBUS()
        {
            accountDAL = new AccountDAL();
        }

        public Account Login(string username, string password)
        {
            Account account = new Account(username, password);

            if (!ValidatorHelper.TryValidateFirstError(account, out var error))
                throw new Exception(error);

            account = accountDAL.Login(username, password);
            
            if (account == null) throw new Exception("Sai tên tài khoản hoặc mật khẩu");

            return account;
        }
    }
}
