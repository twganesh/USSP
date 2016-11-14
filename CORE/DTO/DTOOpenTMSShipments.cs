using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
namespace USSP.Models.DTO
{

    
    public class DTOOpenTMSShipments
    {
        public string Id { get; set; }
        public string stopId { get; set; }
        public string CreatedBy { get; set; }
        public string District { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }

      
    }
}
