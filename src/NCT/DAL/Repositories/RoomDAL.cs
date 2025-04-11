using DAL.Helpers;
using DTO;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class RoomDAL : BaseDAL<Room>
    {
        protected override string TableName => "Room";
        protected override string IDColumn => "RoomID";

        public override List<Room> GetAll()
        {
            string sql = $"SELECT * FROM {TableName} ORDER BY CreatedAt ASC";
            return Connector.ExecuteQuery<Room>(sql) ;
        }

        public override void Insert(Room room)
        {
            string sql = $@"INSERT INTO {TableName} ({IDColumn}, RoomName, RoomType, RentPrice, Area)
                VALUES (@{IDColumn}, @RoomName, @RoomType, @RentPrice, @Area)";

            Connector.ExecuteNonQuery(sql, room);
        }

        public override void Update(Room room)
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
