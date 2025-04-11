using DAL.Repositories;
using DTO;

namespace BUS.Services
{
    public class TenantBUS : BaseBUS<TenantDTO>
    {
        protected override BaseDAL<TenantDTO> CreateDAL() => new TenantDAL();
        protected override string Prefix => "T";
    }
}