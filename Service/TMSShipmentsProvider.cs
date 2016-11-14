using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using OpenTMS = Service.OpenTMSServiceReference;
using ShipmentStopDetails = Service.ShipmentStopServiceReference;
using USSP.Models.DTO;

namespace USSP.Service
{
    public class TMSShipmentsProvider : ITMSShipmentProvider
    {



        public List<DTOOpenTMSShipments> getOpenTMSShipments(string TMSShipmentId)
        {
            //string resultXML = "Id is not valid";
            using(OpenTMS.PortTypeClient client = new OpenTMS.PortTypeClient())
            {
                try
                {

                    OpenTMS.Request req = new OpenTMS.Request();
                    req.TMSShipmentId = TMSShipmentId.ToString();
                    OpenTMS.WcShipmentServiceRequest request = new OpenTMS.WcShipmentServiceRequest(req);
                    var result = client.WcShipmentService(req);
                    OpenTMS.WcShipmentServiceResponse response = new OpenTMS.WcShipmentServiceResponse(result);
                    List<DTOOpenTMSShipments> lstDTO = new List<DTOOpenTMSShipments>();

                    foreach (var open in response.OpenTMSShipment)
                    {
                     
                        foreach (var stop in open.ShipmentStop)
                        {

                            DTOOpenTMSShipments dto = new DTOOpenTMSShipments();
                            dto.Id = open.Id;
                            dto.stopId = open.ShipmentStop[0].stopId.ToString();
                            dto.Source = open.ShipmentStop[0].Source;
                            dto.Destination = open.ShipmentStop[0].Destination;
                            dto.District = open.ShipmentStop[0].District;
                            dto.CreatedBy = open.ShipmentStop[0].CreatedBy;
                            lstDTO.Add(dto);


                        }                     

                    }

                     


                    return lstDTO;

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

          
        }


        public object GetShipmentStopDetails(string TMSShipmentId,string StopId)
        {
            //string resultXML = "Id is not valid";
            using (ShipmentStopDetails.PortType1Client client = new ShipmentStopDetails.PortType1Client())
            {
                try
                {
                    ShipmentStopDetails.Request req = new ShipmentStopDetails.Request();
                    req.ShipmentId = TMSShipmentId;
                    req.Stop = StopId;
                    ShipmentStopDetails.ODShipmentQryServiceRequest request = new ShipmentStopDetails.ODShipmentQryServiceRequest(req);
                    var result = client.ODShipmentQryService(req);
                    ShipmentStopDetails.ODShipmentQryServiceResponse response = new ShipmentStopDetails.ODShipmentQryServiceResponse(result);


                    return response;

                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }


        }
        //private string ToXML(object response)
        //{
        //    var stringwriter = new System.IO.StringWriter();
        //    var serializer = new XmlSerializer(response.GetType());
        //    serializer.Serialize(stringwriter, response);
        //    return stringwriter.ToString();
        //}

    }
}