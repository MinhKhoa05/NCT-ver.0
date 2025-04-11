using System.Collections.Generic;
using DAL.Repositories;
using DTO;

namespace BUS.Services
{
    public class TenantBUS : BaseBUS<Tenant>
    {
        protected override BaseDAL<Tenant> CreateDAL() => new TenantDAL();
        protected override string Prefix => "T";

        public override List<Tenant> Search(string keyword)
        {
            var list = GetAllFromTable();
            keyword = keyword?.ToLower() ?? string.Empty;

            return string.IsNullOrEmpty(keyword) ? list : list.FindAll(x =>
                (x.TenantID?.ToLower().Contains(keyword) ?? false) ||
                (x.FullName?.ToLower().Contains(keyword) ?? false) ||
                (x.PhoneNumber?.ToLower().Contains(keyword) ?? false) ||
                (x.Email?.ToLower().Contains(keyword) ?? false) ||
                (x.Address?.ToLower().Contains(keyword) ?? false) ||
                (x.NationalID?.ToLower().Contains(keyword) ?? false) ||
                (x.RoomID?.ToLower().Contains(keyword) ?? false)
            );
        }
    }
}