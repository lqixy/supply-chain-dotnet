using SupplyChain.Product.Application.Contracts;
using SupplyChain.Product.Application.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.Application
{
    public class ProductQueryAppService : IProductQueryAppService
    {
        public async Task<ProductOutput> Get(int id)
        {
            return new ProductOutput { Id = id, Name = $"名称:{id}" };
        }
    }
}
