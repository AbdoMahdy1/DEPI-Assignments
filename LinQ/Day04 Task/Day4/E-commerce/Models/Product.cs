using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int? CategoryId { get; set; }

        public List<OrderDetails> ProductOrders { get; set; }

        public Category Category { get; set; }
    }
}
