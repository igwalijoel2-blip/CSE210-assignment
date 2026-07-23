using System;


class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );


        Customer customer1 = new Customer(
            "John Smith",
            address1
        );


        Product product1 = new Product(
            "Laptop",
            "P001",
            900,
            1
        );


        Product product2 = new Product(
            "Mouse",
            "P002",
            25,
            2
        );


        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);



        Address address2 = new Address(
            "45 Kampala Road",
            "Kampala",
            "Central",
            "Uganda"
        );


        Customer customer2 = new Customer(
            "Joel Igwali",
            address2
        );


        Product product3 = new Product(
            "Phone",
            "P003",
            500,
            1
        );


        Product product4 = new Product(
            "Headphones",
            "P004",
            50,
            3
        );


        Order order2 = new Order(customer2);

        order2.AddProduct(product3);
        order2.AddProduct(product4);



        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");


        Console.WriteLine("-------------------------");


        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");

    }
}