using System;

namespace Types.ObjectLifeCycle
{
    public class ComboResourceWrapper : IDisposable
    {
        // Odśmiecacz wywoła tę metodę, jeśli użytkownik obiektu
        // zapomni wywołać metodę Dispose().
        ~ComboResourceWrapper()
        {
            // Posprzątaj wszystkie wewnętrzne niezarządzane zasoby.
            // NIE wywołuj Dispose() względem żadnych obiektów zarządzanych.
        }

        // Użytkownik obiektu wywoła tę metodę,
        // aby posprzątać zasoby najszybciej jak to możliwe.
        public void Dispose()
        {
            // Tutaj posprzątaj niezarządzane zasoby.
            // Wywołaj Dispose() względem innych wewnętrznych obiektów usuwalnych.
            // Nie musisz finalizować, jeśli użytkownik wywołał Dispose(),
            // więc odwołaj finalizację.
            GC.SuppressFinalize(this);
        }
    }
}