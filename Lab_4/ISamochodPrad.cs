using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4 
{
    public interface ISamochodPrad
    {
        void Uruchom();
        void Wylacz();
        void Tankuj();
        void Jedz();
        bool SilnikElektryczny { get; }
        bool Akumulator { get; }
    }
}
