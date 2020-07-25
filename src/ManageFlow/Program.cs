using System;
using ManageFlow.Delegates;
using ManageFlow.Methods;

namespace ManageFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethod testMethod = new TestMethod();
            DelegatesExploration.SimpleMath simpleMath = new DelegatesExploration.SimpleMath(testMethod.Add);

            //Wywołanie metody Add() pośrednio, używając obiektu delegatu (pod spodem wywoływana jest metoda Invoke() -> ildasm)
            Console.WriteLine($"10 + 20 = {simpleMath(10, 20)}");
            DelegatesExploration.DisplayDelegateInfo(simpleMath);

            Console.ReadKey();
        }
    }
}
