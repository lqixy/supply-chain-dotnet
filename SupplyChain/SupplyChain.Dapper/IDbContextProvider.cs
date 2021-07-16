using SupplyChain.Dapper.DapperExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Dapper
{
    public interface IDbContextProvider<out TDbContext>
        where TDbContext : IDatabase
    {
        TDbContext GetDbContext();
    }
}
