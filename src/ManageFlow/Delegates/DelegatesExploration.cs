using System;

namespace ManageFlow.Delegates
{
    public class DelegatesExploration
    {
        public delegate int SimpleMath(int x, int y);

        public static void DisplayDelegateInfo(Delegate delegateObj)
        {
            foreach (var d in delegateObj.GetInvocationList())
            {
                Console.WriteLine($"Method name: {d.Method}");
                Console.WriteLine($"Type name: {d.Target}");
            }
        }
    }
}