using System;

namespace Types.Classes
{
    public class User
    {
        public static int MinAge = 13;

        public string Email { get; private set; }

        public string Password { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public bool IsActive { get; private set; }

        public DateTime UpdatedAt { get; set; }

        public decimal Funds { get; private set; }

        public User(string email, string password, int age)
        {
            SetEmail(email);
            SetPassword(password);
            SetAge(age);
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                throw new Exception("Email is incorrect.");

            if (Email == email)
                return;

            Email = email;
            Update();
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new Exception("Password is incorrect.");

            if (Password == password)
                return;

            Password = password;
            Update();
        }

        public void SetAge(int age)
        {
            if (age < MinAge)
                throw new Exception($"Age must be greater or equal to {MinAge}");

            if (Age == age)
                return;

            Age = age;
            Update();
        }

        public void SetActive(bool isActive)
        {
            //częste łamanie SRP ponieważ w zależności od tego co przekarzemy wykonuje się jedna lub druga ścieżka
        }

        public void Activate()
        {
            if (IsActive)
                return;

            IsActive = true;
        }

        public void Deactivate()
        {
            if (!IsActive)
                return;

            IsActive = false;
        }

        public void IncreaseFunds(decimal funds)
        {
            if (funds <= 0)
                throw new Exception("Funds must be greater than 0.");

            Funds += funds;
            Update();
        }

        public void PurchaseOrder(Order order)
        {
            if (!IsActive)
                throw new Exception("Only active user can purchase an order.");

            if (Funds - order.TotalPrice < 0)
                throw new Exception("You don't have enough money.");

            order.Purchase();
            Funds -= order.TotalPrice;
            Update();
        }

        private void Update()
        {
            UpdatedAt = DateTime.Now;
        }
    }
}