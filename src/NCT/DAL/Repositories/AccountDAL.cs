using DAL.Helpers;
using DTO;

namespace DAL.Repositories
{
    public class AccountDAL
    {
        public AccountDAL() { }

        public Account Login(string username, string pass)
        {
            const string sql = "SELECT * FROM Account WHERE Username = @Username AND Pass = @Pass";
            return Connector.SelectOne<Account>(sql, new { Username = username, Pass = pass });
        }
    }
}
