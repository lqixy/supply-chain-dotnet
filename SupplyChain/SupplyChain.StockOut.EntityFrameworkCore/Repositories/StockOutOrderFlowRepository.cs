using Microsoft.EntityFrameworkCore;
using SupplyChain.StockOut.Domain.IRepositories;
using SupplyChain.StockOut.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockOut.EntityFrameworkCore.Repositories
{
    public class StockOutOrderFlowRepository : IStockOutOrderFlowRepository
    {
        private readonly StockOutOrderEfDbContext context;

        public StockOutOrderFlowRepository(StockOutOrderEfDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<StockOutOrderFlow>> Get(int stockOutOrderId)
        {
            return await context.StockOutOrderFlows
               .AsNoTracking()
               .Where(x => x.StorageOutOrderId == stockOutOrderId)
               .ToListAsync()
               ;
        }
    }
}
