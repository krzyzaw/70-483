using System;
using System.IO;
using System.Text;

namespace Types.Strings
{
    public class StringExploration
    {
        public static void TestStringBuilder()
        {
            string firstName = "Rob";
            string secondName = "Miles";

            StringBuilder fullNameBuilder = new StringBuilder();
            fullNameBuilder.Append(firstName);
            fullNameBuilder.Append(" ");
            fullNameBuilder.Append(secondName);
            Console.WriteLine(fullNameBuilder.ToString());
        }

        public static void TestStringWriter()
        {
            StringWriter writer = new StringWriter();
            writer.Write("Rob");
            writer.Write(" Miles");
            writer.Close();
            Console.Write(writer.ToString());
        }

        public static void TestStringReader()
        {
            string dataString = @"Rob Miles 21";
            StringReader dataStringReader = new StringReader(dataString);
            string name = dataStringReader.ReadLine();
            int age = int.Parse(dataStringReader.ReadLine());
            dataStringReader.Close();
            Console.WriteLine("Name: {0} Age: {1}", name, age);
        }

        public static void TestContains()
        {
            string input = "      Rob Miles";
            if (input.Contains("Rob"))
            {
                Console.WriteLine("Input contains Rob");
            }
        }

        public static void TestStartWith()
        {
            string input = "      Rob Miles";

            string trimmedString = input.Trim();

            if (trimmedString.StartsWith("Rob"))
            {
                Console.WriteLine("Start with Rob");
            }
        }

        public static void TestEndWith()
        {
            string input = "      Rob Miles";
            if (input.EndsWith("Miles"))
            {
                Console.WriteLine("End with Miles");
            }
        }

        public static void TestSplit()
        {
            string data = "there is a cat";
            string[] words = data.Split(' ');

            foreach (string word in words)
            {
                Console.WriteLine("WORD: " + word);
            }
        }

        public static void TestSubstring()
        {
            string input = "    One Two Three";
            int subStart = input.IndexOf("Two");
            string sub = input.Substring(subStart, 3);
            Console.WriteLine("Substring: {0}", sub);
        }
    }
}