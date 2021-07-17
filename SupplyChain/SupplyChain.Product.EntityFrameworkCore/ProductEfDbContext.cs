using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SupplyChain.EntityFrameworkCore;
using SupplyChain.Product.Domain.AggregateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.EntityFrameworkCore
{
    public class ProductEfDbContext : DbContext
        //: SupplyChainDbContextBase
    {
        //public DbSet<ProductInfo> ProductInfos { get; set; }

        public ProductEfDbContext(DbContextOptions<ProductEfDbContext> options) : base(options) { }



    }
}
