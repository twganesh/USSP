using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SLB.USSP.Core.Models
{
    [Table("WSSE_PICKLISTS")]
    public class PickList
    {
        [Column("VALUE", Order =1)]
        [StringLength(50)]
        public string Value { get; set; }

        [Column("SORTORDER", Order = 2)]        
        public int SortOrder { get; set; }
      
        [Column("ID", Order = 3)]
        [Required]
        public int Id { get; set; }

        [Column("TYPE", Order = 4)]
        [StringLength(20)]
        public string Type { get; set; }

    }
}