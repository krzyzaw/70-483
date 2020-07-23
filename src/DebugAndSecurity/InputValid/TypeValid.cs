using System;
using System.Globalization;

namespace DebugAndSecurity.InputValid
{
    public class TypeValid
    {
        public static void UseParse()
        {
            string strVal = "98234";
            int value = int.Parse(strVal); // 98234
            Console.WriteLine(value);

            // string strVal = null;
            // int value = int.Parse(strVal); // ArgumentNullException
            //
            // string strVal = "1098.88";
            // int value = int.Parse(strVal);  // FormatException
            //
            // string strVal = "23949283529835923579283592823";
            // int value = int.Parse(strVal);  // OverflowException
        }

        public static void UseConvert()
        {
            // string strVal = "98234";
            // int value = Convert.ToInt32(strVal); // 98234
            //Console.WriteLine(value);

            // string strVal = null;
            // int value = Convert.ToInt32(strVal); // 0
            // Console.WriteLine(value);

            string strVal = "23949283529835923579283592823";
            int value = Convert.ToInt32(strVal);  // OverflowException
        }

        public static void UseTryParse()
        {
            // string strVal = "98234";
            // bool success = int.TryParse(strVal, out int value); // 98234
            // Console.WriteLine($"success: {success}, value: {value}");

            // string strVal = null;
            // bool success = int.TryParse(strVal, out int value);
            // Console.WriteLine($"success: {success}, value: {value}");

            // string strVal = "1098.88";
            // bool success = int.TryParse(strVal, out int value);
            // Console.WriteLine($"success: {success}, value: {value}");

            string strVal = "23949283529835923579283592823";
            bool success = int.TryParse(strVal, out int value);
            Console.WriteLine($"success: {success}, value: {value}");
        }
    }
}