using System;

namespace Types.Interfaces
{
    public interface IOrderProcessor
    {
        void ProcessOrder(string email, Guid orderId);
    }
}