namespace Types.Interfaces
{
    public class BabyAccount : BankAccount, IAccount
    {
        public BabyAccount(int initialBalance) : base(initialBalance)
        {
        }

        bool IAccount.WithdrawFunds(decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }

            if (_balance < amount)
            {
                return false;
            }

            _balance = _balance - amount;
            return true;
        }
    }
}