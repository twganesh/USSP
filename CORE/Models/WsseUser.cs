using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORE.Models
{
    [Table("WSSE_USER")]
    public class WsseUser
    {
        [Key, Column("USERID")]
        public string UserId { get; set; }

        [Column("USERLEVEL")]
        public string UserLevel { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("UPDATE_BY")]
        public string UpdatedBy { get; set; }

        [Column("UPDATE_DATE")]
        public DateTime UpdateDate { get; set; }

        [Column("LOCKED")]
        public int Locked { get; set; }

        [Column("LOCATIONLDAP")]
        public string LocationLdap { get; set; }

        [Column("TRAINING_COMPLETE")]
        public DateTime TrainingComplete { get; set; }

        [Column("LASTLOGIN")]
        public DateTime LastLogin { get; set; }

        [Column("DELETED")]
        public bool Deleted { get; set; }

        [Column("DELETED_DATE")]
        public DateTime DeletedDate { get; set; }

        [Column("DELETED_BY")]
        public string DeletedBy { get; set; }
    }
}
