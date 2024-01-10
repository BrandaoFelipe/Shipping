using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShippingExercise.Entities;

namespace ShippingExercise.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Name{ get; set; }


        public OrderItem() { }

        public OrderItem(int quantity, double price, string name)
        {
            
            Quantity = quantity;
            Price = price; 
            Name = name;

        }

        public Product Prod(string name, double price)
        {
            return new Product(name, price);
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
