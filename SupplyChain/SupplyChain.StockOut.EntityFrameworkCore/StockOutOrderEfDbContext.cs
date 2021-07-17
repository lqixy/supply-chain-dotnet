using Microsoft.EntityFrameworkCore;
using SupplyChain.StockOut.Domain.AggregateModel;
using SupplyChain.StockOut.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockOut.EntityFrameworkCore
{
    public class StockOutOrderEfDbContext : DbContext
    {

        public DbSet<StockOutOrder> StockOutOrders { get; set; }

        public DbSet<StockOutOrderFlow> StockOutOrderFlows { get; set; }

        public StockOutOrderEfDbContext(DbContextOptions<StockOutOrderEfDbContext> options) : base(options)
        {
        }
    }
}
