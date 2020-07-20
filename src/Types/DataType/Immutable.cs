using System;

namespace Types.DataType
{
    public class Immutable
    {
        public static void StringImmutableExample()
        {
            string str = "Hello";
            str.Replace("l", "o");

            Console.WriteLine(str);
        }
    }
}