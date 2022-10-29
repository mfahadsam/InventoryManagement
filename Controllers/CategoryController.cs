using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    public class CategoryController : Controller
    {
        private readonly MyDbContext context;

        public CategoryController(MyDbContext _context)
        {
            context = _context;

        }
        public IActionResult Index()
        {

            //List<Category> categoryList = context.Categories.ToList();

            var objList = context.Categories.ToList();


            //objList.Add(new Category() { CategoryId = 1 , Name = "Food"});
            //objList.Add(new Category() { CategoryId = 2 , Name = "Food"});
            //objList.Add(new Category() { CategoryId = 3 , Name = "Food"});



            ViewBag.CategoryList = objList;

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryList = context.Categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Create(Category model)
        {
            Category objList = new Category() { Name = model.Name};

            Brand objbrand = new Brand();

            context.Categories.Add(objList);
            context.Brands.Add(objbrand);
            context.SaveChanges();
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            //Find Data from database based on id asp-route-id="@item.CategoryId"
            var category = context.Categories.Where(x => x.CategoryId == id).FirstOrDefault();

            return View(category);


            //return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category model)
        {
            Category obj = new Category() { CategoryId = model.CategoryId, Name = model.Name };
            context.Categories.Update(obj);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
           var data = context.Categories.Find(id);

            return View(data);
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            var data = context.Categories.Find(category.CategoryId);
            context.Categories.Remove(data);
            context.SaveChanges();
            return View();
        }

        //[HttpPost]
        //public IActionResult Edit(int CategoryId, string Name)
        //{
        //    Category obj = new Category() {CategoryId= CategoryId, Name = Name };
        //    context.Categories.Update(obj);
        //    context.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //public JsonResult GetCategorys()
        //{
        //    var objList = context.Categories.ToList();
        //    return Json(objList);

        //}

    }
}
