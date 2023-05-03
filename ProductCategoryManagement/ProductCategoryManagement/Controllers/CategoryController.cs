using PagedList;
using ProductCategoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ProductCategoryManagement.Controllers
{
    public class CategoryController : Controller
    {

        ServiceContext db = new ServiceContext();

        // GET: Category
        public ActionResult CategoryList(int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 5;
            var cdata = db.Category.OrderBy(x => x.CategoryId).ToPagedList(pageNumber, pageSize);
            return View(cdata);
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            db.Category.Add(c);
            db.SaveChanges();
            return RedirectToAction("AddCategory", "Category");
        }


    }
}