using Autofac;
using AutoMapper;
using SupplyChain.Common.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IObjectMapper = SupplyChain.Common.Mappers.IObjectMapper;

namespace SupplyChain
{
    public class SupplyChainAutofacModule
        : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => new MapperConfiguration(cfg =>
             {
                 cfg.AddMaps(System.AppDomain.CurrentDomain.GetAssemblies());
             }))
                .AsSelf().SingleInstance();

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
                .As<IMapper>()
                .InstancePerLifetimeScope();

            builder.RegisterType<AutoMapperObjectMapper>()
                .As<IObjectMapper>()
                .InstancePerLifetimeScope();
        }
    }
}
