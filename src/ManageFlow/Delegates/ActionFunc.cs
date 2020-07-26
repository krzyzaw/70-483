using System;
using ManageFlow.Methods;

namespace ManageFlow.Delegates
{
    public class ActionFunc
    {
        public static void TestAction()
        {
            Action<string, ConsoleColor, int> action = new Action<string, ConsoleColor, int>(DisplayMessage);

            action.Invoke("Action message", ConsoleColor.Blue, 5);
        }

        public static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;
            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            Console.ForegroundColor = previous;
        }
    }
}