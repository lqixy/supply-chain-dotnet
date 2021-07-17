using Microsoft.EntityFrameworkCore;
using SupplyChain.StockOut.Domain.AggregateModel;
using SupplyChain.StockOut.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockOut.EntityFrameworkCore.Repositories
{
    public class StockOutOrderRepository : IStockOutOrderRepository
    {
        private readonly StockOutOrderEfDbContext context;

        public StockOutOrderRepository(StockOutOrderEfDbContext context)
        {
            this.context = context;
        }

        public async Task<StockOutOrder> Get(int id)
        {
            return await context.StockOutOrders
                .FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
