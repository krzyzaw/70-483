using Microsoft.VisualBasic.CompilerServices;

namespace ManageFlow.Methods
{
    public class TestMethod
    {
        public static int Add(int x, int y)
            => x + y;

        public static void Add(int x, int y, out int ans)
            => ans = x + y;

        public static void ReturnManyValue(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }

        public static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }
    }
}