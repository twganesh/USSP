using Service;
using ShippingPaper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShippingPaper.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShippingPaperProvider _shippingPaperProvider;

        public HomeController(IShippingPaperProvider shippingPaperProvider) : base()
        {
            _shippingPaperProvider = shippingPaperProvider;
        }
        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }
    }
}