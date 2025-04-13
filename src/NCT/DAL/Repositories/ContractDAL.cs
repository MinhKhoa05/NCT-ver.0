using DAL.Helpers;
using DTO;
using System;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public class ContractDAL : BaseDAL<Contract>
    {
        protected override string TableName => "RentalContract";
        protected override string IDColumn => "ContractID";

        public override void Insert(Contract contract)
        {
            string sql = $@"INSERT INTO {TableName} ({IDColumn}, TenantID, RoomID, StartDate, EndDate, RentPrice, DepositAmount, Note)
                VALUES (@{IDColumn}, @TenantID, @RoomID, @StartDate, @EndDate, @RentPrice, @DepositAmount, @Note)";

            Connector.ExecuteNonQuery(sql, contract);
        }

        public override void Update(Contract contract)
        {
            string sql = $@"UPDATE {TableName} SET
                TenantID = @TenantID,
                RoomID = @RoomID,
                StartDate = @StartDate,
                EndDate = @EndDate,
                RentPrice = @RentPrice,
                DepositAmount = @DepositAmount,
                Note = @Note
                WHERE {IDColumn} = @{IDColumn}";

            Connector.ExecuteNonQuery(sql, contract);
        }

        // Cập nhật phương thức Search để thực hiện tìm kiếm trong cơ sở dữ liệu
        public override List<Contract> Search(string keyword)
        {
            // Sử dụng câu truy vấn SQL với LIKE để tìm kiếm
            string sql = $@"SELECT * FROM {TableName} WHERE 
                (RoomID LIKE @Keyword) OR 
                (TenantID LIKE @Keyword) OR 
                (RentPrice LIKE @Keyword) OR 
                (Note LIKE @Keyword)";

            var parameters = new
            {
                Keyword = "%" + keyword.ToLower() + "%" // Sử dụng dấu % để tìm kiếm chứa từ khóa
            };

            // Thực hiện truy vấn và trả về kết quả
            return Connector.ExecuteQuery<Contract>(sql, parameters);
        }

        public int CountContractsInMonth(int year, int month)
        {
            string sql = $@"SELECT COUNT(*) FROM {TableName}
                    WHERE YEAR(StartDate) = @Year AND MONTH(StartDate) = @Month";

            var parameters = new { Year = year, Month = month };

            object result = Connector.ExecuteScalar(sql, parameters);
            return result != null ? Convert.ToInt32(result) : 0;
        }
    }
}
