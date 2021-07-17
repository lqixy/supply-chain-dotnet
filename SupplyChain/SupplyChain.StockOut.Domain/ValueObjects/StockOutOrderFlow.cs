using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockOut.Domain.ValueObjects
{
    public class StockOutOrderFlow
    {
        public int Id { get; set; }

        public int StorageOutOrderId { get; set; }


    }
}
