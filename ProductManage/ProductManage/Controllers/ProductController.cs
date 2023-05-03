using ProductManage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ProductManage.Controllers
{
    public class ProductController : Controller
    {
        MyDbContext db = new MyDbContext();

        // GET: Product
        public ActionResult ProductList()
        {
            var data = db.Categories.ToList();
            return View(data);
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            if(ModelState.IsValid == true) {
                db.Products.Add(p);
                db.SaveChanges();
            }
                return RedirectToAction("ProductList", "Product");
        }


    }
}