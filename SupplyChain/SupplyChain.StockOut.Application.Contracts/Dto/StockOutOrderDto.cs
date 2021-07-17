using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockOut.Application.Contracts.Dto
{
    public class StockOutOrderDto
    {
        public int Id { get; set; }


        public IEnumerable<StockOutOrderFlowDto> Flows { get; set; }
    }
}
