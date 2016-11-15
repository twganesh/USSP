using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLB.USSP.Core.DTO
{
    public class DTOWsseRadConfig
    {        
        public int Id { get; set; }

        public string Name { get; set; }

        public int DisableAll { get; set; }

        public string Include { get; set; }

        public int SortOrder { get; set; }
    }
}
