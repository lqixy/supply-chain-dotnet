using Microsoft.AspNetCore.Mvc;
using SupplyChain.Product.Application.Contracts;
using SupplyChain.Product.Application.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyChain.API.Controllers.Products
{
    [Route("api/product")]
    public class ProductController : ControllerBase
    {

        private readonly IProductQueryAppService productQueryAppService;

        public ProductController(IProductQueryAppService productQueryAppService)
        {
            this.productQueryAppService = productQueryAppService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("/{id}")]
        public async Task<ProductOutput> Get(int id)
        {
            return await productQueryAppService.Get(id);
        }
    }
}
