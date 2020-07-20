using System;
using Types.DataType;
using Types.Extensions;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Value.TestStruct();
            Value.TestDateTime();
            Console.WriteLine(OrderType.Standard.GetDescription());
            Console.ReadKey();
        }
    }
}
