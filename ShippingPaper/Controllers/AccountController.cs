using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Slb.Central.Component.ActiveDirectory;
using SLB.USSP.Core;
using SLB.USSP.Service;

namespace SLB.USSP.Web.Controllers
{
    public class LoginViewModel
    {


        [Required(ErrorMessage = "Username required.", AllowEmptyStrings = false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password required.", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }

        public bool SSOLogin { get; set; }
        public bool RememberMe { get; set; }


    }
    [Authorize]
    public class AccountController : Controller
    {
        private readonly ISecurity directory;
        private readonly ISearcher searcher;
        private readonly IUserInfoProvider userInfoProvider;
        public AccountController(ISecurity _directory, ISearcher _searcher, IUserInfoProvider _userInfoProvider)
        {
            directory = _directory;
            searcher = _searcher;
            userInfoProvider = _userInfoProvider;
        }
        // GET: Account
        public ActionResult Login(string returnUrl)
        {
            //if (User.Identity.IsAuthenticated)
            //{
            //    return Logout();
            //}
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [AllowAnonymous]
        public ActionResult Login(bool redirectFromLogout = false, bool redirectFromSSO = false, string returnUrl = "")
        {


            if (User.Identity.IsAuthenticated)  //the user was kicked out by an action attribute or directly navigated here
                return View("AccessDenied");

            ViewData.Add("LoggedOff", redirectFromLogout);
            return View();
        }


        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            ActionResult result;
                     
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                LoginUser(model);

                result = RedirectToLocal(returnUrl);
            }
            catch (UnauthorizedAccessException)
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                ViewData.Add("LoggedOff", true);
                result = View(model);
            }

            return result;
        }

        private void LoginUser(LoginViewModel loginViewModel)
        {
            if (!loginViewModel.SSOLogin)
            {              
                //if (!userInfoProvider.Authenticate(loginViewModel.Username, loginViewModel.Password))
                //{
                //    throw new UnauthorizedAccessException();
                //}

                if (directory.IsAuthenticUser(loginViewModel.Username, loginViewModel.Password))
                {
                    throw new UnauthorizedAccessException();
                }

            }

            //var registeredUser = _userProvider.GetUserWithoutLocationAndPermissionList(loginViewModel.UserName);
            //if (registeredUser == null)
            //    throw new UnauthorizedAccessException();

            var authCookie = FormsAuthentication.GetAuthCookie(loginViewModel.Username, false);

            var ticket = FormsAuthentication.Decrypt(authCookie.Value);

            var newTicket = new FormsAuthenticationTicket(
                ticket.Version,
                ticket.Name,
                ticket.IssueDate,
                ticket.Expiration,
                ticket.IsPersistent,
                loginViewModel.SSOLogin ? "SSO|UID: " + loginViewModel.Username : "LDAP|UID: " + loginViewModel.Username);

            authCookie.Value = FormsAuthentication.Encrypt(newTicket);

            Response.Cookies.Add(authCookie);

            
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                   && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login", "Account", new { redirectFromLogout = true, redirectFromSSO = false });
        }
    }

}