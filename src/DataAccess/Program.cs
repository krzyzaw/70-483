using System;
using DataAccess.Http;
using DataAccess.SqlClient;
using DataAccess.Streams;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlClientExploration.SqlInjectionExample();
            Console.ReadKey();
        }
    }
}
