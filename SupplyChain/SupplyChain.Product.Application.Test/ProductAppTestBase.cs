using Autofac;
using SupplyChain.Product.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.Application.Test
{
    public class ProductAppTestBase
    {
        protected IContainer Container { get; }

        public ProductAppTestBase()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<SupplyChainProductApplicationAutofacModule>();
            builder.RegisterModule<SupplyChainProductEntityFrameworkCoreAutofacModule>();

            Container = builder.Build(); 
        }
    }
}
