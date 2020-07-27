using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ManageFlow.Exceptions
{
    public class Exceptions
    {
        public static void Test()
        {
            Bus myBus = new Bus("70a", 40);
            myBus.TurnOnRadio();

            try
            {
                for (int i = 0; i < 10; i++)
                    myBus.Accelerate(10);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n*** TargetSite: ***");
                Console.WriteLine("Member name: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);

                Console.WriteLine("\n*** StackTrace: ***");
                Console.WriteLine("Stack: {0}", e.StackTrace);

                Console.WriteLine("\n*** Help link: ***");
                Console.WriteLine("Help Link: {0}", e.HelpLink);

                Console.WriteLine("\n*** Custom Data: ***");
                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
            }
        }
    }
}