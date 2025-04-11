using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace DAL.Helpers
{
    public static class Connector
    {
        private static readonly string _connectionString =
            "Data Source=.;Initial Catalog=NCT;Integrated Security=True;Connection Timeout=2";

        private static DbConnection CreateConnection()
        {
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            return connection;
        }

        public static int ExecuteNonQuery(string sql, object parameters = null)
        {
            using (var conn = CreateConnection())
            {
                return conn.Execute(sql, parameters);
            }
        }

        public static object ExecuteScalar(string sql, object parameters = null)
        {
            using (var conn = CreateConnection())
            {
                return conn.ExecuteScalar(sql, parameters);
            }
        }

        public static T SelectOne<T>(string sql, object parameters = null)
        {
            using (var conn = CreateConnection())
            {
                return conn.QuerySingleOrDefault<T>(sql, parameters);
            }
        }

        public static List<T> ExecuteQuery<T>(string sql, object parameters = null)
        {
            using (var conn = CreateConnection())
            {
                return conn.Query<T>(sql, parameters).ToList();
            }
        }
    }
}
