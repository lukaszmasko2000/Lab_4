using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    internal class SamochodPrad : ISamochod, ISamochodPrad
    {
        public bool SilnikElektryczny { get; private set; }
        public bool Akumulator { get; private set; }

        public static SamochodPrad Create(bool s = false, bool a = false)
        {
            return new SamochodPrad
            {
                SilnikElektryczny = s,
                Akumulator = a
            };
        }

        public void Uruchom()
        {
            SilnikElektryczny = true;
            Console.WriteLine("[Prąd] Uruchomiono silnik elektryczny.");
        }

        public void Wylacz()
        {
            SilnikElektryczny = false;
            Console.WriteLine("[Prąd] Wyłączono silnik elektryczny.");
        }

        public void Tankuj()
        {
            Akumulator = true;
            Console.WriteLine("[Prąd] Naładowano akumulator.");
        }

        public void Jedz()
        {
            if (SilnikElektryczny && Akumulator)
                Console.WriteLine("[Prąd] Samochód jedzie na prądzie.");
            else
                Console.WriteLine("[Prąd] Nie można jechać (sprawdź silnik elektryczny i akumulator).");
        }
    }
    
}
