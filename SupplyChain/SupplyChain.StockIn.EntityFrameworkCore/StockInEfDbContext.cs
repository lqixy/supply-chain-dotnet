using Microsoft.EntityFrameworkCore;
using SupplyChain.EntityFrameworkCore;
using SupplyChain.StockIn.Domain.AggregateModel;
using SupplyChain.StockIn.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.EntityFrameworkCore
{
    public class StockInEfDbContext : DbContext // SupplyChainDbContextBase
    {
        public DbSet<StockInOrder> StockInOrders { get; set; }

        public DbSet<StockInOrderFlow> StockInOrderFlows { get; set; }


        public StockInEfDbContext(DbContextOptions<StockInEfDbContext> options) : base(options) { }
    }
}
