using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - Customer in USA
        Address address1 = new Address(
            "27 Page Terrace",
            "Boston",
            "Massachusetts",
            "USA"
        );
        Customer customer1 = new Customer("John Smith", address1);

        Product product1 = new Product("Laptop", "P100", 800.00, 1);
        Product product2 = new Product("Mouse", "P101", 25.00, 2);
        Product product3 = new Product("Keyboard", "P102", 45.00, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Order 2 - Customer outside USA
        Address address2 = new Address(
            "25 Rue Capo",
            "Cap-Haitian",
            "Nord",
            "Haiti"
        );
        Customer customer2 = new Customer("Marie Joseph", address2);

        Product product4 = new Product("Pone", "P200", 500.00, 1);
        Product product5 = new Product("Charger", "P201", 30.00, 2);
        Product product6 = new Product("Headphone", "P202", 60.00, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Display Order 1
        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.CalculateTotal():F2}");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.CalculateTotal():F2}");
    }
}