using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLB.USSP.Core.DTO
{
    public class DTOWsseRadShip
    {        
        public string ModelNo { get; set; }

        public string SerialNo { get; set; }

        public int ShipId { get; set; }

        public int SortOrder { get; set; }

        public int ConfigId { get; set; }
    }
}
