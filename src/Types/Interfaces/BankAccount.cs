using System;
using System.Collections.Generic;

namespace Types.Interfaces
{
    public class BankAccount : IAccount, IComparable
    {
        protected decimal _balance;

        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        public virtual bool WithdrawFunds(decimal amount)
        {
            if (_balance < amount)
            {
                return false;
            }

            _balance = _balance - amount;
            return true;
        }

        public void PayInFunds(decimal amount)
        {
            _balance = _balance + amount;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null) return 1;

            IAccount account = obj as IAccount;

            if (account == null)
            {
                throw new ArgumentException("Object is not an account");
            }

            return _balance.CompareTo(account.GetBalance());
        }

        public static void SortAccount()
        {
            List<BankAccount> accounts = new List<BankAccount>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                BankAccount account = new BankAccount(random.Next(0, 100000));
                accounts.Add(account);
            }

            accounts.Sort();

            foreach (var account in accounts)
            {
                Console.WriteLine(account.GetBalance());
            }
        }
    }
}