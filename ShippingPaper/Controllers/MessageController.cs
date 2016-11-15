using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLB.USSP.Web.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Index()
        {
            ViewBag.Message = "Hello";
            return PartialView("_MessagePopup");
        }
    }
}