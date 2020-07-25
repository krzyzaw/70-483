using System;
using Microsoft.VisualBasic.CompilerServices;

namespace ManageFlow.Methods
{
    public class TestMethod
    {
        public int Add(int x, int y)
            => x + y;

        public static void Add(int x, int y, out int ans)
            => ans = x + y;

        public static void ReturnManyValue(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        public static double CalculateAverage(string stringParam, params double[] values)
        {
            Console.WriteLine($"You sent me {values.Length} doubles.");
            double sum = 0;
            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }
    }
}