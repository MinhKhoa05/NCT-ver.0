using System;
using DAL.Repositories;
using DTO;

namespace BUS.Models
{
    public class ContractBUS : BaseBUS<Contract>
    {
        protected override BaseDAL<Contract> CreateDAL() => new ContractDAL();

        public override string GenerateID()
        {
            var now = DateTime.Now;
            string prefix = "HD" + now.ToString("yyyyMM"); // HD202504

            int count = ((ContractDAL)_baseDAL).CountContractsInMonth(now.Year, now.Month);
            int nextNumber = count + 1;

            return prefix + nextNumber.ToString("D3"); // HD202504001
        }
    }
}