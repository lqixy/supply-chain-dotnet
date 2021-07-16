using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Domain.Uow
{
    public class SupplyChainConnectionStringResolver : DefaultConnectionStringResolver
    {
        private readonly IConfiguration configuration;

        public SupplyChainConnectionStringResolver(IConfiguration configuration)
        {
            this.configuration = configuration;
        }


    }
}
