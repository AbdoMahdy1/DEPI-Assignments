using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Car
    {
        private int id;
        private string brand;
        private int price;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Car(int id, string brand, int price) : this(id, brand)
        {
            this.price = price;
        }

        public Car() { }

        public Car(int id)
        {
            this.id = id;
        }

        public Car(int id, string brand) : this(id)
        {
            
            this.brand = brand;
        }

        public void print()
        {
            Console.WriteLine($"ID: {id}, Brand: {brand}, Price: {price}");
        }
    }
}
