using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.Application.Contracts.Dto
{
    public class StockInOrderDto
    {
        ///<summary>
        ///
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int Type { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int? StoreId { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string SupplyId { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string SupplyName { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string OutRemark { get; set; }

        ///<summary>
        ///
        ///</summary>
        public bool IsPush { get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime? PredictDate { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string RefundOrder { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int ProcessStatus { get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime? PushDate { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Manager { get; set; }

        ///<summary>
        ///
        ///</summary>
        public long? ManagerId { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string OddNum { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string PurchasesNum { get; set; }

        ///<summary>
        ///
        ///</summary>
        public bool IsDeleted { get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime AddDate { get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime? UpdateDate { get; set; }

        ///<summary>
        ///
        ///</summary>
        public DateTime Timestamp { get; set; }

        ///<summary>
        ///
        ///</summary>
        public long? TenantId { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string InternalNo { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int Source { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string CustomData { get; set; }
    }
}
