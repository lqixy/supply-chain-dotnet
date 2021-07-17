using SupplyChain.StockIn.Application.Contracts.Dto;
using SupplyChain.StockIn.Application.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.Application.Services
{
    public class StockInAppService : IStockInAppService
    {
        public Task<StockInOrderDto> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
