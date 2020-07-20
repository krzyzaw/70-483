using System;
using Types.Classes;

namespace Types.Interfaces
{
    public interface IDatabase
    {
        bool IsConnected { get; }

        void Connect();

        User GetUser(string email);

        Order GetOrder(Guid id);

        void SaveChange();
    }
}