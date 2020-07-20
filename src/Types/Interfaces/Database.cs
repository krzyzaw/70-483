using System;
using Types.Classes;

namespace Types.Interfaces
{
    public class Database : IDatabase
    {
        public bool IsConnected { get; }
        public void Connect()
        {
            throw new NotImplementedException();
        }

        public User GetUser(string email)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }
    }
}