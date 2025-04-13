using DAL.Helpers;
using DTO;

namespace DAL.Repositories
{
    public class ServiceDAL : BaseDAL<Service>
    {
        protected override string TableName => "Service";
        protected override string IDColumn => "ServiceID";

        public override void Insert(Service service)
        {
            string sql = $@"INSERT INTO {TableName} ({IDColumn}, ServiceName, ServiceType, UnitPrice, Unit)
            VALUES (@{IDColumn}, @ServiceName, @ServiceType, @UnitPrice, @Unit)";
            Connector.ExecuteNonQuery(sql, service);
        }

        public override void Update(Service service)
        {
            string sql = $@"UPDATE {TableName} SET
                ServiceName = @ServiceName,
                ServiceType = @ServiceType,
                UnitPrice = @UnitPrice,
                Unit = @Unit
                WHERE {IDColumn} = @{IDColumn}";

            Connector.ExecuteNonQuery(sql, service);
        }
    }
}
