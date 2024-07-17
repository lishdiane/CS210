using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Order order1 = new Order();
        Customer customer1 = new Customer("Diane Lish");
        Address address1 = new Address("1234 S Happy St.", "Happy", "Idaho", "USA");

        customer1.SetAddress(address1);
        order1.SetCustomer(customer1);

        Product product1 = new Product("Milk", 123, 2.50, 2);
        order1.AddProductToList(product1);
        Product product2 = new Product("Cake", 321, 32.75, 1);
        order1.AddProductToList(product2);
        Product product3 = new Product("Apple", 412, 0.25, 6);
        order1.AddProductToList(product3);

        order1.GetPackingLabel();

        Console.WriteLine($"Total: ${order1.CalculateTotalCost()}");
        Console.WriteLine();

        Console.WriteLine($"{order1.GetShippingLabel()}");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("");
        
        Order order2 = new Order();
        Customer customer2 = new Customer("Tyler Lish");
        Address address2 = new Address("555 E Holliday St.", "Christmas", "Alberta", "Canada");

        customer2.SetAddress(address2);
        order2.SetCustomer(customer2);

        Product product4 = new Product("Cheese", 999, 4.00, 2);
        order2.AddProductToList(product4);
        Product product5 = new Product("Steak", 441, 18.50, 2);
        order2.AddProductToList(product5);
        Product product6 = new Product("Celery", 389, 1.25, 1);
        order2.AddProductToList(product6);

        order2.GetPackingLabel();

        Console.WriteLine($"Total: ${order2.CalculateTotalCost()}");
        Console.WriteLine();

        Console.WriteLine($"{order2.GetShippingLabel()}");
        

        


        



        

    }
}