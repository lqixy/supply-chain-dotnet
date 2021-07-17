using Autofac;
using SupplyChain.Product.Domain.IRepositories;
using SupplyChain.Product.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.EntityFrameworkCore
{
    public class SupplyChainProductEntityFrameworkCoreAutofacModule
        : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductRepository>()
                .As<IProductRepository>()
                .InstancePerLifetimeScope();
        }
    }
}
