using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLB.USSP.Core.Models
{
    [Table("TProdData")]
    public class TProdData
    {
        [Key,Column("F_PRODUCT")]
        public string FProduct { get; set; }

        [Column("F_DATA_CODE")]
        public string FDataCode { get; set; }

        [Column("F_DATA")]
        public string FData { get; set; }

        [Column("F_DATE_FOR_DATE_TYPES")]
        public DateTime FDateForDateTypes { get; set; }

        [Column("F_USER_UPDATED")]
        public string FUserUpdated { get; set; }

        [Column("F_DATE_STAMP")]
        public DateTime FDateStamp { get; set; }
    }
}
