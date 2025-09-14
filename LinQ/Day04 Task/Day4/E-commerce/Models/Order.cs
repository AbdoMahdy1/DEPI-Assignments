using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int? CustomerId { get; set; }

        public List<OrderDetails> OrderProducts { get; set; }

        public Customer Customer { get; set; }
    }
}
