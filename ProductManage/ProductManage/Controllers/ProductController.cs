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
        public async Task<ActionResult> ProductList()
        {
            var data = db.Categories.ToListAsync();
            return View(data);
        }
    }
}