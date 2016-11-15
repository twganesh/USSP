using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLB.USSP.Core.Models
{
    [Table("WSSE_DOT_SHIP")]
    public class WsseDotShip
    {
        [Key, Column("ID")]
        public int Id { get; set; }

        [Column("CAT")]
        public string Cat { get; set; }

        [Column("PRODUCT")]
        public string Product { get; set; }

        [Column("ACTUAL_QTY")]
        public double ActualQty { get; set; }

        [Column("ACTUAL_UNIT")]
        public string ActualUnit { get; set; }

        [Column("PACKTYPE")]
        public string PackType { get; set; }

        [Column("PACKNO")]
        public int PackNo { get; set; }

        [Column("SHIPID")]
        public int ShipId { get; set; }

        [Column("SORT")]
        public int Sort { get; set; }        

        [Column("UPDATE_BY")]
        public string UpdateBy { get; set; }

        [Column("UPDATE_DATE")]
        public DateTime UpdateDate { get; set; }

        [Column("BULKITEM")]
        public double BulkItem { get; set; }

        [Column("LOTNO")]
        public string LotNo { get; set; }

        [Column("TANKNO")]
        public string TankNo { get; set; }

        [Column("SLINGNO")]
        public string SlingNo { get; set; }

        [Column("SLINGDATE")]
        public DateTime SlingDate { get; set; }

        [Column("PACKLOC")]
        public string PackLoc { get; set; }

        [Column("RESIDUE")]
        public bool Residue { get; set; }

        [Column("ORDER_RELEASE_ID")]
        public string OrderReleaseId { get; set; }
    }
}
