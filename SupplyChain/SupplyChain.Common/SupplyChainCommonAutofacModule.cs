using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Common
{
    public class SupplyChainCommonAutofacModule
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

            //builder.RegisterType<MapperConfiguration>()
            //    .As<IConfigurationProvider>()
            //    .InstancePerLifetimeScope();

            //builder.RegisterType<ObjectMappings.IObjectMapper>()
            //    .As<AutoMapper.AutoMapper>()
            //    .InstancePerLifetimeScope();
        }
    }
}
