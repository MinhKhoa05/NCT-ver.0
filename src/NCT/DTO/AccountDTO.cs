namespace DTO
{
    public class AccountDTO
    {
        public int AccountID { get; private set; }
        public string UserName { get; private set; }
        public string PasswordHash { get; private set; }
        //public byte Role { get; private set; }
        //public bool IsActive { get; private set; }

        public AccountDTO(int accountID, string userName, string passwordHash)
        {
            AccountID = accountID;
            UserName = userName;
            PasswordHash = passwordHash;
            //Role = role;
            //IsActive = isActive;
        }
    }
}