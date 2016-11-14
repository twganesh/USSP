using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShippingPaper.Controllers
{
    public abstract class USSPController : Controller
    {
        private const string URL_HISTORY = "URL_HISTORY";
        public USSPController()
        {

        }
        protected override void ExecuteCore()
        {
            AppendHistory();
            base.ExecuteCore();
        }

        protected override void Initialize(RequestContext requestContext)
        {
            base.Initialize(requestContext);

            /// add user profile or easy view model access
            /// http://stackoverflow.com/questions/6267727/most-elegant-way-to-ensure-view-model-data-for-layout-cshtml

            ViewBag.Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }


        protected override void OnException(ExceptionContext filterContext)
        {
            StringBuilder msg = new StringBuilder();

            msg.AppendFormat("Current: [{0}]\n", filterContext.HttpContext.Request.RawUrl);
            msg.Append("Querystrings:\n");

            foreach (var key in filterContext.RequestContext.HttpContext.Request.QueryString.AllKeys)
            {
                var value = "";
                try
                {
                    value = filterContext.RequestContext.HttpContext.Request.QueryString[key];
                }
                catch (Exception e)
                {
                    value = e.Message;
                }
                msg.AppendFormat("\t{0} : [{1}]\n", key, value);
            }


            var histories = Session[URL_HISTORY] as List<string>;
            if (histories != null)
            {
                msg.Append("History:\n");
                for (var i = histories.Count - 1; i >= 0; i--)
                {
                    var history = histories[i];
                    msg.AppendFormat("\t[{0}]\n", history);
                }
            }

            filterContext.ExceptionHandled = true;

            //using (EventLog log = new EventLog("GCRC Log"))
            //{
            //    log.Source = "OnException";
            //    log.WriteEntry(msg.ToString(), EventLogEntryType.Error);

            //}             


            if (filterContext.Exception.Message.Equals("Attempted to perform an unauthorized operation."))
            {
                //using (EventLog log = new EventLog("GCRC Log"))
                //{
                //    log.Source = "ApplicationException";
                //    log.WriteEntry(filterContext.Exception.ToString(), EventLogEntryType.Error);
                //}


                View("AccessDenied", filterContext.Exception).ExecuteResult(ControllerContext);
            }
            else
            {
                //using (EventLog log = new EventLog("GCRC Log"))
                //{
                //    log.Source = "GCRCLog";
                //    log.WriteEntry(filterContext.Exception.ToString(), EventLogEntryType.Error);
                //}

                View("Error", filterContext.Exception).ExecuteResult(ControllerContext);
            }            

        }

        private void AppendHistory()
        {
            var histories = Session[URL_HISTORY] as List<string>;
            if (histories == null)
            {
                histories = new List<string>();
                Session[URL_HISTORY] = histories;
            }

            if (histories.Count > 20)
            {
                histories.Remove(histories.First());
            }
            histories.Add(Request.RequestContext.HttpContext.Request.RawUrl);


        }
    }
}