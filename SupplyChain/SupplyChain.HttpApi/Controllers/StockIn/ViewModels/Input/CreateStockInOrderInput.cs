using Microsoft.AspNetCore.Mvc;
using SupplyChain.StockIn.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupplyChain.HttpApi.Controllers.StockIn.ViewModels.Input
{
    /// <summary>
    /// 创建入库单
    /// </summary>
    public class CreateStockInOrderInput
    {
        /// <summary>
        /// 入库类型
        /// </summary>
        [ModelBinder(Name = "intype")]
        public StockInOrderType InType { get; set; }

        /// <summary>
        /// 仓库标识
        /// </summary>
        public int StoreId { get; set; }
        /// <summary>
        /// 入库单号
        /// </summary>
        [ModelBinder(Name = "oddnum")]
        public string StockInNum { get; set; }
        /// <summary>
        /// 操作人
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// 商户标识
        /// </summary>
        [ModelBinder(Name = "tenantinfoid")]
        public long TenantId { get; set; }
        /// <summary>
        /// 自定义json数据
        /// </summary>
        [ModelBinder(Name = "customdata")]
        public string CustomizeData { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<CreateInOrderProductItemInput> ProductItems { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [ModelBinder(Name = "append")]
        public CreateInOrderAppendItemInput AppendItem { get; set; }
    }
    /// <summary>
    /// 入库单商品信息
    /// </summary>
    public class CreateInOrderProductItemInput
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
        [ModelBinder(Name = "productname")]
        public string Name { get; set; }
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
    public class CreateInOrderAppendItemInput
    {
        /// <summary>
        /// 退货单号
        /// </summary>
        [ModelBinder(Name = "refundorder")]
        public string ReturnGoodsNum { get; set; }
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
        //[ModelBinder("remark")]
        public string Remark { get; set; }
        /// <summary>
        /// 采购单id
        /// </summary>
        //[ModelBinder("purchasesid")]
        public int PurchasesId { get; set; }
        ///// <summary>
        ///// 供应链内部订单号
        ///// </summary>
        //[ModelBinder("orderno")]
        //public string OrderNo { get; set; }
        /// <summary>
        /// 供应链内部订单号
        /// </summary>
        //[ModelBinder("internalNo")]
        public string InterNalNo { get; set; }

        /// <summary>
        /// 采购单ids---v2.8.0
        /// </summary>
        //[ModelBinder("purchaseids")]
        public string PurchaseIds { get; set; }


    }
}
