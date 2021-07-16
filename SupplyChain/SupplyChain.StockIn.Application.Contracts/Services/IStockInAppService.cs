using SupplyChain.StockIn.Application.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.Application.Contracts.Services
{
    public interface IStockInAppService
    {
        Task<StockInOrderDto> Get(int id);
    }
}
