using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Dapper;

namespace DAL.Helpers
{
    public sealed class DatabaseHelper
    {
        private static readonly Lazy<DatabaseHelper> _instance = new Lazy<DatabaseHelper>(() => new DatabaseHelper());
        private readonly string _connectionString;

        /// <summary>
        /// Khởi tạo DatabaseHelper
        /// </summary>
        private DatabaseHelper()
        {
            _connectionString = getConnectionString();
        }

        private string getConnectionString()
        {
            if (File.Exists("config.txt"))
            {
                StreamReader rd = new StreamReader("config.txt");
                string cn = rd.ReadLine();
                rd.Close();

                return cn;
            }
            else
            {
                throw new Exception($"Không tìm thấy file cấu hình");
            }
        }

        /// <summary>
        /// Singleton Instance
        /// </summary>
        public static DatabaseHelper Instance => _instance.Value;

        #region Core Execute Methods

        /// <summary>
        /// ExecuteNonQuery - Dùng cho INSERT, UPDATE, DELETE
        /// </summary>
        public int ExecuteNonQuery(string sql, object parameters = null)
        {
            using (IDbConnection cn = new SqlConnection(_connectionString))
            {
                return cn.Execute(sql, parameters);
            }
        }

        /// <summary>
        /// ExecuteScalar - Lấy giá trị đơn
        /// </summary>
        public T ExecuteScalar<T>(string sql, object parameters = null)
        {
            using (IDbConnection cn = new SqlConnection(_connectionString))
            {
                return cn.ExecuteScalar<T>(sql, parameters);
            }
        }

        /// <summary>
        /// ExecuteQuery - Trả về danh sách đối tượng
        /// </summary>
        public List<T> ExecuteQuery<T>(string sql, object parameters = null)
        {
            using (IDbConnection cn = new SqlConnection(_connectionString))
            {
                return cn.Query<T>(sql, parameters).AsList();
            }
        }

        /// <summary>
        /// ExecuteReader - Xử lý dữ liệu qua IDataReader
        /// </summary>
        public void ExecuteReader(string sql, object parameters, Action<IDataReader> handleData)
        {
            using (IDbConnection cn = new SqlConnection(_connectionString))
            {
                using (var reader = cn.ExecuteReader(sql, parameters))
                {
                    handleData(reader);
                }
            }
        }

        #endregion
    }
}