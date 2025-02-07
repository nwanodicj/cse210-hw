using System;
using System.Security.Cryptography.X509Certificates;


namespace OnlineOrdering;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("");
        Console.WriteLine("         __Oder From USA__");
        Console.WriteLine("");
        Order OrderFromUSA = new Order("Williams Ress", "003 Salt Lake St");
        OrderFromUSA.AddItem(new OrderItem("Laptop", 999.99m, 1));
        OrderFromUSA.AddItem(new OrderItem("Mouse", 19.90m, 2));
        OrderFromUSA.PrintOrder();
        Console.WriteLine("");

        Console.WriteLine("");
        Order OrderFromUSA2 = new Order("Williams Ress", "007 Idaho Campus St");
        OrderFromUSA2.AddItem(new OrderItem("Shoes", 25.00m, 2));
        OrderFromUSA2.AddItem(new OrderItem("T-Shirt", 12.00m, 2));
        OrderFromUSA2.PrintOrder();
        Console.WriteLine("");



        Console.WriteLine("");
        Console.WriteLine("         __Oder From Outside USA__");
        Console.WriteLine("");
        Order2 OrderFromOutSideUSA = new Order2("John Doe", "123 Main St");
        OrderFromOutSideUSA.AddItem(new OrderItem("Desktop", 50.00m, 1));
        OrderFromOutSideUSA.AddItem(new OrderItem("Keyboard", 10.00m, 2));
        OrderFromOutSideUSA.PrintOrder2();
        Console.WriteLine("");

        Console.WriteLine("");
        Order2 OrderFromOutSideUSA2 = new Order2("Jameson Habert", "045 Abuja St");
        OrderFromOutSideUSA2.AddItem(new OrderItem("Samsong Phone", 100.00m, 1));
        OrderFromOutSideUSA2.AddItem(new OrderItem("Eva Wine", 5.00m, 2));
        OrderFromOutSideUSA2.PrintOrder2();
        Console.WriteLine("");
    }
}