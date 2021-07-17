using SupplyChain.StockOut.Domain.AggregateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockOut.Domain.IRepositories
{
    public interface IStockOutOrderRepository
    {
        Task<StockOutOrder> Get(int id);
    }
}
