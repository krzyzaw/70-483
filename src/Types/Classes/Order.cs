using System;

namespace Types.Classes
{
    public class Order
    {
        public Guid Id { get; private set; }

        public decimal Price { get; private set; }

        public decimal TaxRate { get; } = 0.23M;

        public decimal TotalPrice => (1 + TaxRate) * Price;

        public bool IsPurchased { get; private set; }

        public Order(decimal price)
        {
            if (price <= 0)
                throw new Exception("Price must be greater than 0.");

            Id = Guid.NewGuid();
            Price = price;
        }

        public void Purchase()
        {
            if (IsPurchased)
                throw new Exception("Order was already purchased.");

            IsPurchased = true;
        }
    }
}