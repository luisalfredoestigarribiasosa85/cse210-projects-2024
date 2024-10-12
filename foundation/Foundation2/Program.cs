using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("99 Felix de Azara St", "Itaugua", "Central", "Paraguay");

        Customer customer1 = new Customer("Jane Smith", address1);
        Customer customer2 = new Customer("Luis Estigarribia", address2);

        Product product1 = new Product("Laptop", "L001", 199.90m, 1);
        Product product2 = new Product("SSD 240GB", "S001", 20.50m, 1);
        Product product3 = new Product("Keyboard", "K001", 9.99m, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        DisplayOrderInfo(order1, 1);
        DisplayOrderInfo(order2, 2);
    }

    static void DisplayOrderInfo(Order order, int orderNumber)
    {
        Console.WriteLine($"Order {orderNumber}:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"\nPrice: {order.GetPrice()}");
        Console.WriteLine($"Shipping Cost: {order.GetShippingCost()}");
        Console.WriteLine($"\nTotal Price: ${order.GetTotalPrice():F2}");
        Console.WriteLine("----------------------------------------");
    }
}