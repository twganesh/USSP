using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SLB.USSP.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region Script Bundles
            ///JQuery
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //            "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                      "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/bootstrap-datepicker.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/angularjs").Include(
                      "~/Scripts/angular.min.js"
                      ));

            bundles.Add(new ScriptBundle("~/bundles/datepickerjs").Include(
                     "~/Scripts/date-picker-code.js"
                     ));
            #endregion

            #region Style Bundles
            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                    "~/Content/bootstrap.min.css"
                    ));

            bundles.Add(new StyleBundle("~/Content/stylecss").Include(
                     "~/Content/css/master.css",
                     "~/Content/css/style.css",
                     "~/Content/css/header.css",
                     "~/Content/css/datepicker.css"
                     ));

            bundles.Add(new StyleBundle("~/Content/jqueryui").Include(
                     "~/Content/themes/base/jquery-ui.css"));
            
            #endregion
            //BundleTable.EnableOptimizations = true;
        }
    }
}