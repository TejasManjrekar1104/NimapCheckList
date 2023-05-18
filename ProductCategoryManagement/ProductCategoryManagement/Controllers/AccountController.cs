using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductCategoryManagement.Models;
using System.Web.Security;

namespace ProductCategoryManagement.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        ServiceContext db = new ServiceContext();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account a)
        {
            bool isValid = db.Account.Any(x => x.UserName == a.UserName && x.UserPassword == a.UserPassword);
            if (isValid)
            {
                FormsAuthentication.SetAuthCookie(a.UserName, false);
                return RedirectToAction("CategoryList", "Category");
            }
            return View();
        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(Account a)
        {
            db.Account.Add(a);
            db.SaveChanges();
            return RedirectToAction("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}