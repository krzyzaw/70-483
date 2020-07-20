using System;
using System.Collections.Generic;

namespace Types.Lazy
{
    public class CustomerLazyLoading
    {
        public Lazy<List<Order>> OrdersList;
        public string CustomerName { get; set; }

        // Właściwość dzięki, której załadujemy dane do listy na żądanie
        public List<Order> OrdersProperty => OrdersList.Value;

        public CustomerLazyLoading()
        {
            CustomerName = "Jan";
            OrdersList = new Lazy<List<Order>>(() => LoadOrders());
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
            CustomerLazyLoading customer = new CustomerLazyLoading();
            Console.WriteLine($"Dane klienta: {customer.CustomerName}");

            foreach (Order order in customer.OrdersList.Value)
            {
                Console.WriteLine(order.OrderNumber);
            }
        }
    }
}