using ShippingExercise.Entities;
using ShippingExercise.Entities.Enums;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter client data: ");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Birth Date: ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Client client = new Client(name, email, date);

        Console.WriteLine();

        Console.WriteLine("Enter order data: ");
        OrderStatus status = Enum.Parse<OrderStatus>("Processing");
        Console.WriteLine(status);
        Console.Write("How many items to this order? ");
        int n = int.Parse(Console.ReadLine());
        DateTime dateNow = DateTime.Now;
        
        Order order = new Order(dateNow, status);
        

        for (int i = 1; i <= n; i++)
        {

            Console.WriteLine($"Enter #{i} item data: ");
            Console.Write("Product name: ");
            string prodName = Console.ReadLine();
            Console.Write("Product price: ");
            double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity: ");
            int prodQuant = int.Parse(Console.ReadLine());

            OrderItem orderItem = new OrderItem(prodQuant, prodPrice, prodName);
            orderItem.Prod(prodName, prodPrice);
            order.AddItem(orderItem);
            

        }
        
        Console.WriteLine("ORDER SUMARY");
        Console.WriteLine("Order moment: " + order.Moment);
        Console.WriteLine("Order status: " + order.Status);
        Console.WriteLine("Client: " + client.Name + "(" + client.BirthDate + ") - " + client.Email);
        Console.WriteLine();
        Console.WriteLine("Order items: ");
        Console.WriteLine(order);
        

        


    }
}