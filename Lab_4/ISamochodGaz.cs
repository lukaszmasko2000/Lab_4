using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    public interface ISamochodGaz
    {
        void Uruchom();
        void Wylacz();
        void Tankuj();
        void Jedz();
        bool SilnikSpalinowy { get; }
        bool Butla { get; }
    }
}
