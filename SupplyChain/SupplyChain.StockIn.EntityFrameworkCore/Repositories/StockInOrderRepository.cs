using Microsoft.EntityFrameworkCore;
using SupplyChain.StockIn.Domain.AggregateModel;
using SupplyChain.StockIn.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.EntityFrameworkCore.Repositories
{
    public class StockInOrderRepository : IStockInOrderRepository
    {
        private readonly StockInEfDbContext context;

        public StockInOrderRepository(StockInEfDbContext context)
        {
            this.context = context;
        }

        public async Task<StockInOrder> Get(int id)
        {
            return await context.StockInOrders
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
