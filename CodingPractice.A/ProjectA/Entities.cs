using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public int Stock { get; set; }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public Customer Customer{ get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }

        public decimal TotalAmount { get; set; }
    }
}
