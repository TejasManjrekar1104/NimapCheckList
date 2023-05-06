using PagedList;
using ProductCategoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

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
            ViewBag.Category = new SelectList(categoryname, "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            try
            {
                db.Product.Add(p);
                db.SaveChanges();
                return RedirectToAction("ProductList", "Product");
            }
            catch (Exception)
            {

                throw;
            }
        }

        //ForEditingData
        public ActionResult EditProduct(int id)
        {
            List<Category> categoryname = db.Category.ToList();
            ViewBag.Category = new SelectList(categoryname, "CategoryName", "CategoryName");
            var row = db.Product.Where(model => model.ProductId == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult EditProduct(Product p)
        {
            var prod = db.Product.FirstOrDefault(x => x.ProductId == p.ProductId);

            prod.ProductName = p.ProductName;
            prod.ProductId = p.ProductId;
            prod.ProductPrice = p.ProductPrice;
            prod.CategoryId = p.CategoryId;
            db.Entry(prod).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("ProductList", "Product");
        }

        //ForDeletingData
        public ActionResult DeleteProduct(int id)
        {
            Product p = db.Product.FirstOrDefault(model => model.ProductId == id);
            return View(p);
        }

        [HttpPost]
        [ActionName("DeleteProduct")]
        public ActionResult DeleteProductConfirm(int id)
        {
            Product p = db.Product.FirstOrDefault(model => model.ProductId == id);
            db.Product.Remove(p);
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }

        //ForDisplayDetails
        public ActionResult ProductDetails(int id)
        {
            var detail = db.Product.Where(model => model.ProductId == id).FirstOrDefault();
            return View(detail);
        }

    }
}