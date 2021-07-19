using Microsoft.AspNetCore.Mvc;
using SupplyChain.StockIn.Application.Contracts.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyChain.HttpApi.Controllers.StockIn
{
    [Route("api/stock-in-order")]
    [ApiController]
    public class StockInOrderController : ControllerBase
    {
        /// <summary>
        /// 创建入库单
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [Route("create"), HttpPost]
        public async Task<CreateStockInOrderCommand> Create([FromBody] CreateStockInOrderCommand command)
        {
            return command;
        }
    }
}
