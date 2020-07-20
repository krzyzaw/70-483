using System;

namespace Types.Classes
{
    public class Order
    {
        public Guid Id { get; private set; }

        public Order()
        {
            Id = Guid.NewGuid();
        }
    }
}