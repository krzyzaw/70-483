using System;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess.DataCollection
{
    public class DataCollection
    {
        public static void UseArray()
        {
            int[] intArray = new int[5];
            intArray[0] = 5;
            intArray[4] = 100;
           // intArray[5] = 100;

            var newIntArray = new int[] { 1, 2, 3, 4 };
        }

        public static void UseArrayList()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("test");

            foreach (var element in arrayList)
            {
                Console.WriteLine(element);
            }
        }

        public static void UseQueue()
        {
            Queue queue = new Queue();

            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
                Console.WriteLine($"Dodany {i}");
            }

            while (queue.Count > 0)
            {
                Console.WriteLine($"Wyciągnięty: {queue.Dequeue()}");
            }
        }

        public static void UseStack()
        {
            Stack stack = new Stack();

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
                Console.WriteLine($"Dodany {i}");
            }

            while (stack.Count > 0)
            {
                Console.WriteLine($"Wyciągnięty: {stack.Pop()}");
            }
        }

        public static void UseHashSet()
        {
            HashSet<string> musicStyle = new HashSet<string>();
            musicStyle.Add("Pop");
            musicStyle.Add("Disco");
            musicStyle.Add("Pop");

            Console.WriteLine(musicStyle.Count);
        }

        public static void UseHashTable()
        {
            Hashtable year = new Hashtable();

            year["Batman"] = 1989;
            year["Batman Returns"] = 1992;
            year["Batman Forever"] = 1995;

            foreach (DictionaryEntry dictionaryEntry in year)
            {
                string name = dictionaryEntry.Key as string;
                int release = (int)dictionaryEntry.Value;
                Console.WriteLine($"Name: {name}, Release year: {release}");
            }
        }

        public static void UseSortedList()
        {
            SortedList year = new SortedList();

            year["Batman"] = 1989;
            year["Batman Returns"] = 1992;
            year["Batman Forever"] = 1995;

            foreach (DictionaryEntry dictionaryEntry in year)
            {
                string name = dictionaryEntry.Key as string;
                int release = (int)dictionaryEntry.Value;
                Console.WriteLine($"Name: {name}, Release year: {release}");
            }
        }
    }
}