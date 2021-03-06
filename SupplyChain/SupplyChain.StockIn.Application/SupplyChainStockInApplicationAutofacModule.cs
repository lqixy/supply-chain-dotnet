using Autofac;
using FluentValidation;
using SupplyChain.StockIn.Application.Contracts.Services;
using SupplyChain.StockIn.Application.Contracts.Validations;
using SupplyChain.StockIn.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.Application
{
    public class SupplyChainStockInApplicationAutofacModule
        : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StockInAppService>()
                .As<IStockInAppService>()
                .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(CreateStockInOrderCommandValidator).GetTypeInfo().Assembly)
                .Where(t => t.IsClosedTypeOf(typeof(IValidator<>)))
                .AsImplementedInterfaces();
        }
    }
}
