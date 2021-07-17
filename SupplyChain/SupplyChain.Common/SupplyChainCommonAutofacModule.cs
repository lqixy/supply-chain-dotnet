using Autofac; 

namespace SupplyChain.Common
{
    public class SupplyChainCommonAutofacModule
        : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.Register(c => new MapperConfiguration(cfg =>
            // {
            //     cfg.AddMaps(System.AppDomain.CurrentDomain.GetAssemblies());
            // }))
            //    .AsSelf().SingleInstance();

            //builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve))
            //    .As<IMapper>()
            //    .InstancePerLifetimeScope();
              
        }
    }
}
