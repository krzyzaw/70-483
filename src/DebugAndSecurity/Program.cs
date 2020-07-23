using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using DebugAndSecurity.InputValid;

namespace DebugAndSecurity
{
    class Program
    {
        public static int FoundString;
        public static int FoundRegex;

        static void DoLoop(bool show)
        {
            const int iterations = 1000000;
            var content = "The implementation of String.Contains() willThe implementation of String.Contains() will eventually call the native method IndexOfString() and the implementation of that is only known by Microsoft. However, a good algorithm for implementing this method is using what is known as the Knuth–Morris–Pratt algorithm. The complexity of this algorithm is O(m + n) where m is the length of the string you are searching for and n is the length of the string you are searching making it a very efficient algorithm.The implementation of String.Contains() will eventually call the native method IndexOfString() and the implementation of that is only known by Microsoft. However, a good algorithm for implementing this method is using what is known as the Knuth–Morris–Pratt algorithm. The complexity of this algorithm is O(m + n) where m is the length of the string you are searching for and n is the length of the string you are searching making it a very efficient algorithm.The implementation of String.Contains() will eventually call the native method IndexOfString() and the implementation of that is only known by Microsoft. However, a good algorithm for implementing this method is using what is known as the Knuth–Morris–Pratt algorithm. The complexity of this algorithm is O(m + n) where m is the length of the string you are searching for and n is the length of the string you are searching making it a very efficient algorithm.The implementation of String.Contains() will eventually call the native method IndexOfString() and the implementation of that is only known by Microsoft. However, a good algorithm for implementing this method is using what is known as the Knuth–Morris–Pratt algorithm. The complexity of this algorithm is O(m + n) where m is the length of the string you are searching for and n is the length of the string you are searching making it a very efficient algorithm.The implementation of String.Contains() will eventually call the native method IndexOfString() and the implementation of that is only known by Microsoft. However, a good algorithm for implementing this method is using what is known as the Knuth–Morris–Pratt algorithm. The complexity of this algorithm is O(m + n) where m is the length of the string you are searching for and n is the length of the string you are searching making it a very efficient algorithm.The implementation of String.Contains() will eventually call the native method IndexOfString() and the implementation of that is only known by Microsoft. However, a good algorithm for implementing this method is using what is known as the Knuth–Morris–Pratt algorithm. The complexity of this algorithm is O(m + n) where m is the length of the string you are searching for and n is the length of the string you are searching making it a very efficient algorithm. eventually call the native method IndexOfString() and the implementation of that is only known by Microsoft. However, a good algorithm for implementing this method is using what is known as the Knuth–Morris–Pratt algorithm. The complexity of this algorithm is O(m + n) where m is the length of the string you are searching for and n is the length of the string you are searching making it a very efficient algorithm. this exists in file";

            const string searchString = "this exists in file";
            var searchRegex = new Regex("this exists in file");

            var containsTimer = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                if (content.Contains(searchString))
                {
                    FoundString++;
                }
            }
            containsTimer.Stop();

            var regexTimer = Stopwatch.StartNew();
            for (var i = 0; i < iterations; i++)
            {
                if (searchRegex.IsMatch(content))
                {
                    FoundRegex++;
                }
            }
            regexTimer.Stop();

            if (!show) return;

            Console.WriteLine("FoundString: {0}", FoundString);
            Console.WriteLine("FoundRegex: {0}", FoundRegex);
            Console.WriteLine("containsTimer: {0}", containsTimer.ElapsedMilliseconds);
            Console.WriteLine("regexTimer: {0}", regexTimer.ElapsedMilliseconds);

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            DoLoop(false);
            DoLoop(true);
            return;
        }
    }
}
