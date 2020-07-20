using System;

namespace Types.DataType
{
    public struct Value
    {
        public string Name { get; set; }

        public static void TestStruct()
        {
            Value firstValue, secendValue;
            firstValue = new Value();
            
            firstValue.Name = "Pierwszy!";
            secendValue = firstValue;
            secendValue.Name = "Drugi!";

            Console.WriteLine($"Pierwsza struktura nazywa się: {firstValue.Name}");
            Console.WriteLine($"Druga struktura nazywa się: {secendValue.Name}");
        }

        public static void TestDateTime()
        {
            DateTime firstDate = DateTime.Now;
            DateTime secondTime = firstDate;

            firstDate += TimeSpan.FromMinutes(15);
            secondTime -= TimeSpan.FromMinutes(15);

            Console.WriteLine(firstDate);
            Console.WriteLine(secondTime);
        }
    }
}