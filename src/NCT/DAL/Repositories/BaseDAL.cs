using DAL.Helpers;
using DTO;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public abstract class BaseDAL<T> where T : class, new()
    {
        // Tên bảng chính (override ở lớp con)
        protected abstract string TableName { get; }

        // Tên cột khóa chính (override ở lớp con)
        protected abstract string IDColumn { get; }

        #region Get Methods

        public virtual List<T> GetAll()
        {
            string sql = $"SELECT * FROM {TableName}";
            return Connector.ExecuteQuery<T>(sql);
        }

        public virtual T GetByID(string id)
        {
            string sql = $"SELECT * FROM {TableName} WHERE {IDColumn} = @ID";
            return Connector.SelectOne<T>(sql, new { ID = id });
        }

        public virtual string GetMaxID()
        {
            string sql = $"SELECT TOP 1 {IDColumn} FROM {TableName} ORDER BY {IDColumn} DESC";
            return Connector.ExecuteScalar(sql)?.ToString() ?? string.Empty;
        }

        #endregion

        #region Delete Methods

        public virtual void DeleteByID(string id)
        {
            string sql = $"DELETE FROM {TableName} WHERE {IDColumn} = @ID";
            Connector.ExecuteNonQuery(sql, new { ID = id });
        }

        #endregion

        #region Abstract Methods

        public abstract void Insert(T entity);
        public abstract void Update(T entity);
        public abstract List<T> Search(string keyword);

        #endregion
    }
}
