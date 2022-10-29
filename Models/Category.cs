using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
    
        public  List<Product> Product { get; set; }

    }
}
