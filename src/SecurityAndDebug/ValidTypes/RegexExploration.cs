using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace SecurityAndDebug.ValidTypes
{
    public class RegexExploration
    {
        public static void RegexIsMatch()
        {
            var words = new List<string>() { "Seven", "even",
                "Maven", "Amen", "eleven" };

            var rx = new Regex(@".even");

            foreach (var word in words)
            {
                Console.WriteLine(rx.IsMatch(word)
                    ? $"{word} does match"
                    : $"{word} does not match");
            }
        }

        public static void RegexMatch()
        {
            var content = @"Foxes are omnivorous mammals belonging to several genera 
                            of the family Canidae. Foxes have a flattened skull, upright triangular ears, 
                            a pointed, slightly upturned snout, and a long bushy tail. Foxes live on every 
                            continent except Antarctica. By far the most common and widespread species of 
                            fox is the red fox.";

            var rx = new Regex(@"\w+", RegexOptions.IgnoreCase);

            var matches = rx.Matches(content);
            Console.WriteLine(matches.Count);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }

        public static void RegexReplace()
        {
            string input = "Rob      Mary     David        Jenny    Chris   Imogen   Rodney";
            string regularExpressionToMatch = " +";
            string patternToReplace = ", ";
            string replaced = Regex.Replace(input, regularExpressionToMatch, patternToReplace);
            Console.WriteLine(replaced);
        }


        public static void EmailRegex()
        {
            var regEmail = new Regex(@"[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]{2,}");
            var testEmail = "test@test.pl";
            Console.WriteLine($"{testEmail} is valid email: {regEmail.IsMatch(testEmail)}");
        }
    }
}