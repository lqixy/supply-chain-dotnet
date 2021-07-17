using Autofac;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SupplyChain.Product.Application.Contracts.Services;
using SupplyChain.Product.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.Application.Test
{
    [TestClass]
    public class ProductAppServiceTest : ProductAppTestBase
    {
        //private readonly IProductRepository productRepository;
        private readonly IProductAppService productAppService;

        public ProductAppServiceTest()
        {
            //this.productRepository = Container.Resolve<IProductRepository>();
            productAppService = Container.Resolve<IProductAppService>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [TestMethod]
        public async Task When_Mock_Product_DB_Connection_Should_Ok()
        {
            var mock = new Mock<IProductAppService>();
            mock.Setup(x => x.Get(It.IsAny<int>()))
                .Returns(Task.FromResult(new Contracts.Dto.ProductInfoDto { Id = 1, ProductName = "mock" }));

            var result = mock.Object.Get(1).Result;

        }

        [TestMethod]
        public async Task When_Product_Repository()
        {
            //var result = await productRepository.Get(1);
            var result = await productAppService.Get(1);
        }



    }
}
