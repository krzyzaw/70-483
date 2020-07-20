using System;
using System.Collections.Generic;
using System.Linq;

namespace Types.Generic
{
    public class Generic
    {
        public static void TestGenericTypes()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Adam", "Nowak", 12));

            Console.WriteLine(students.FirstOrDefault());

            List<int> myInts = new List<int>();
            myInts.Add(1);

            int i = myInts[0];

            Console.WriteLine(i);
        }
    }
}