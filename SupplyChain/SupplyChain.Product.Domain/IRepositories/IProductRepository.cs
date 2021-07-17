using SupplyChain.Product.Domain.AggregateModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.Domain.IRepositories
{
    public interface IProductRepository
    {
        Task<ProductInfo> Get(int id);
    }
}
