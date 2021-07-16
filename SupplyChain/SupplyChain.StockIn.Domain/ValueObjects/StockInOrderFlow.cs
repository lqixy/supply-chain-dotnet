using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.StockIn.Domain.ValueObjects
{
    [Table("StorageInOrdersFlows")]
    public class StockInOrderFlow
    {
        ///<summary>
        ///
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int StorageInOrderId { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int ProcessStatus { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int BeforeProcessStatus { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Remark { get; set; }

        ///<summary>
        ///
        ///</summary>
        public decimal AvailableStock { get; set; }

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
    }
}
