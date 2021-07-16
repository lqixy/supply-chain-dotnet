using Autofac;
using SupplyChain.Common;
using SupplyChain.Product.Application.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.Application
{
    public class SupplyChainProductApplicationAutofacModule
        : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductAppService>()
                .As<IProductAppService>()
                .InstancePerLifetimeScope();
            builder.RegisterModule(new SupplyChainCommonAutofacModule());
        }
    }
}
