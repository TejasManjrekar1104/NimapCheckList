﻿using PagedList;
using ProductCategoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProductCategoryManagement.Controllers
{
    public class ProductController : Controller
    {

        ServiceContext db = new ServiceContext();

        public object[] ProductId { get; private set; }

        // GET: Product
        public async Task<ActionResult> ProductList(int page = 1)
        {
            int pageSize = 6;
            var totalCount = await db.Product.CountAsync();
            var totalPages = (int)Math.Ceiling((decimal)totalCount / pageSize);
            var Product = await db.Product.Include(m => m.Category).OrderByDescending(x => x.ProductId).Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = totalPages;
            return View(Product);
        }


        //ForAddingData
        public async Task<ActionResult> AddProduct()
        {
            List<Category> categoryname = await db.Category.ToListAsync();
            ViewBag.Category = new SelectList(categoryname, "CategoryId", "CategoryName");
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> AddProduct(Product p)
        {
            p.IsActivate = true;
            db.Product.Add(p);
            await db.SaveChangesAsync();
            return RedirectToAction("ProductList", "Product");
        }


        //ForEditingData
        public async Task<ActionResult> EditProduct(int id)
        {
            List<Category> categoryname = await db.Category.ToListAsync();
            ViewBag.Category = new SelectList(categoryname, "CategoryId", "CategoryName");
            return View(await db.Product.Where(model => model.ProductId == id).FirstOrDefaultAsync());
        }


        [HttpPost]
        public async Task<ActionResult> EditProduct(Product p)
        {
            var prod = await db.Product.Include(m => m.Category).FirstOrDefaultAsync(x => x.ProductId == p.ProductId);

            prod.ProductName = p.ProductName;
            prod.ProductId = p.ProductId;
            prod.ProductPrice = p.ProductPrice;
            prod.CategoryId = p.CategoryId;
            db.Entry(prod).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return RedirectToAction("productlist", "product");
        }


        //ForDeletingData
        public async Task<ActionResult> DeleteProduct(int id)
        {
            return View(await db.Product.FirstOrDefaultAsync(model => model.ProductId == id));
        }


        [HttpPost]
        [ActionName("DeleteProduct")]
        public async Task<ActionResult> DeleteProductConfirm(int id)
        {
            db.Product.Remove(await db.Product.FirstOrDefaultAsync(model => model.ProductId == id));
            await db.SaveChangesAsync();
            return RedirectToAction("ProductList");
        }


        //ForDisplayDetails
        public async Task<ActionResult> ProductDetails(int id)
        {
            return View(await db.Product.Where(model => model.ProductId == id).FirstOrDefaultAsync());
        }

        public async Task<ActionResult> ShowProduct(int id)
        { 
            return View(await db.Product.Include(x => x.Category).Where(m => m.CategoryId == id).ToListAsync());
        }

    }
}