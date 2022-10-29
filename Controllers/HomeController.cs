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
    public class HomeController : Controller
    {

        private readonly MyDbContext context;

        public HomeController(MyDbContext _context)
        {
            context = _context;

        }
        public IActionResult Index()
        {
            ViewBag.CustomerList = new SelectList(context.Customers.ToList(), "CustomerId", "CustomerName");
            ViewBag.ProductList = new SelectList(context.Products.ToList(), "ProductId", "Name");
            var obj = context.Allotments.Include(g => g.Customer).Include(g => g.Product).DefaultIfEmpty().ToList();
            //var obj = context.Products.Include(g => g.Category).Include(g => g.Brand).DefaultIfEmpty().ToList();
            //var objList = context.Allotments.ToList();
            return View(obj);
        }
        [HttpPost]
        public IActionResult Create()
        {
            int customerid =  int.Parse(Request.Form["CustomerId"]);
            int productid =  int.Parse(Request.Form["ProductId"]);
            if (ModelState.IsValid)
            {
                Allotment obj = new Allotment();

                obj.CustomerId = customerid;
                obj.ProductId = productid;
                obj.CreatedDate = DateTime.Now;
                context.Allotments.Add(obj);
                context.SaveChanges();
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {

            ViewBag.CustomerList = new SelectList(context.Customers.ToList(), "CustomerId", "CustomerName");
            ViewBag.ProductList = new SelectList(context.Products.ToList(), "ProductId", "Name");

            var allotment = context.Allotments.Where(x => x.AllotmentId == id).FirstOrDefault();


            return View(allotment);
        }
        [HttpPost]
        public IActionResult Edit(Allotment allotment)
        {
            var obj = context.Allotments.Update(allotment);
            context.SaveChanges();
            return View(obj);

        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            ViewBag.CustomerList = new SelectList(context.Customers.ToList(), "CustomerId", "CustomerName");

            ViewBag.ProductList = new SelectList(context.Products.ToList(), "ProductId", "Name");
            var obj = context.Allotments.Find(id);
            return View(obj);

        }

        [HttpPost]
        public IActionResult Delete(Allotment allotment)
        {

            var data = context.Allotments.Find(allotment.AllotmentId);

            var obj = context.Allotments.Remove(data);

            context.SaveChanges();
            
            return RedirectToAction(nameof(Index));
        }

    }
}
