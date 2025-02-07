using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OnlineOrdering
{
    public class Order
    {
        private List<OrderItem> _items;
        private string _customerName;
        private string _address;

        public Order(string customerName, string address)
        {
            _customerName = customerName;
            _address = address;
            _items = new List<OrderItem>();
        }

        public void AddItem(OrderItem item)
        {
            _items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            _items.Remove(item);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }

        public decimal GetShippingPrice()
        {
            decimal CostOfShipping = 5;
            if (CostOfShipping == 5)
            {
                
            }
            return CostOfShipping;
        }

        public void PrintOrder()
        {
            Console.WriteLine($"Order for {_customerName}");
            Console.WriteLine($"Shipping to: {_address}");
            Console.WriteLine($"Cost of shipping: {GetShippingPrice():C}");
            Console.WriteLine("Items:");
            foreach (var item in _items)
            {
                Console.WriteLine($"{item.Name} - {item.Quantity} x {item.Price:C}");
            }
            Console.WriteLine($"Total Cost of Products: {GetTotalPrice():C}");
            Console.WriteLine("");
            Console.WriteLine("Total cost of product + Cost of shipping");
            Console.WriteLine($"Grand Total: {GetTotalPrice() + GetShippingPrice()}");
        }
    }

    public class Order2
    {
        private List<OrderItem> _items2;
        private string _customerName2;
        private string _address2;

        public Order2(string customerName2, string address2)
        {
            _customerName2 = customerName2;
            _address2 = address2;
            _items2 = new List<OrderItem>();
        }

        public void AddItem(OrderItem item2)
        {
            _items2.Add(item2);
        }

        public void RemoveItem(OrderItem item2)
        {
            _items2.Remove(item2);
        }

        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var item in _items2)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }

        public decimal GetShippingPrice2()
        {
            decimal CostOfShipping2 = 35;

            return CostOfShipping2;
        }

        public void PrintOrder2()
        {
            Console.WriteLine($"Order for {_customerName2}");
            Console.WriteLine($"Shipping to: {_address2}");
            Console.WriteLine($"Cost of shipping: {GetShippingPrice2():C}");
            Console.WriteLine("Items:");
            foreach (var item2 in _items2)
            {
                Console.WriteLine($"{item2.Name} - {item2.Quantity} x {item2.Price:C}");
            }
            Console.WriteLine($"Total Cost of Products: {GetTotalPrice():C}");
            Console.WriteLine("");
            Console.WriteLine("Total cost of product + Cost of shipping");
            Console.WriteLine($"Grand Total: {GetTotalPrice() + GetShippingPrice2()}");
        }
    }

    public class OrderItem
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public OrderItem(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Order order = new Order("John Doe", "123 Main St");
    //        order.AddItem(new OrderItem("Laptop", 999.99m, 1));
    //        order.AddItem(new OrderItem("Mouse", 19.99m, 2));
    //        order.PrintOrder();
    //    }
    //}
}