using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Domain.Uow
{
    public interface IConnectionStringResolver
    {
        string GetNameOrConnectionString(string name);
    }
}
