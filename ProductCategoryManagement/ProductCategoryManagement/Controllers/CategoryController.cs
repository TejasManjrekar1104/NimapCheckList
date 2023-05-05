using PagedList;
using ProductCategoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        //ForAddingData
        public ActionResult AddCategory()
        {
            return View(); 
        }

        [HttpPost]
        public ActionResult AddCategory(Category c)
        {
            db.Category.Add(c);
            db.SaveChanges();
            return RedirectToAction("CategoryList", "Category"); 
        }

        //ForEditingData
        public ActionResult EditCategory(int id)
        {
            var row = db.Category.Where(model => model.CategoryId == id).FirstOrDefault();
            return View(row); 
        }

        [HttpPost]
        public ActionResult EditCategory(Category c)
        {
            db.Entry(c).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("CategoryList", "Category"); 
        }

        //ForDeletingData
        public ActionResult DeleteCategory(int id) 
        {
            var row = db.Category.Where(model => model.CategoryId == id).FirstOrDefault();
            return View(row); 
        }

        [HttpPost]
        public ActionResult DeleteCategory(Category c)
        {
            db.Entry(c).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("CategoryList", "Category");
        }

        //ForDisplayDetails
        public ActionResult CategoryDetails(int id)
        {
            var detail = db.Category.Where(model => model.CategoryId == id).FirstOrDefault();
            return View(detail); 
        }

      


    }
} 