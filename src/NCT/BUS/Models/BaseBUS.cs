using BUS.Helpers;
using DAL.Repositories;
using System;
using System.Collections.Generic;

namespace BUS.Models
{
    public abstract class BaseBUS<T> where T : class, new()
    {
        protected readonly BaseDAL<T> _baseDAL;
        
        protected BaseBUS()
        {
            _baseDAL = CreateDAL();
        }

        protected abstract BaseDAL<T> CreateDAL();

        // Tiền tố ID, ví dụ: "L", "T", "S", ...
        protected virtual string Prefix => string.Empty;

        // Sinh mã ID mới dạng Prefix + 00001
        public virtual string GenerateID()
        {
            string maxId = _baseDAL.GetMaxID();
            int number = string.IsNullOrEmpty(maxId) ? 0 : int.Parse(maxId.Substring(Prefix.Length));
            return $"{Prefix}{number + 1:D5}";
        }

        // Dùng cho xử lý nghiệp vụ (mapping List<T>)
        public List<T> GetAll() => _baseDAL.GetAll();
        
        public T GetByID(string id) => _baseDAL.GetByID(id);
        public T GetByID(int id) => GetByID(id.ToString());

        public virtual void Insert(T entity)
        {
            if (ValidDate(entity)) _baseDAL.Insert(entity);
        }

        public void Update(T entity)
        {
            if (ValidDate(entity)) _baseDAL.Update(entity);
        }

        public void DeleteById(string id) => _baseDAL.DeleteByID(id);
        public void DeleteById(int id) => DeleteById(id.ToString());

        public virtual List<T> Search(string keyword) => _baseDAL.Search(keyword);

        private bool ValidDate(T entity)
        {
            if (!ValidatorHelper.TryValidateFirstError(entity, out var error))
                throw new Exception(error);

            return true;
        }
    }
}
