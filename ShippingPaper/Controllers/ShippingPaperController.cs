using Service;
using ShippingPaper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CORE;


namespace ShippingPaper.Controllers
{
    public class ShippingPaperController : USSPController
    {
        private readonly IShippingPaperProvider _shippingPaperProvider;

        public ShippingPaperController(IShippingPaperProvider shippingPaperProvider) : base()
        {
            _shippingPaperProvider = shippingPaperProvider;
        }

        // GET: ShippingPaper
        public ActionResult Index()
        {

            ViewBag.CreatedByOptions = _shippingPaperProvider.GetAllUsers();
            ViewBag.WellSiteOptions = (new string[] { "Well Site 1", "Well Site 2", "Well Site 3" }).ToList();
            ViewBag.DistrictOptions = (new string[] { "Distirct 1", "Distirct 2", "Distirct 3" }).ToList();
            ViewBag.FilterTypesOptions = (new string[] { "And", "Between", "Or" }).ToList();
            return View();
        }

        public ActionResult GetAllUsers()
        {
            var users = _shippingPaperProvider.GetAllUsers();
            return Json(users, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Search(ShippingPaperFilterViewModel filters, GridResultViewModel<ShippingPaperViewModel> gridOptions)
        {
            GridResultViewModel<ShippingPaperViewModel> model = new GridResultViewModel<ShippingPaperViewModel>();
            var data = new List<ShippingPaperViewModel>();
            for (int i = 0; i < 100; i++)
            {
                var j = i + 1;
                data.Add(new Models.ShippingPaperViewModel { Id = j, Origin = "Origin " + j, ShipmentId = "Ship Id " + j, StopNo = "Stop " + j, Destination = "Destination " + j, CreatedBy = "Test " + j, CreateDate = DateTime.Now.AddMinutes(j) });

            }

            if(gridOptions != null)
            {
                if(gridOptions.SortBy != string.Empty)
                {
                    if(gridOptions.SortDirection == Enums.SortDirection.Ascending.ToString())
                    {
                        data = data.AsQueryable().OrderBy(gridOptions.SortBy).ToList();
                    }
                    else
                    {
                        data = data.AsQueryable().OrderByDescending(gridOptions.SortBy).ToList();
                    }
                }
                
                if(gridOptions.PageSize > 0)
                {
                    data = data.Skip((gridOptions.CurrentPage * gridOptions.PageSize) - gridOptions.PageSize).Take(gridOptions.PageSize).ToList();

                    model.TotalPages = (int)Math.Ceiling((double)data.Count / gridOptions.PageSize);
                }
                else
                {
                    model.TotalPages = 1;
                }
               
                model.CurrentPage = gridOptions.CurrentPage;
                model.SortDirection = gridOptions.SortDirection;
                model.PageSize = gridOptions.PageSize;
                model.SortDirection = CORE.Enums.SortDirection.Ascending.ToString();
                model.SortBy = "Id";
            }          
            model.Data = data;         
            return Json(new { Data = model, Message = "Success!!!!", Success = true }, JsonRequestBehavior.AllowGet);
        }


        public ActionResult createShipingWithId()
        {
            return View();
        }

        public ActionResult createShipingWithoutId()
        {
            return View();
        }
    }
}