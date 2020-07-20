namespace Types.Interfaces
{
    public class BankAccount : IAccount
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
    }
}