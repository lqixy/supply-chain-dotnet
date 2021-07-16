using Autofac;
using SupplyChain.StockIn.Domain.IRepositories;
using SupplyChain.StockIn.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.EntityFrameworkCore
{
    public class SupplyChainStockInEntityFrameworkCoreAutofacModule
        : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StockInOrderRepository>()
                .As<IStockInOrderRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<StockInOrderFlowRepository>()
                .As<IStockInOrderFlowRepository>()
                .InstancePerLifetimeScope();
             
        }
    }
}
