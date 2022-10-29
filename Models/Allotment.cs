using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class Allotment
    {

        public int AllotmentId { get; set; }
        public DateTime CreatedDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Qty { get; set; }

    }
}
