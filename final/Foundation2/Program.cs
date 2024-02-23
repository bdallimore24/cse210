using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("870 W. East St", "A-City", "ND", "USA");
        Customer customer1 = new Customer("John Wick", address1);
        List<Product> products1 = new List<Product>()
        {

            new Product("Big Hammer", 1, 40.0, 2),
            new Product("Revenge for Dummies", 2, 20.0, 1),

        };


        Order order1 = new Order(products1, customer1);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine();

        Address address2 = new Address("867 State St", "Easton", "AB", "Canada");
        Customer customer2 = new Customer("Mr. Bill", address2);
        List<Product> products2 = new List<Product>()
        {

            new Product("Tea Set", 3, 15.0, 3),
            new Product("Light Sabor", 4, 30.0, 1),
            new Product("Gum", 5, 5.0, 5)

        };

        Order order2 = new Order(products2, customer2);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");

        Console.ReadLine();
        
    }
}