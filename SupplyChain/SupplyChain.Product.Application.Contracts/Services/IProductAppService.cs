using SupplyChain.Product.Application.Contracts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.Application.Contracts.Services
{
    public interface IProductAppService
    {
        Task<ProductInfoDto> Get(int id);
    }
}
