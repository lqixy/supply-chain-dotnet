using SupplyChain.Product.Application.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.Application.Contracts
{
    public interface IProductQueryAppService
    {
        Task<ProductOutput> Get(int id);

        
    }
}
