using SupplyChain.StockIn.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.Domain.IRepositories
{
    public interface IStockInOrderFlowRepository
    {
        Task<IEnumerable<StockInOrderFlow>> Get(int stockInOrderId);
    }
}
