using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    internal class SamochodBenzynaPrad : ISamochod, ISamochodPrad, ISamochodBenzyna
    {
        public bool SilnikSpalinowy { get; private set; }
        public bool SilnikElektryczny { get; private set; }
        public bool Bak { get; private set; }
        public bool Akumulator { get; private set; }

        public static SamochodBenzynaPrad Create(
            bool spalinowy = false,
            bool elektryczny = false,
            bool bak = false,
            bool akumulator = false)
        {
            return new SamochodBenzynaPrad
            {
                SilnikSpalinowy = spalinowy,
                SilnikElektryczny = elektryczny,
                Bak = bak,
                Akumulator = akumulator
            };
        }

        public void Uruchom()
        {
            ((ISamochodBenzyna)this).Uruchom();
            ((ISamochodPrad)this).Uruchom();
        }

        public void Wylacz()
        {
            ((ISamochodBenzyna)this).Wylacz();
            ((ISamochodPrad)this).Wylacz();
        }

        public void Tankuj()
        {
            ((ISamochodBenzyna)this).Tankuj();
            ((ISamochodPrad)this).Tankuj();
        }

        public void Jedz()
        {
            bool gotowaBenzyna = SilnikSpalinowy && Bak;
            bool gotowyPrad = SilnikElektryczny && Akumulator;

            if (gotowaBenzyna && gotowyPrad)
                Console.WriteLine("[Hybryda] Samochód jedzie na obu silnikach.");
            else if (gotowaBenzyna)
                Console.WriteLine("[Hybryda] Samochód jedzie na silniku spalinowym.");
            else if (gotowyPrad)
                Console.WriteLine("[Hybryda] Samochód jedzie na silniku elektrycznym.");
            else
                Console.WriteLine("[Hybryda] Nie można jechać (sprawdź silniki i paliwo/akumulator).");
        }

        void ISamochodBenzyna.Uruchom()
        {
            SilnikSpalinowy = true;
            Console.WriteLine("[Hybryda -> Benzyna] Uruchomiono silnik spalinowy.");
        }

        void ISamochodBenzyna.Wylacz()
        {
            SilnikSpalinowy = false;
            Console.WriteLine("[Hybryda -> Benzyna] Wyłączono silnik spalinowy.");
        }

        void ISamochodBenzyna.Tankuj()
        {
            Bak = true;
            Console.WriteLine("[Hybryda -> Benzyna] Zatankowano benzynę.");
        }

        void ISamochodBenzyna.Jedz()
        {
            if (SilnikSpalinowy && Bak)
                Console.WriteLine("[Hybryda -> Benzyna] Samochód jedzie na benzynie.");
            else
                Console.WriteLine("[Hybryda -> Benzyna] Nie można jechać na benzynie (sprawdź silnik spalinowy i bak).");
        }

        void ISamochodPrad.Uruchom()
        {
            SilnikElektryczny = true;
            Console.WriteLine("[Hybryda -> Prąd] Uruchomiono silnik elektryczny.");
        }

        void ISamochodPrad.Wylacz()
        {
            SilnikElektryczny = false;
            Console.WriteLine("[Hybryda -> Prąd] Wyłączono silnik elektryczny.");
        }

        void ISamochodPrad.Tankuj()
        {
            Akumulator = true;
            Console.WriteLine("[Hybryda -> Prąd] Naładowano akumulator.");
        }

        void ISamochodPrad.Jedz()
        {
            if (SilnikElektryczny && Akumulator)
                Console.WriteLine("[Hybryda -> Prąd] Samochód jedzie na prądzie.");
            else
                Console.WriteLine("[Hybryda -> Prąd] Nie można jechać na prądzie (sprawdź silnik elektryczny i akumulator).");
        }
    }
}
