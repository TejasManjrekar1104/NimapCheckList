using PagedList;
using ProductCategoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace ProductCategoryManagement.Controllers
{
    public class CategoryController : Controller
    {

        ServiceContext db = new ServiceContext();

        // GET: Category
        public async Task<ActionResult> CategoryList()
        {
            return View(await db.Category.OrderByDescending(x => x.CategoryId).ToListAsync()); 
        }


        //ForAddingData
        public ActionResult AddCategory()
        {
            return View(); 
        }


        [HttpPost]
        public async Task<ActionResult> AddCategory(Category c)
        {
            c.IsActivate = true;
            db.Category.Add(c);
            await db.SaveChangesAsync();
            return RedirectToAction("CategoryList", "Category"); 
        }


        //ForEditingData
        public async Task<ActionResult> EditCategory(int id)
        {
            return View(await db.Category.Where(model => model.CategoryId == id).FirstOrDefaultAsync()); 
        }


        [HttpPost]
        public async Task<ActionResult> EditCategory(Category c)
        {
            db.Entry(c).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return RedirectToAction("CategoryList", "Category"); 
        }


        //ForDeletingData
        public async Task<ActionResult> DeleteCategory(int id)
        {
            return View(await db.Category.FirstOrDefaultAsync(model => model.CategoryId == id));
        }


        [HttpPost]
        [ActionName("DeleteCategory")]
        public async Task<ActionResult> DeleteCategoryConfirm(int id)
        {
            db.Category.Remove(await db.Category.FirstOrDefaultAsync(model => model.CategoryId == id));
            await db.SaveChangesAsync();
            return RedirectToAction("CategoryList");
        }


        //ForDisplayDetails
        public async Task<ActionResult> CategoryDetails(int id)
        {
            return View(await db.Category.Where(model => model.CategoryId == id).FirstOrDefaultAsync()); 
        }


        //ForActivateCategory
        public async Task<ActionResult> ActivateCategory(int id)
        {
            var categoryToActivate = await db.Category.FirstOrDefaultAsync(c => c.CategoryId == id && !c.IsActivate);
            if (categoryToActivate != null)
            {
                categoryToActivate.IsActivate = true;
                var relatedProducts = db.Product.Where(p => p.CategoryId == id && !p.IsActivate);
                foreach (var product in relatedProducts)
                {
                    product.IsActivate = true;
                }
                await db.SaveChangesAsync();
            }
            return RedirectToAction("CategoryList", "Category");
        }


        //ForDeactivateCategory
        public async Task<ActionResult> DeactivateCategory(int id)
        {
            var categoryToDeactivate = await db.Category.FirstOrDefaultAsync(c => c.CategoryId == id && c.IsActivate);
            if (categoryToDeactivate != null)
            {
                categoryToDeactivate.IsActivate = false;
                var relatedProducts = db.Product.Where(p => p.CategoryId == id && p.IsActivate);
                foreach (var product in relatedProducts)
                {
                    product.IsActivate = false;
                }
                await db.SaveChangesAsync();
            }
            return RedirectToAction("CategoryList", "Category");
        }
    }
} 