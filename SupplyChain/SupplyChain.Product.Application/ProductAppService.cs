using AutoMapper;
using SupplyChain.Product.Application.Contracts.Dto;
using SupplyChain.Product.Application.Contracts.Services;
using SupplyChain.Product.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.Application
{
    public class ProductAppService : SupplyChainAppServiceBase
        , IProductAppService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductAppService(IProductRepository productRepository
, IMapper mapper
            )
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<ProductInfoDto> Get(int id)
        {
            var result = await productRepository.Get(id);
            return mapper.Map<ProductInfoDto>(result);
        }
    }
}
