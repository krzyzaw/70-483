using System;
using Types.Classes;
using Types.DataType;
using Types.Extensions;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();
            race.Begin();
            Console.ReadKey();
        }
    }
}
