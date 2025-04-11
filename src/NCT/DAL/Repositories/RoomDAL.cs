using DAL.Helpers;
using DTO;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class RoomDAL : BaseDAL<RoomDTO>
    {
        protected override string TableName => "Room";
        protected override string IDColumn => "RoomID";

        public override List<RoomDTO> GetAll()
        {
            string sql = $"SELECT * FROM {TableName} ORDER BY CreatedAt ASC";
            return Connector.ExecuteQuery<RoomDTO>(sql) ;
        }

        public override void Insert(RoomDTO room)
        {
            string sql = $"INSERT INTO {TableName} ({IDColumn}, RoomName, RoomType, RentPrice, Area, Status) " +
                $"VALUES (@{IDColumn}, @RoomName, @RoomType, @RentPrice, @Area, @Status)";

            Connector.ExecuteNonQuery(sql, room);
        }

        public override void Update(RoomDTO room)
        {
            string sql = $@"UPDATE {TableName} SET
                RoomName = @RoomName,
                RoomType = @RoomType,
                RentPrice = @RentPrice,
                Area = @Area,
                Status = @Status
                WHERE {IDColumn} = @{IDColumn}";

            Connector.ExecuteNonQuery(sql, room);
        }

    }
}
