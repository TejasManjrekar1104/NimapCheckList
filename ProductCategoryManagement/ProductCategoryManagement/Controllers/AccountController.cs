using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ProductCategoryManagement.Models;

namespace ProductCategoryManagement.Controllers
{
    public class AccountController : Controller
    {
        ServiceContext db = new ServiceContext();
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(UserAccount a)
        {
            if (ModelState.IsValid)
            {
                db.UserAccount.Add(a);
                await db.SaveChangesAsync();
                ModelState.Clear();
                ViewBag.Message = "Welcome " + a.FullName + ", You are successfully registered.";
            }
            return View();
        }      
        
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(UserAccount user)
        {
            var users = await db.UserAccount.FirstOrDefaultAsync(u => u.UserName == user.UserName && u.Password == user.Password);
            if(users != null)
            {
                Session["UserId"] = users.UserId.ToString();
                Session["UserName"] = users.UserName.ToString();
                return RedirectToAction("LoggdeIn");
            }
            else
            {
                ModelState.AddModelError("", "UserName or Password is Wrong");
            }
            return View();
        }

        public ActionResult LoggedIn()
        {
            if(Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}