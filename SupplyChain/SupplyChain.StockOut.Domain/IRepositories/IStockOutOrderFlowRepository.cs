using SupplyChain.StockOut.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockOut.Domain.IRepositories
{
    public interface IStockOutOrderFlowRepository
    {
        Task<IEnumerable<StockOutOrderFlow>> Get(int stockOutOrderId);
    }
}
