using System;
using System.Collections.Generic;
using Types.Classes;

namespace Types.Lazy
{
    public class Customer
    {
        private List<Order> OrderList = null;

        public string CustomerName { get; set; }

        public Customer()
        {
            CustomerName = "Pawel";
            OrderList = LoadOrders();
        }

        private List<Order> LoadOrders()
        {
            List<Order> orderList = new List<Order>()
            {
                new Order {OrderNumber = "O123"},
                new Order {OrderNumber = "O433"}
            };

            return orderList;
        }

        public static void Test()
        {
            Customer customer = new Customer();
            Console.WriteLine($"Dane klienta: {customer.CustomerName}");

            foreach (Order order in customer.OrderList)
            {
                Console.WriteLine(order.OrderNumber);
            }
        }
    }
}