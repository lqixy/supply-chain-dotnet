using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.EntityFrameworkCore
{
    public class SupplyChainDbContextBase : DbContext
    {
        public SupplyChainDbContextBase(DbContextOptions options) : base(options) { }
    }

}
