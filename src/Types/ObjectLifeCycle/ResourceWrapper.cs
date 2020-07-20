using System;

namespace Types.ObjectLifeCycle
{
    public class ResourceWrapper
    {
        ~ResourceWrapper()
        {
            // Tutaj posprzątaj niezarządzane zasoby. Należaloby podać wskaźniki do refernecji zasobów przetrzymywanych na stercie.
            // Po zniszczeniu wyemituj sygnał dźwiękowy (tylko dla testu!)
            Console.Beep();
        }

        public static void Test()
        {
            ResourceWrapper rw = new ResourceWrapper();
        }
    }
}