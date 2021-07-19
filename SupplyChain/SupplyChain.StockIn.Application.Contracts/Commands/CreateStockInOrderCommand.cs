using Newtonsoft.Json;
using SupplyChain.StockIn.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.Application.Contracts.Commands
{
    public class CreateStockInOrderCommand
    {
        /// <summary>
        /// 入库类型
        /// </summary>
        //[JsonProperty("intype")]
        public StockInOrderType InType { get; set; }

        /// <summary>
        /// 仓库标识
        /// </summary>
        public int StoreId { get; set; }
        /// <summary>
        /// 入库单号
        /// </summary>
        //[JsonProperty("oddnum")]
        public string OddNum { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// 商户标识
        /// </summary>
        //[JsonProperty("tenantinfoid")]
        public long TenantInfoId { get; set; }
        /// <summary>
        /// 自定义json数据
        /// </summary>
        //[JsonProperty("customdata")]
        public string CustomData { get; set; }

        public IEnumerable<CreateInOrderProductItem> ProductItems { get; set; }
        /// <summary>
        /// 
        /// </summary>
        //[JsonProperty("append")]
        public CreateInOrderAppendItem Append { get; set; }
    }
    /// <summary>
    /// 入库单商品信息
    /// </summary>
    public class CreateInOrderProductItem
    {
        /// <summary>
        /// 条码
        /// </summary>
        public string SkuId { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public decimal Count { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        //[JsonProperty("productname")]
        public string ProductName { get; set; }
        /// <summary>
        /// 商品规格
        /// </summary>
        public string SpecpropInfo { get; set; }
        /// <summary>
        /// 采购单价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 批号
        /// </summary>
        public string BatchNo { get; set; }
    }

    /// <summary>
    /// 入库单追加信息
    /// </summary>
    public class CreateInOrderAppendItem
    {
        /// <summary>
        /// 退货单号
        /// </summary>
        //[JsonProperty("refundorder")]
        public string RetundOrder { get; set; }
        /// <summary>
        /// 到货时间 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public DateTime PreDictDate { get; set; }
        /// <summary>
        /// 供应商id
        /// </summary>
        public string SupplyId { get; set; }
        /// <summary>
        /// 供应商名称
        /// </summary>
        public string SupplyName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        //[JsonProperty("remark")]
        public string Remark { get; set; }
        /// <summary>
        /// 采购单id
        /// </summary>
        //[JsonProperty("purchasesid")]
        public int PurchasesId { get; set; }
        ///// <summary>
        ///// 供应链内部订单号
        ///// </summary>
        //[JsonProperty("orderno")]
        //public string OrderNo { get; set; }
        /// <summary>
        /// 供应链内部订单号
        /// </summary>
        //[JsonProperty("internalNo")]
        public string InterNalNo { get; set; }

        /// <summary>
        /// 采购单ids---v2.8.0
        /// </summary>
        //[JsonProperty("purchaseids")]
        public string PurchaseIds { get; set; }


    }
}
