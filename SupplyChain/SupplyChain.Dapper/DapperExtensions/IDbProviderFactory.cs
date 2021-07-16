using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Dapper.DapperExtensions
{
    public interface IDbProviderFactory
    {
        DbProviderFactory DbFactory { get; }

        string ConnectionString { get; }
    }
}
