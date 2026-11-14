using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    internal class SamochodBenzynaGaz : ISamochod , ISamochodGaz, ISamochodBenzyna
    {
        public bool SilnikSpalinowy { get; private set; }
        public bool Bak { get; private set; }
        public bool Butla { get; private set; }

        public static SamochodBenzynaGaz Create(bool s = false, bool bak = false, bool butla = false)
        {
            return new SamochodBenzynaGaz
            {
                SilnikSpalinowy = s,
                Bak = bak,
                Butla = butla
            };
        }

        public void Uruchom()
        {
            SilnikSpalinowy = true;
            Console.WriteLine("[Benzyna+Gaz] Uruchomiono silnik spalinowy.");
        }

        public void Wylacz()
        {
            SilnikSpalinowy = false;
            Console.WriteLine("[Benzyna+Gaz] Wyłączono silnik spalinowy.");
        }

        public void Tankuj()
        {
            ((ISamochodBenzyna)this).Tankuj();
            ((ISamochodGaz)this).Tankuj();
        }

        public void Jedz()
        {
            if (SilnikSpalinowy && (Bak || Butla))
                Console.WriteLine($"[Benzyna+Gaz] Samochód jedzie (paliwo: {(Butla ? "Gaz" : "Benzyna")}).");
            else
                Console.WriteLine("[Benzyna+Gaz] Nie można jechać (brak paliwa lub wyłączony silnik).");
        }

        void ISamochodBenzyna.Tankuj()
        {
            Bak = true;
            Console.WriteLine("[Benzyna+Gaz -> Benzyna] Zatankowano benzynę do baku.");
        }

        void ISamochodBenzyna.Jedz()
        {
            if (SilnikSpalinowy && Bak)
                Console.WriteLine("[Benzyna+Gaz -> Benzyna] Samochód jedzie na benzynie.");
            else
                Console.WriteLine("[Benzyna+Gaz -> Benzyna] Nie można jechać na benzynie (sprawdź silnik i bak).");
        }

        void ISamochodGaz.Tankuj()
        {
            Butla = true;
            Console.WriteLine("[Benzyna+Gaz -> Gaz] Zatankowano gaz do butli.");
        }

        void ISamochodGaz.Jedz()
        {
            if (SilnikSpalinowy && Butla)
                Console.WriteLine("[Benzyna+Gaz -> Gaz] Samochód jedzie na gazie.");
            else
                Console.WriteLine("[Benzyna+Gaz -> Gaz] Nie można jechać na gazie (sprawdź silnik i butlę).");
        }
    }
}
