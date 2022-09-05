using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    public class ProductController : Controller
    {

        MyDbContext context = new MyDbContext();
        public IActionResult Index()
        {
            //var prodList = context.Products.ToList();
            //ViewBag.ProductList = prodList;

            List<Product> objList = context.Products.ToList();
            return View(objList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //var list = new SelectList(context.Categories.ToList(),"CategoryId","Name");
            //ViewBag.CategoryList = list;
            //ViewBag.CategoryList = context.Categories.ToList();
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
            return RedirectToAction("Index");
        }
    }
}
