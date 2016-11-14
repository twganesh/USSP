using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORE.DTO
{
    public class DTOWsseMatShip
    {
        public int Id { get; set; }
        
        public string Product { get; set; }

        public double WtVol { get; set; }

        public string WtVolUnit { get; set; }

        public string UpdateBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public int ShipId { get; set; }

        public int SortOrder { get; set; }

        public string Description { get; set; }

        public int DotShipId { get; set; }   

        public int DryBlend { get; set; }

        public double Concentration { get; set; }
    }
}
