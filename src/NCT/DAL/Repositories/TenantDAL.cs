using DAL.Helpers;
using DTO;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class TenantDAL : BaseDAL<Tenant>
    {
        protected override string TableName => "Tenant";
        protected override string IDColumn => "TenantID";

        public override void Insert(Tenant tenant)
        {
            string sql = $@"INSERT INTO {TableName} ({IDColumn}, FullName, PhoneNumber, Email, Address, NationalID)
                VALUES (@{IDColumn}, @FullName, @PhoneNumber, @Email, @Address, @NationalID)";

            Connector.ExecuteNonQuery(sql, tenant);
        }

        public override void Update(Tenant tenant)
        {
            string sql = $@"UPDATE {TableName} SET
                FullName = @FullName,
                PhoneNumber = @PhoneNumber,
                Email = @Email,
                Address = @Address,
                NationalID = @NationalID,
                WHERE {IDColumn} = @{IDColumn}";

            Connector.ExecuteNonQuery(sql, tenant);
        }

        public override List<Tenant> Search(string keyword)
        {
            string sql = $@"SELECT * FROM {TableName} WHERE 
                LOWER({IDColumn}) LIKE @Keyword OR
                LOWER(FullName) LIKE @Keyword OR
                LOWER(PhoneNumber) LIKE @Keyword OR
                LOWER(Email) LIKE @Keyword OR
                LOWER(NationalID) LIKE @Keyword OR
                LOWER(Address) LIKE @Keyword OR
                LOWER(RoomID) LIKE @Keyword";

            var parameters = new
            {
                Keyword = "%" + keyword.ToLower() + "%"
            };

            return Connector.ExecuteQuery<Tenant>(sql, parameters);
        }
    }
}
