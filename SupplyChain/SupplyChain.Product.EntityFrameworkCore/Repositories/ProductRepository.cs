using Microsoft.EntityFrameworkCore;
using SupplyChain.Product.Domain.IRepositories;
using SupplyChain.Product.Domain.AggregateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.EntityFrameworkCore.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductEfDbContext context;

        public ProductRepository(ProductEfDbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<ProductInfo> Get(int id)
        {
            return await context.ProductInfos
                .FirstOrDefaultAsync(x => x.Id == id);
        } 
    }
}
