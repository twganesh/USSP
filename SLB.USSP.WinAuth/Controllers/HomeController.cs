using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SLB.USSP.Core;
using SLB.USSP.WinAuth.ViewModel;

namespace SLB.USSP.WinAuth.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
            : base()
        { }

        [HttpGet]
        public ActionResult GetAuthTicket()
        {
            string userName = null;
            if (User.Identity != null && !User.Identity.Name.IsNullOrEmpty() && !User.Identity.Name.IsNullOrWhiteSpace())
            {
                userName = User.Identity.Name.Split("\\".ToCharArray())[1];
            }

            return new JsonpResult
            {
                Data = userName,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet,
            };
        }
    }
}