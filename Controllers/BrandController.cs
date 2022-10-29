using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    public class BrandController : Controller
    {
        private readonly MyDbContext context;

        public BrandController(MyDbContext _context)
        {
            context = _context;

        }


        // GET: BrandController
        public ActionResult Index()
        {
            var objList = context.Brands.ToList();
            ViewBag.BrandList = objList;
            return View();
        }

        // GET: BrandController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BrandController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: BrandController/Create
        [HttpPost]
        public ActionResult Create(Brand brand)
        {
            if (ModelState.IsValid)
            {
                
                context.Brands.Add(brand);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return Json(new { istrue = false, message = "Failed" });
            }
            return Json(new { istrue = true, message = "Saved" });
        }

        // GET: BrandController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BrandController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrandController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BrandController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
