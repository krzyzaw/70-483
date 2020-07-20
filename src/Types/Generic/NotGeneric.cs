using System;
using System.Collections;

namespace Types.Generic
{
    public class NotGeneric
    {
        public static void WorkWithArrayList()
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(15);
            myInts.Add(20);

            int i = (int) myInts[0];

            Console.WriteLine(myInts[0]);
        }

        public static void WorkWithStudentCollection()
        {
            StudentCollection studentCollection = new StudentCollection();

            studentCollection.AddStudent(new Student("Jan", "Kowalski", 23));
            studentCollection.GetStudent(0);
        }
    }
}