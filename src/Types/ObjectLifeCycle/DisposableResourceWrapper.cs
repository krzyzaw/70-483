using System;

namespace Types.ObjectLifeCycle
{
    public class DisposableResourceWrapper : IDisposable
    {
        public void Dispose()
        {
            // Posprzątaj niezarządzane zasoby...

            // Usuń inne zawarte obiekty usuwalne...
            Console.Beep();
        }

        public static void Test()
        {
            DisposableResourceWrapper rw = new DisposableResourceWrapper();
            rw.Dispose();
        }
    }
}