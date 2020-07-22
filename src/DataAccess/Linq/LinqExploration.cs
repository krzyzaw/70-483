using System;
using System.Collections.Generic;
using System.Reflection;

namespace DataAccess.Linq
{
    public class LinqExploration
    {
        public static void DeclareImplicitVars()
        {
            // Niejawna typizacja zmiennych lokalnych.
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Wyświetl typ bazowy.
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }

        public static void LambdaExpressionSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Wyrażenie lambda.
            List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);

            Console.WriteLine("Here are your even numbers:");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }

            Console.WriteLine();
        }

        public static void TestExtension()
        {
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();
            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();
            Console.ReadLine();
        }

        public static void TestAnonymousType()
        {
            var purchaseItem = new
            {
                TimeBought = DateTime.Now,
                ItemBought = new { Color = "Red", Make = "Saab", CurrentSpeed = 55 },
                Price = 34.000
            };
        }
    }

    static class ObjectExtensions
    {
        // Zdefiniuj metodę rozszerzającą dla typu System.Object.
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here:\n\t->{1}\n", obj.GetType().Name,
                Assembly.GetAssembly(obj.GetType()));
        }
    }
}