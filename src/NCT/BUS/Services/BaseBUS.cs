using BUS.Helpers;
using DAL.Repositories;
using System;
using System.Collections.Generic;

namespace BUS.Services
{
    public abstract class BaseBUS<T> where T : class, new()
    {
        protected readonly BaseDAL<T> _baseDal;

        protected BaseBUS()
        {
            _baseDal = CreateDAL();
        }

        protected abstract BaseDAL<T> CreateDAL();

        // Tiền tố ID, ví dụ: "L", "T", "S", ...
        protected virtual string Prefix => string.Empty;

        // Sinh mã ID mới dạng Prefix + 00001
        public virtual string GenerateID()
        {
            string maxId = _baseDal.GetMaxID();
            int number = string.IsNullOrEmpty(maxId) ? 0 : int.Parse(maxId.Substring(Prefix.Length));
            return $"{Prefix}{number + 1:D5}";
        }

        // Dùng cho xử lý nghiệp vụ (mapping List<T>)
        public List<T> GetAllFromTable() => _baseDal.GetAll();

        public T GetByID(string id) => _baseDal.GetByID(id);
        public T GetByID(int id) => GetByID(id.ToString());

        public virtual void Insert(T entity)
        {
            if (!ValidatorHelper.TryValidateFirstError(entity, out var error))
                throw new Exception(error);

            _baseDal.Insert(entity);
        }

        public void Update(T entity)
        {
            if (!ValidatorHelper.TryValidateFirstError(entity, out var error))
                throw new Exception(error);

            _baseDal.Update(entity);
        }

        public void DeleteById(string id) => _baseDal.DeleteByID(id);
        public void DeleteById(int id) => DeleteById(id.ToString());

        public abstract List<T> Search(string keyword);
    }
}
