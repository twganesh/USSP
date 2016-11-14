using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USSP.Models.DTO;

namespace USSP.Service
{
   public interface ITMSShipmentProvider
    {
        List<DTOOpenTMSShipments> getOpenTMSShipments(string TMSShipmentId);

        object GetShipmentStopDetails(string TMSShipmentId,string StopId);

    }
}
