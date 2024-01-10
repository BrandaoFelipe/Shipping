using ShippingExercise.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingExercise.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderProd { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            OrderProd.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderProd.Remove(item);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            

            
            foreach (OrderItem item in OrderProd)
            {
                sb.Append(item.Name + "$" + item.Price + ", Quantity: " + item.Quantity);
                sb.AppendLine();
                
            }


            return sb.ToString();
        }





    }
}
