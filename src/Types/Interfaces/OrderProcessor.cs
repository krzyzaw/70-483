using System;
using System.Runtime.InteropServices.ComTypes;
using Types.Classes;

namespace Types.Interfaces
{
    public class OrderProcessor : IOrderProcessor
    {
        private readonly IDatabase _database;
        private readonly IEmailSender _emailSender;

        public OrderProcessor(IDatabase database, EmailSender emailSender)
        {
            _database = database;
            _emailSender = emailSender;
        }

        public void ProcessOrder(string email, Guid orderId)
        {
            User user = _database.GetUser("user@email.com");
            Order order = _database.GetOrder(new Guid());
            user.PurchaseOrder(order);

            _database.SaveChange();
            _emailSender.SendEmail("user@email.com", $"order number {order.Id}", "message");
        }
    }
}