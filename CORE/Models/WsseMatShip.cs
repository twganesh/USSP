using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORE.Models
{
    [Table("WSSE_MAT_SHIP")]
    public class WsseMatShip
    {
        [Key, Column("ID")]
        public int Id { get; set; }
        
        [Column("PRODUCT")]
        public string Product { get; set; }

        [Column("WT_VOL")]
        public double WtVol { get; set; }

        [Column("WT_VOL_UNIT")]
        public string WtVolUnit { get; set; }

        [Column("UPDATE_BY")]
        public string UpdateBy { get; set; }

        [Column("UPDATE_DATE")]
        public DateTime UpdateDate { get; set; }

        [Column("SHIPID")]
        public int ShipId { get; set; }

        [Column("SORTORDER")]
        public int SortOrder { get; set; }

        [Column("DESCRIPTION")]
        public string Description { get; set; }

        [Column("DOT_SHIPID")]
        public int DotShipId { get; set; }   

        [Column("DRY_BLEND")]
        public int DryBlend { get; set; }

        [Column("CONCENTRATION")]
        public double Concentration { get; set; }
    }
}
