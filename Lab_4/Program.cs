using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = SamochodBenzynaPrad.Create();
            var bieda = SamochodBenzynaGaz.Create();

            car.Uruchom();                      // uruchamia oba silniki
            car.Wylacz();
            ((ISamochod)car).Uruchom();         // uruchamia oba silniki
            car.Wylacz();
            ((ISamochodPrad)car).Uruchom();    // uruchamia tylko silnik elektryczny
            Console.ReadLine();

            bieda.Uruchom();
            bieda.Wylacz();
            ((ISamochodGaz)bieda).Uruchom();
            bieda.Tankuj();
            ((ISamochodGaz)bieda).Jedz();
            Console.ReadLine();

        }
    }
}
