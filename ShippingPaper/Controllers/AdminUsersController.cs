using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SLB.USSP.Web.Controllers
{
    public class AdminUsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
    }
}