using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SLB.USSP.Core.DTO
{
    public class DTOWsseRadDetails
    {        
        public int Id { get; set; }

        public string ModelDesc { get; set; }

        public string ShipDesc { get; set; }

        public string Radionuclide { get; set; }

        public string TransportIndex { get; set; }

        public string PackageType { get; set; }

        public string Activity { get; set; }

        public string GrossWt { get; set; }
    }
}
