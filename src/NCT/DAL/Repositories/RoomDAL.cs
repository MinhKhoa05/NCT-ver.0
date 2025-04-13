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
            return Connector.ExecuteQuery<Room>(sql);
        }

        public override void Insert(Room room)
        {
            string sql = $@"INSERT INTO {TableName} ({IDColumn}, RoomType, RentPrice, Area)
                VALUES (@{IDColumn}, @RoomType, @RentPrice, @Area)";
            Connector.ExecuteNonQuery(sql, room);
        }

        public override void Update(Room room)
        {
            string sql = $@"UPDATE {TableName} SET
                RoomType = @RoomType,
                RentPrice = @RentPrice,
                Area = @Area,
                WHERE {IDColumn} = @{IDColumn}";
            Connector.ExecuteNonQuery(sql, room);
        }

        public override List<Room> Search(string keyword)
        {
            string sql = $@"SELECT * FROM {TableName} WHERE 
                LOWER(RoomID) LIKE @Keyword OR
                LOWER(RoomType) LIKE @Keyword OR
                CAST(RentPrice AS VARCHAR) LIKE @Keyword OR
                CAST(Area AS VARCHAR) LIKE @Keyword OR
                LOWER(Status) LIKE @Keyword";

            var parameters = new
            {
                Keyword = "%" + keyword.ToLower() + "%"
            };

            return Connector.ExecuteQuery<Room>(sql, parameters);
        }
    }
}
