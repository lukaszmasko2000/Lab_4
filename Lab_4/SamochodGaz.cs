using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    internal class SamochodGaz : ISamochod, ISamochodGaz
    {
        public bool SilnikSpalinowy { get; private set; }
        public bool Butla { get; private set; }

        public static SamochodGaz Create(bool s = false, bool b = false)
        {
            return new SamochodGaz
            {
                SilnikSpalinowy = s,
                Butla = b
            };
        }

        public void Uruchom()
        {
            SilnikSpalinowy = true;
            Console.WriteLine("[Gaz] Uruchomiono silnik spalinowy.");
        }

        public void Wylacz()
        {
            SilnikSpalinowy = false;
            Console.WriteLine("[Gaz] Wyłączono silnik spalinowy.");
        }

        public void Tankuj()
        {
            Butla = true;
            Console.WriteLine("[Gaz] Zatankowano gaz do butli.");
        }

        public void Jedz()
        {
            if (SilnikSpalinowy && Butla)
                Console.WriteLine("[Gaz] Samochód jedzie na gazie.");
            else
                Console.WriteLine("[Gaz] Nie można jechać (sprawdź silnik spalinowy i butlę).");
        }
    }
}
