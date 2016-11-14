using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORE.Models
{
    [Table("WSSE_TMS_PRODUCTS")]
    public class WsseTMSProducts
    {
        [Key,Column("PRODUCT_CODE")]
        public string ProductCode { get; set; }

        [Column("SHIPMENT_ID")]
        public string ShipmentId { get; set; }

        [Column("SOURCE")]
        public string Source { get; set; }

        [Column("DESTINATION")]
        public string Destination { get; set; }

        [Column("STOP_NUMBER")]
        public string StopNumber { get; set; }

        

        [Column("DATESTAMP")]
        public string DateStamp { get; set; }

        [Column("SHIPID")]
        public int ShipId { get; set; }

        [Column("ISDELETED")]
        public bool IsDeleted { get; set; }
    }
}
