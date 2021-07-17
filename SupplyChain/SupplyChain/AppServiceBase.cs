using SupplyChain.Common.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain
{
    public class AppServiceBase
    {
        public IObjectMapper ObjectMapper { get; } = NullObjectMapper.Instance;
    }
}
