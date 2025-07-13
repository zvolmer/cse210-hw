using System;

public class Program
{
    public static void Main(string[] args)
    {
        Address a1 = new Address("123 Maple St", "Seattle", "WA", "USA");
        Customer c1 = new Customer("Bob Tomato", a1);
        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Ball", "B123", 3.0, 5));
        o1.AddProduct(new Product("Pan", "P456", 2.5, 3));
        Console.WriteLine("Packing Label:\n" + o1.GetPackingLabel());
        Console.WriteLine("\nShipping Label:\n" + o1.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + o1.CalculateTotal());

        Console.WriteLine();

        Address a2 = new Address("456 Oak Ave", "Vancouver", "BC", "Canada");
        Customer c2 = new Customer("Larry Cucumber", a2);
        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Bowl", "B789", 10.0, 1));
        o2.AddProduct(new Product("Brush", "B101", 5.0, 2));
        o2.AddProduct(new Product("Book", "B112", 1.5, 4));
        Console.WriteLine("Packing Label:\n" + o2.GetPackingLabel());
        Console.WriteLine("\nShipping Label:\n" + o2.GetShippingLabel());
        Console.WriteLine("\nTotal Price: $" + o2.CalculateTotal());
    }
}
