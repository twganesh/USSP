using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SLB.USSP.Service;

namespace SLB.USSP.Web.Controllers
{
    public class PickListViewModel
    {


    }


    public class PickListController : Controller
    {
        // GET: PickList

        private IPickListProvider _pickListProvider;

        public PickListController(IPickListProvider pickListProvider)
        {
            _pickListProvider = pickListProvider;
        }
        public ActionResult Index()
        {
            //OracleConnectionStringBuilder oraCSB = new OracleConnectionStringBuilder();
            //oraCSB.Direct = true;
            //oraCSB.Server = "nlxs1012.slb.atosorigin-asp.com";
            //oraCSB.Port = 1521;
            //oraCSB.Sid = "DGRC";
            //oraCSB.UserId = "WERCS";
            //oraCSB.Password = "Chem4all";
            //OracleConnection myConnection = new OracleConnection(oraCSB.ConnectionString);
            //myConnection.Open();

            //<add name="WERCS" providerName="Devart.Data.Oracle" connectionString="User Id=WERCS;Password=Chem4all;Server=nlxs1012.slb.atosorigin-asp.com;Direct=True;Service Name=QGRC;Port=1548;" />
            return View("PickListListing");
        }

        ///// <summary>
        ///// Method to bind to the Grid
        ///// </summary>
        ///// <param name="request"></param>
        ///// <returns></returns>
        //public ActionResult ReadPickList([DataSourceRequest] DataSourceRequest request)
        //{

        //    var list = _pickListProvider.GetPickLists();

        //    return Json(_pickListProvider.GetPickLists().ToDataSourceResult(request),JsonRequestBehavior.AllowGet);
        //}

        /// <summary>
        /// Method to Bind to List Type : ListBox
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public JsonResult GetPickListType()
        {
            var list = _pickListProvider.GetPickLists().Select(p => new { Type = p.Type, Value = p.Type });


            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}