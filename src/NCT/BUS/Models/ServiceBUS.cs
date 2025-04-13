using DAL.Repositories;
using DTO;

namespace BUS.Models
{
    public class ServiceBUS : BaseBUS<Service>
    {
        protected override BaseDAL<Service> CreateDAL() => new ServiceDAL();
     
        protected override string Prefix => "S";
    }
}