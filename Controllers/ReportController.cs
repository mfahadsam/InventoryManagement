using AspNetCore.Reporting;
using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Controllers
{

    public class ReportController : Controller
    {
        private readonly MyDbContext context;
        private readonly IWebHostEnvironment webHostEnviroment;

        public ReportController(MyDbContext _context , IWebHostEnvironment _webHostEnviroment)
        {
            context = _context;

            webHostEnviroment = _webHostEnviroment;

        }

        public IActionResult Index()
        {
            return View();
        }

        public byte[] GenerateReportsAsync()
        {
            //string fileDirPath = Assembly.GetExecutingAssembly().Location.Replace("ReportAPI.dll", string.Empty);
            string rdlcFilePath = webHostEnviroment.WebRootPath + string.Format("\\{0}\\{1}.rdlc", "RDLCReport", "Report3");
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Encoding.GetEncoding("windows-1252");
            LocalReport report = new LocalReport(rdlcFilePath);

            //List<Product> productList = new List<Product>();
            //productList = context.Products.ToList();
            // Start_Time = 10
            //End_time = 16
            //subtract = End_time - Start_Time = 6

            //var subtract = ltask.Where(x => x.End_Time - x.Start_Time);

            //.Contains("76")



//            select PRODUCTS.ProductId AS ID,
// MAX(Products.[Name]) as Product
//,MAX(Brands.[Name]) as Brand
//,MAX(Categories.[Name]) as Category
//,MAX(Products.SalePrice) as Price
//,MAX(Products.Qty) as TotalQty

//, Count(Allotments.ProductId) AS TotalSold

//from Products
//left join Allotments on Products.ProductId = Allotments.ProductId
//left
//join Brands on Products.BrandId = Brands.BrandId
//left
//join Categories on Products.CategoryId = Categories.CategoryId


//GROUP BY Products.ProductId
//ORDER BY Products.ProductId






       var dataaa = context.Products.AsNoTracking()
                .Include(g => g.Allotments).DefaultIfEmpty()
                .Include(g => g.Brand)
                .Include(g => g.Category)
                .Select(s => new
                {
                    ProductName = s.Name,
                    Brand = s.Brand.Name,
                    CategoryName = s.Category.Name,
                    SalePrice = s.SalePrice,
                    TotalQty = s.Qty,
                    TottalSold = s.Allotments.Where(w=>w.ProductId==s.ProductId).Count()
                }).ToList();

            var dataList = context.Allotments.Include(g => g.Customer).Include(g => g.Product).DefaultIfEmpty().Where(g=>g.CustomerId==3).Select(s => new { s.AllotmentId, createddate = s.CreatedDate.ToString("dd-MMM-yyyy"), s.ProductId, productname = s.Product.Name,s.CustomerId, customername = s.Customer.CustomerName}).ToList();


            //var qry1 = context.Allotments.Include(f => f.Product).DefaultIfEmpty().Select(s => new { s.ProductId, s.CustomerId, productid = s.Product.ProductId }).ToList();

            //var qry = context.Products.ToList();
            

            string totalproduct = context.Allotments.Count().ToString();




            // var obj = context.Products.Include(g => g.Category).Include(g => g.Brand).DefaultIfEmpty().ToList();


            //var dataList = context.Products.Include(g => g.Brand).Include(g => g.Category).DefaultIfEmpty().Where(g=>g.Qty==76 || g.Name=="Food1").Select(s => new { s.ProductId, brandname = s.Brand.Name, s.Name, s.Qty, s.SalePrice, categoryname = s.Category.Name }).ToList();




            List <Category> categoryList = new List<Category>();
            categoryList = context.Categories.ToList();


            

            report.AddDataSource("DataSet3", dataaa);
            var result = report.Execute(GetRenderType("pdf"), 1, parameters);
            return result.MainStream;
        }

        private RenderType GetRenderType(string reportType)
        {
            var renderType = RenderType.Pdf;
            switch (reportType.ToLower())
            {
                default:
                case "pdf":
                    renderType = RenderType.Pdf;
                    break;
                case "word":
                    renderType = RenderType.Word;
                    break;
                case "excel":
                    renderType = RenderType.Excel;
                    break;
            }

            return renderType;
        }

     
        public ActionResult GetReport()
        {
            var returnString = GenerateReportsAsync();
            return File(returnString, System.Net.Mime.MediaTypeNames.Application.Octet, "fahad" + ".pdf");
        }

    }
}
