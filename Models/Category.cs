using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        //public string Description { get; set; }
        //public int CreatedBy { get; set; }
        public virtual IEnumerable<Product> Product { get; set; }

    }
}
