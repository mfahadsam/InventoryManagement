using InventoryManagement.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{
    public class CustomersController : Controller
    {
        private readonly MyDbContext context;

        public CustomersController(MyDbContext _context)
        {
            context = _context;

        }
        // GET: CustomersController
        public ActionResult Index()
        {
            return View();
        }

    }
       
}
