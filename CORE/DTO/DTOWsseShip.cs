using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.DTO
{
    public class DTOWsseShip
    {
        public int Id { get; set; }

        public string WellSite { get; set; }

        public string District { get; set; }

        public string Operator { get; set; }

        public DateTime ShipDate { get; set; }

        public string Treatment { get; set; }

        public string TruckNo { get; set; }

        public string TrailerNo { get; set; }

        public string Customer { get; set; }

        public string Location { get; set; }

        public string Well { get; set; }

        public string Instructions { get; set; }

        public string Exempt { get; set; }

        public string Safety { get; set; }

        public DateTime LoadDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string Supervisor { get; set; }

        public string UserId { get; set; }

        public string UpdateBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public double Version { get; set; }

        public string CreateBy { get; set; }

        public DateTime CreateDate { get; set; }

        public int LoadDiff { get; set; }

        public string TmpEdit { get; set; }

        public string CertSign { get; set; }

        public string LoadSign { get; set; }

        public bool Radioactive { get; set; }

        public bool Archived { get; set; }

        public int Colorado { get; set; }

        public string ShipmentId { get; set; }

        public string StopNumber { get; set; }

        public string Origin { get; set; }

        public string Destination { get; set; }

        public int NumOfProductsTMS { get; set; }
    }
}
