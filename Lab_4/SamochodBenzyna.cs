using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    internal class SamochodBenzyna : ISamochod, ISamochodBenzyna
    {
        public static SamochodBenzyna Create(bool s = false, bool b = false)
        {
            return new SamochodBenzyna
            {
                SilnikSpalinowy = s,
                Bak = b
            };
        }
        public bool SilnikSpalinowy { get; private set; }
        public bool Bak { get; private set; }

        public void Uruchom()
        {
            SilnikSpalinowy = true;
            Console.WriteLine("[Benzyna] Uruchomiono silnik spalinowy.");
        }

        public void Wylacz()
        {
            SilnikSpalinowy = false;
            Console.WriteLine("[Benzyna] Wyłączono silnik spalinowy.");
        }

        public void Tankuj()
        {
            Bak = true;
            Console.WriteLine("[Benzyna] Zatankowano benzynę do baku.");
        }

        public void Jedz()
        {
            if (SilnikSpalinowy && Bak)
                Console.WriteLine("[Benzyna] Samochód jedzie na benzynie.");
            else
                Console.WriteLine("[Benzyna] Nie można jechać (sprawdź silnik spalinowy i poziom benzyny).");
        }
    }
}
