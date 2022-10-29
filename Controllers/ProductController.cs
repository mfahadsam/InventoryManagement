using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    public class ProductController : Controller
    {

        private readonly MyDbContext context;

        public ProductController(MyDbContext _context)
        {
            context = _context;

        }

        public IActionResult Index()
        {
            ViewBag.CategoryList = new SelectList(context.Categories.ToList(), "CategoryId", "Name");

            ViewBag.BrandList = new SelectList(context.Brands.ToList(), "BrandId", "Name");

            var obj = context.Products.Include(g => g.Category).Include(g=>g.Brand).DefaultIfEmpty().ToList();
           // var objbrand = context.Brands.Include(g => g.BrandId).DefaultIfEmpty().ToList();
            return View(obj);

            //List<Product> objList = context.Products.ToList();
            //return View(objList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //var list = new SelectList(context.Categories.ToList(), "CategoryId", "Name");
            //ViewBag.CategoryList = list;
            var catList = context.Categories.ToList();
            ViewBag.CategoryList = catList;

            var brandlist = context.Brands.ToList();
            ViewBag.BrandList = brandlist;



            return View();
        }
        [HttpPost]
        public IActionResult Create(Product model)
        {
            if (ModelState.IsValid)
            {
                context.Products.Add(model);
                context.SaveChanges();
            }
            else
            {
                return Json(new { istrue = false, message = "Failed" });
            }
            return Json(new { istrue = true, message = "Saved" });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            
            ViewBag.CategoryList = new SelectList(context.Categories.ToList(), "CategoryId", "Name");
            ViewBag.BrandList = new SelectList(context.Brands.ToList(), "BrandId", "Name");
            var obj = context.Products.Find(id);


            return View(obj);

        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {

            //var data = context.Products.Find(product.ProductId);

            var obj = context.Products.Update(product);

            context.SaveChanges();
            return View(obj);

        }


        [HttpPost]

        public IActionResult Delete(Product product)
        {
            
            var data = context.Products.Find(product.ProductId);

            var obj = context.Products.Remove(data);

            context.SaveChanges();
            return View(obj);

        }


        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            ViewBag.CategoryList = new SelectList(context.Categories.ToList(), "CategoryId", "Name");

            ViewBag.BrandList = new SelectList(context.Brands.ToList(), "BrandId", "Name");
            var obj = context.Products.Find(id);
            return View(obj);

        }


        [HttpGet]
        public JsonResult AdvanceSearchViewModal(int BrandId, int CategoryId)
        {

            var query = context.Products.Include(g => g.Brand).Include(g => g.Category).DefaultIfEmpty();
            ///IQUERABLE
            if (BrandId != -1)
            {
                query = query.Where(w => w.BrandId == BrandId);
            }
            if (CategoryId != -1)
            {
                query = query.Where(w => w.CategoryId == CategoryId);
            }

           /* select productid as prodid from product   */
          
            return Json(new { data = query.Select(s=> new {s.ProductId,brandname=s.Brand.Name,s.Name,s.Qty,s.SalePrice,categoryname=s.Category.Name }).ToList() });
        }


    }
}
