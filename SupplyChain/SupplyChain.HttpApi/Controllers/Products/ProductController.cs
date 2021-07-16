using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SupplyChain.HttpApi.Controllers.Products.ViewModels.Outpus;
//using SupplyChain.ObjectMappings;
using SupplyChain.Product.Application.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyChain.HttpApi.Controllers.Products
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductAppService productAppService;
        private readonly IMapper mapper;
        public ProductController(IProductAppService productAppService
, IMapper mapper
            //, IObjectMapper objectMapper
            )
        {
            this.productAppService = productAppService;
            this.mapper = mapper;
            //this.objectMapper = objectMapper;
        }

        [HttpGet(@"{id}")]
        public async Task<ProductInfoOutput> Get(int id)
        {
            var result = await productAppService.Get(id);
            //return objectMapper.Map<ProductInfoOutput>(result);
            return mapper.Map<ProductInfoOutput>(result);
        }
    }
}
