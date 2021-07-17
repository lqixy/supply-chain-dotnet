using SupplyChain.Product.Domain.AggregateModel;
using SupplyChain.Product.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.EntityFrameworkCore.Repositories
{
    public class MockProductRepository //: IProductRepository
    {
        public Task<ProductInfo> Get(int id)
        {
            return Task.FromResult(new ProductInfo { Id = 0, ProductName = "Test" });
        }

    }
}
