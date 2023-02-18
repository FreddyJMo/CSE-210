using System;

namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create products
            Product product1 = new Product("Blue T-Shirt", 1000121, 15.99, 2);
            Product product2 = new Product("Black pants", 1000142, 29.99, 1);
            Product product3 = new Product("Sport socks", 1000185, 4.99, 5);

            // Create addresses
            Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
            Address address2 = new Address("456 Oak St", "Sometown", "BC", "Canada");

            // Create customers
            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);
            order1.AddProduct(product3);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // Display packing label, shipping label, and total price for order1
            Console.WriteLine("Packing label for order 1:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine("Shipping label for order 1:");
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("Total price for order 1: $" + order1.CalculateTotalPrice());

            // Display packing label, shipping label, and total price for order2
            Console.WriteLine("\nPacking label for order 2:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine("Shipping label for order 2:");
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("Total price for order 2: $" + order2.CalculateTotalPrice());

            Console.ReadLine();
        }
    }
}