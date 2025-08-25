using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Product: IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price {  get; set; }

        public Product(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}";
        }
        public int CompareTo(object? obj)
        {
            Product PassedProduct = (Product)obj;

            if (this.Price > PassedProduct?.Price)
                return 1;
            else if (this.Price < PassedProduct?.Price)
                return -1;
            else return 0;
        }
    }
}
