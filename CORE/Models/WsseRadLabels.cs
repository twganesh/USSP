using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLB.USSP.Core.Models
{
    [Table("WSSE_RAD_LABELS")]
    public class WsseRadLabels
    {        
        [Key, Column("ID")]
        public int Id { get; set; }

        [Column("MODEL_DESC")]
        public string ModelDesc { get; set; }

        [Column("LABEL")]
        public string Label { get; set; }

        [Column("HAZ_TYPE")]
        public string HazType { get; set; }

        [Column("IMAGE_NAME")]
        public string ImageName { get; set; }
    }
}
