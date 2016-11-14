using System.ComponentModel.DataAnnotations.Schema;

namespace CORE.DTO
{
    public class DTOWsseTMSProducts
    {
        public string ShipmentId { get; set; }

        public string Source { get; set; }

        public string Destination { get; set; }

        public string StopNumber { get; set; }

        public string ProductCode { get; set; }

        public string DateStamp { get; set; }

        public int ShipId { get; set; }

        public bool IsDeleted { get; set; }
    }
}
