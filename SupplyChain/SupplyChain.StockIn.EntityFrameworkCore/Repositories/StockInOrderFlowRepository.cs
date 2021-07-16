using Microsoft.EntityFrameworkCore;
using SupplyChain.StockIn.Domain.IRepositories;
using SupplyChain.StockIn.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.EntityFrameworkCore.Repositories
{
    public class StockInOrderFlowRepository : IStockInOrderFlowRepository
    {
        private readonly StockInEfDbContext context;

        public StockInOrderFlowRepository(StockInEfDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<StockInOrderFlow>> Get(int stockInOrderId)
        {
            return await context.StockInOrderFlows
                .AsNoTracking()
                .Where(x => x.StorageInOrderId == stockInOrderId)
                .ToListAsync();
        }
    }
}
