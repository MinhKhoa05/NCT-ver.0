using System;
using System.Collections.Generic;
using DAL.Repositories;
using DTO;

namespace BUS.Models
{
    public class RoomBUS : BaseBUS<Room>
    {
        protected override BaseDAL<Room> CreateDAL() => new RoomDAL();

        public override List<Room> Search(string keyword)
        {
            var list = GetAll();
            keyword = keyword?.ToLower() ?? string.Empty;

            return string.IsNullOrEmpty(keyword) ? list : list.FindAll(x =>
                (x.RoomID?.ToLower().Contains(keyword) ?? false) ||
                (x.RoomTypeValue?.ToLower().Contains(keyword) ?? false) ||
                x.RentPrice.ToString().Contains(keyword) ||
                x.Area.ToString().Contains(keyword) ||
                (x.StatusValue?.ToLower().Contains(keyword) ?? false) ||
                Convert.ToString(x.CreatedAt).ToLower().Contains(keyword)
            );
        }
    }
}