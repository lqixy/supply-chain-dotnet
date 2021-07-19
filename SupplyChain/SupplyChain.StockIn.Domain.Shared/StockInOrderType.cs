using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.Domain.Shared
{
    public enum StockInOrderType
    {
        /// <summary>
        /// 采购
        /// </summary>
        Purchase = 10,
        /// <summary>
        /// 退货
        /// </summary>
        ReturnGoods = 20,
        /// <summary>
        /// 搬仓
        /// </summary>
        MoveWarehouse = 30,
        /// <summary>
        /// 调拨
        /// </summary>
        Transfer = 40,
        /// <summary>
        /// 虚拟入库
        /// </summary>
        Hypothetical = 50,
        /// <summary>
        /// 库存调整
        /// </summary>
        Adjust = 60,

        /// <summary>
        /// 客户
        /// </summary>
        Customer = 70
    }
}
