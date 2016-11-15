using System;
using System.Web.Mvc;

using System.Collections.Generic;
using SLB.USSP.Service;

namespace SLB.USSP.Web.Controllers
{
    public class OpenTMSShipmentsController : Controller
    {
        // GET: OpenTMSShipments

        private  ITMSShipmentProvider _tmsProvider;

        public OpenTMSShipmentsController(ITMSShipmentProvider tmsProvider)
        {
            _tmsProvider = tmsProvider;
        }
        public ActionResult Index()
        {

            try
            {
             

                var shipdetails = _tmsProvider.GetShipmentStopDetails("61502","1");
                return View();
                
            }

            catch (Exception ex)
            {

                throw ex ;
            }
          
            
           
        }

        //public ActionResult ReadList([DataSourceRequest] DataSourceRequest request)
        //{

        //    List<DTOOpenTMSShipments> openTMSShipments = _tmsProvider.getOpenTMSShipments("");

        //    return Json(openTMSShipments, JsonRequestBehavior.AllowGet);
        //}



    }
}