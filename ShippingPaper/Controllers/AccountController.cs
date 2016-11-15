using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Slb.Central.Component.ActiveDirectory;

namespace SLB.USSP.Web.Controllers
{
    public class LoginViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }


    }
    [Authorize]
    public class AccountController : Controller
    {
        private readonly ISecurity directory;
        private readonly ISearcher searcher;
        public  AccountController(ISecurity _directory, ISearcher _searcher)
        {
            directory = _directory;
            searcher = _searcher;
        }
        // GET: Account
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            string returnUrl = "/Home/Index";
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            
            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            //var result = await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout: false);
            var result = directory.IsAuthenticUser(model.Username, model.Password);
            if(result)
            {
                return RedirectToLocal(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }
           
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult SSOLogin()
        {
            string returnUrl = "/Home/Index";

            // This doesn't count login failures towards account lockout
            // To enable password failures to trigger account lockout, change to shouldLockout: true
            //var result = searcher.SearchByLoginId(User.Identity.Name);
            var result = searcher.SearchByLoginId("DIR\\GTiwari2");

            // var result = directory.IsValidCredentials("DIR", "GTiwari2", "Qter_20164");
            if (result != null)
            {
                return RedirectToLocal(returnUrl);
            }
            else
            {
                ViewBag.Message = "Invalid login attempt.";
                return View();
            }

        }
    }
}