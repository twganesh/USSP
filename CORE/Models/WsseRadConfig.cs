using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLB.USSP.Core.Models
{
    [Table("WSSE_RAD_CONFIG")]
    public class WsseRadConfig
    {        
        [Key, Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("DISABLE_ALL")]
        public int DisableAll { get; set; }

        [Column("INCLUDE")]
        public string Include { get; set; }

        [Column("SORT_ORDER")]
        public int SortOrder { get; set; }
    }
}
