using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        //[Required]
        public decimal SalePrice { get; set; }
        public int Qty { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }

        public int? BrandId { get; set; }
        public Brand Brand { get; set; }


        public List<Allotment> Allotments  { get; set; }
    }
    
}
