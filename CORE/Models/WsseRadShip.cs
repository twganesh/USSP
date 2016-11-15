using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLB.USSP.Core.Models
{
    [Table("WSSE_RAD_SHIP")]
    public class WsseRadShip
    {        
        [Key,Column("MODEL_NO")]
        public string ModelNo { get; set; }

        [Column("SERIAL_NO")]
        public string SerialNo { get; set; }

        [Column("SHIPID")]
        public int ShipId { get; set; }

        [Column("SORT_ORDER")]
        public int SortOrder { get; set; }

        [Column("CONFIG_ID")]
        public int ConfigId { get; set; }
    }
}
