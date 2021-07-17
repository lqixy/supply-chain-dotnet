using SupplyChain.StockIn.Domain.AggregateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.Domain.IRepositories
{
    public interface IStockInOrderRepository
    {
        Task<StockInOrder> Get(int id);
    }
}
