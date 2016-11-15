using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLB.USSP.Core.DTO
{
    public class DTOWsseDotShip
    {
        public int Id { get; set; }

        public string Cat { get; set; }

        public string Product { get; set; }

        public double ActualQty { get; set; }

        public string ActualUnit { get; set; }

        public string PackType { get; set; }

        public int PackNo { get; set; }

        public int ShipId { get; set; }

        public int Sort { get; set; }        

        public string UpdateBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public double BulkItem { get; set; }

        public string LotNo { get; set; }

        public string TankNo { get; set; }

        public string SlingNo { get; set; }

        public DateTime SlingDate { get; set; }

        public string PackLoc { get; set; }

        public bool Residue { get; set; }

        public string OrderReleaseId { get; set; }
    }
}
