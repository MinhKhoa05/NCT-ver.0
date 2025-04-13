using System.Collections.Generic;
using DAL.Repositories;
using DTO;

namespace BUS.Services
{
    public class TenantBUS : BaseBUS<Tenant>
    {
        protected override BaseDAL<Tenant> CreateDAL() => new TenantDAL();
        protected override string Prefix => "T";
    }
}