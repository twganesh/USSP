using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORE.Models
{
    [Table("WSSE_RAD_DETAILS")]
    public class WsseRadDetails
    {        
        [Key, Column("ID")]
        public int Id { get; set; }

        [Column("MODEL_DESC")]
        public string ModelDesc { get; set; }

        [Column("SHIP_DESC")]
        public string ShipDesc { get; set; }

        [Column("RADIONUCLIDE")]
        public string Radionuclide { get; set; }

        [Column("TRANSPORT_INDEX")]
        public string TransportIndex { get; set; }

        [Column("PACKAGE_TYPE")]
        public string PackageType { get; set; }

        [Column("ACTIVITY")]
        public string Activity { get; set; }

        [Column("GROSS_WT")]
        public string GrossWt { get; set; }
    }
}
