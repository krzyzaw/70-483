using System;

namespace Types.DataType
{
    public class Reference
    {
        public string Name { get; set; }

        public static void TestRef()
        {
            Reference firstRef, secondRef;
            firstRef = new Reference();

            firstRef.Name = "Pierwszy!";
            secondRef = firstRef;
            secondRef.Name = "Drugi!";

            Console.WriteLine($"Pierwszy obiekt nazywa się: {firstRef.Name}");
            Console.WriteLine($"Drugi obiekt nazywa się: {secondRef.Name}");
        }

        public static void PersonManipulation()
        {
            Person person = new Person { Name = "Test" };
            Person secondPerson = person;

            secondPerson.Name = "Nowe imie";

            Console.WriteLine(secondPerson.Name);
            Console.WriteLine(person.Name);

            secondPerson = null;

            Console.WriteLine(secondPerson.Name);
            Console.WriteLine(person.Name);
        }

        internal class Person
        {
            public string Name { get; set; }
        }
    }
}