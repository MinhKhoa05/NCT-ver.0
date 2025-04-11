using DAL.Repositories;
using DTO;

namespace BUS.Services
{
    public class RoomBUS : BaseBUS<RoomDTO>
    {
        protected override BaseDAL<RoomDTO> CreateDAL() => new RoomDAL();
    }
}