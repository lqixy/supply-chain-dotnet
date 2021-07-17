using Autofac;
using Microsoft.Extensions.DependencyInjection;
using SupplyChain.Dependencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain
{
    public class TestBase<TModule>
        where TModule : BaseModule
    {
        protected IContainer Container { get; }
        public TestBase()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyModules<TModule>();

            Container = builder.Build();
        }
    }
}
