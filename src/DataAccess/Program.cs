using System;
using DataAccess.ConsumeData;
using DataAccess.Http;
using DataAccess.SqlClient;
using DataAccess.Streams;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            DataConsumer.TestJson();
            DataConsumer.TestXml();

            Console.ReadKey();
        }
    }
}
