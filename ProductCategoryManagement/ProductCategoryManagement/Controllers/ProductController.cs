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
    public class ProductController : Controller
    {
        ServiceContext db = new ServiceContext();

        // GET: Product
        public ActionResult ProductList(int? page)
        {
            var pageNumber = page ?? 1;
            var pageSize = 5;
            var cdata = db.Product.OrderBy(x => x.ProductId).ToPagedList(pageNumber, pageSize);
            return View(cdata);
        }

        //ForAddingData
        public ActionResult AddProduct()
        {
            List<Category> categoryname = db.Category.ToList();
            ViewBag.Category = new SelectList(categoryname, "CategoryName", "CategoryName");
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            db.Product.Add(p);
            db.SaveChanges();
            return RedirectToAction("ProductList", "Product");


        }

        //ForEditingData
        public ActionResult EditProduct(int id)
        {
            var row = db.Product.Where(model => model.ProductId == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult EditProduct(Product p)
        {
            db.Entry(p).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ProductList", "Product");
        }

        //ForDeletingData
        public ActionResult DeleteProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteProduct(int id)
        {
            using (var context = new ServiceContext())
            {
                var _data = context.Product.FirstOrDefault(x => x.ProductId == id);
                if (_data != null)
                {
                    context.Product.Remove(_data);
                    context.SaveChanges();
                    return RedirectToAction("ProductList", "Product");
                }
                else
                    return View();
            }
        }

        //ForDisplayDetails
        public ActionResult ProductDetails(int id)
        {
            var detail = db.Product.Where(model => model.ProductId == id).FirstOrDefault();
            return View(detail);
        }

    }
}