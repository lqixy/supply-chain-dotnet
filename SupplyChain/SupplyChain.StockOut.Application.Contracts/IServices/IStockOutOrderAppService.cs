using SupplyChain.StockOut.Application.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockOut.Application.Contracts.IServices
{
    public interface IStockOutOrderAppService
    {
        Task<StockOutOrderDto> Get(int id);
    }
}
