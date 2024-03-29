﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace ManageFlow.Loops
{
    public class LoopsExploration
    {
        public static void TestFor()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Numbers is {i}");
            }
        }

        public static void TestForeach()
        {
            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
            {
                Console.WriteLine(c);
            }
        }

        public static void TestWhile()
        {
            string userIsDone = "";

            while (userIsDone?.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                userIsDone = Console.ReadLine();
            }
        }

        public static void TestDoWhile()
        {
            string userIsDone = "";

            do
            {
                Console.WriteLine("In do/while loop");
                userIsDone = Console.ReadLine();
            } while (userIsDone?.ToLower() != "yes");
        }

        public static void TestBrakeStatement()
        {
            string[] names = { "Adam", "Jan", "Ewa", "Maria" };

            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine(names[index]);
                if (names[index] == "Ewa") break;
            }
        }

        public static void TestContinueStatement()
        {
            string[] names = { "Adam", "Jan", "Ewa", "Maria" };

            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine(names[index]);
                if (names[index] == "Ewa") continue;

                Console.WriteLine(names[index]);
            }
        }
    }
}