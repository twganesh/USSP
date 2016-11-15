using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Optimization;
using SLB.USSP.Core.DTO;
using SLB.USSP.Core;
using SLB.USSP.Service;

namespace SLB.USSP.Web
{
    public class Global : System.Web.HttpApplication
    {
        //Test
        protected void Application_Start(object sender, EventArgs e)
        {

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            UnityConfig.RegisterComponents();

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            //if (FormsAuthentication.CookiesSupported && Request.IsAuthenticated)
            //{
            //    if (Request.Cookies[FormsAuthentication.FormsCookieName] != null)
            //    {
            //        try
            //        {
            //            //let us take out the username now                
            //            string username = FormsAuthentication.Decrypt(Request.Cookies[FormsAuthentication.FormsCookieName].Value).Name;


            //            //string roles = string.Empty;
            //            //using (userDbEntities entities = new userDbEntities())
            //            //{
            //            //    User user = entities.Users.SingleOrDefault(u => u.username == username);

            //            //    roles = user.Roles;
            //            //}
            //            //let us extract the roles from our own custom cookie
            //            var user = new DTOWsseUser
            //            {
            //                Deleted = false,
            //                Email = "GTiwari2@slb.com",
            //                Name = "",
            //                Locked = 0,
            //                UserId = "GTiwari2",
            //                UserLevel = "1",
            //                LocationLdap = "",

            //            };
            //            //Let us set the Pricipal with our user specific details
            //            var identity = new CustomIdentity(HttpContext.Current.User.Identity, user, Enums.UserRole.Administrator);
            //            var principal = new CustomPrincipal(identity);
            //            HttpContext.Current.User = principal;

            //        }
            //        catch (Exception)
            //        {
            //            //somehting went wrong
            //            throw;
            //        }
            //    }
            //}
        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}