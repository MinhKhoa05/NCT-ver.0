using DAL.Repositories;
using DTO;

namespace BUS.Services
{
    public class ServiceBUS : BaseBUS<Service>
    {
        protected override BaseDAL<Service> CreateDAL() => new ServiceDAL();
     
        protected override string Prefix => "S";
    }
}