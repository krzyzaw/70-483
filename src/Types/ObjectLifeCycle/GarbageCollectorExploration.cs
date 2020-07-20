using System;

namespace Types.ObjectLifeCycle
{
    public class GarbageCollectorExploration
    {
        public static void TestGcCar()
        {
            Car refToMyCar = new Car("Ford", 100);
            Console.WriteLine(refToMyCar.ToString());

            Console.ReadKey();
        }

        public static void CreateCar()
        {
            // Jeśli myCar to jedyna referencja do obiektu Car,
            // *może* zostać zniszczona po ukończeniu tej metody.

            Car myCar = new Car("Ford", 100);
        }

        public static void TestGcMethods()
        {
            // Wyświetl szacowaną liczbę bajtów na stercie.
            Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));

            // MaxGeneration zaczyna się od 0, więc wyświetlając, dodaj 1.
            Console.WriteLine("This OS has {0} object generations.\n", (GC.MaxGeneration + 1));

            Car myCar = new Car("Ford", 100);
            // Wyświetl generację obiektu myCar.
            Console.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(myCar) + 1);
        }

        public static void TryRunGc()
        {
            // Wyświetl szacowaną liczbę bajtów na stercie.
            Console.WriteLine("Estimated bytes on heap: {0}", GC.GetTotalMemory(false));
            // MaxGeneration zaczyna się od 0.
            Console.WriteLine("This OS has {0} object generations.\n", (GC.MaxGeneration + 1));

            Car refToMyCar = new Car("Ford", 100);
            Console.WriteLine(refToMyCar.ToString());

            // Wyświetl generację obiektu refToMyCar.
            Console.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));

            // Utwórz mnóstwo obiektów do testu.
            object[] tonsOfObjects = new object[50000];
            for (int i = 0; i < 50000; i++)
                tonsOfObjects[i] = new object();

            // Usuwaj tylko obiekty należące do generacji 0.
            GC.Collect(0, GCCollectionMode.Forced);
            GC.WaitForPendingFinalizers();
            // Wyświetl generację obiektu refToMyCar.
            Console.WriteLine("Generation of refToMyCar is: {0}", GC.GetGeneration(refToMyCar));

            // Sprawdź, czy tonsOfObjects[9000] jeszcze żyje.
            if (tonsOfObjects[9000] != null)
                Console.WriteLine("Generation of tonsOfObjects[9000] is: {0}", GC.GetGeneration(tonsOfObjects[9000]));
            else
                Console.WriteLine("tonsOfObjects[9000] is no longer alive.");

            // Wyświetl, ile razy dana generacja była sprzątana.
            Console.WriteLine("Gen 0 has been swept {0} times", GC.CollectionCount(0));
            Console.WriteLine("Gen 1 has been swept {0} times", GC.CollectionCount(1));
            Console.WriteLine("Gen 2 has been swept {0} times", GC.CollectionCount(2));
        }

        class Person
        {
            long[] personArray = new long[100000000];
        }

        public static void Test()
        {
            for (int i = 0; i < 10000000000000; i++)
            {
                Person p = new Person();
                System.Threading.Thread.Sleep(3);
            }
        }
    }
}