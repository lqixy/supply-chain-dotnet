using Microsoft.EntityFrameworkCore;
using SupplyChain.Product.Domain.AggregatesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.Infrastructure
{
    public class ProductDbContext : DbContext
    {
        public DbSet<ProductInfo> ProductInfos { get; set; }


        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
    }
}
