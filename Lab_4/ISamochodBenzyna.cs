using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    public interface ISamochodBenzyna
    {
        void Uruchom();
        void Wylacz();
        void Tankuj();
        void Jedz();
        bool SilnikSpalinowy { get; }
        bool Bak { get; }
    }
}
