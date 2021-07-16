using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupplyChain.Product.Application.Contracts.Dto
{
    public class ProductInfoDto
    {
        ///<summary>
        ///
        ///</summary>
        public int Id { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int DicCategoryId { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string ProductName { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string ProductBarCode { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int ProductBrandId { get; set; }

        ///<summary>
        ///
        ///</summary>
        public bool IsEnable { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int TradeMode { get; set; }

        ///<summary>
        ///
        ///</summary>
        public decimal TotalInventory { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string SKUID { get; set; }

        ///<summary>
        ///
        ///</summary>
        public decimal? InventoryWarning { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int? ExpiryDate { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int? Unit { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string UnitName { get; set; }

        ///<summary>
        ///
        ///</summary>
        public decimal? Suttle { get; set; }

        ///<summary>
        ///
        ///</summary>
        public decimal? Rough { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string ProductTitle { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int TitleType { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string ProductSpecpropText { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int PackType { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string PackTypeName { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Source { get; set; }

        ///<summary>
        ///
        ///</summary>
        public long PID { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string PIDPrefix { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string PIDGroupIdentity { get; set; }

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
        public decimal? ReferencePrice { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int? ExpirationDate { get; set; }

        ///<summary>
        ///
        ///</summary>
        public int? IsExpirationDate { get; set; }

        ///<summary>
        ///
        ///</summary>
        public byte MaintainStatus { get; set; }

        ///<summary>
        ///
        ///</summary>
        public decimal? RetailMin { get; set; }

        ///<summary>
        ///
        ///</summary>
        public decimal? RetailMax { get; set; }

        ///<summary>
        ///
        ///</summary>
        public string Volume { get; set; }
    }
}
