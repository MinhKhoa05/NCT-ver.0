using DAL.Helpers;
using DTO;

namespace DAL.Repositories
{
    public class TenantDAL : BaseDAL<Tenant>
    {
        protected override string TableName => "Tenant";
        protected override string IDColumn => "TenantID";

        public override void Insert(Tenant tenant)
        {
            string sql = $@"INSERT INTO {TableName} ({IDColumn}, FullName, PhoneNumber, Email, Address, NationalID, RoomID)
                VALUES (@{IDColumn}, @FullName, @PhoneNumber, @Email, @Address, @NationalID, @RoomID)";

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
                RoomID = @RoomID
                WHERE {IDColumn} = @{IDColumn}";

            Connector.ExecuteNonQuery(sql, tenant);
        }

    }
}
