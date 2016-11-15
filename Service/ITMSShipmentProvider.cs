using System.Collections.Generic;
using SLB.USSP.Core.DTO;

namespace SLB.USSP.Service
{
    public interface ITMSShipmentProvider
    {
        List<DTOOpenTMSShipments> getOpenTMSShipments(string TMSShipmentId);

        object GetShipmentStopDetails(string TMSShipmentId,string StopId);

    }
}
