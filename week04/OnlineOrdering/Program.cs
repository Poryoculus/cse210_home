using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an Address
        Address customerAddress = new Address("123 Main St", "New York", "NY", "USA");

        // Create a Customer
        Customer customer = new Customer();
        customer._name = "John Doe";
        customer._address = customerAddress;

        // Create an Order
        Order order = new Order(customer);

        // Create Products
        Product product1 = new Product("Laptop", 101, 1200.99, 1);
        Product product2 = new Product("Mouse", 102, 25.50, 2);
        Product product3 = new Product("Keyboard", 103, 45.75, 1);

        // Add products to the order
        order._products.Add(product1);
        order._products.Add(product2);
        order._products.Add(product3);

        // Display Order Details
        Console.WriteLine("\n====================");
        Console.WriteLine("\nPacking Label:");
        order.GetPackingLabel();

        Console.WriteLine("\n====================");
        Console.WriteLine("\nShipping Label:");
        order.GetShippingLabel();

        // Display Total Cost
        Console.WriteLine($"\nTotal Order Cost: ${order.CalculateTotalCost():0.00}");


        Console.WriteLine("\n====================");
        //I Created all the Code except for the variables to introduce in the main program,
        //I asked  chatgpt for ideas of products and name to save some time.
    }
}