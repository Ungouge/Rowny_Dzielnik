using System;

using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.TabelaNaleznosci
{
    partial class TabelaNaleznosciPienieznej
    {
        public void DodajWymianeNalzenosciUaktualniajacKryterium(INaleznoscPieniezna naleznosc,
            IPolozenieGornotrojkatneWTabeliNaleznosci polozenieWTabeli)
        {
            if (polozenieWTabeli.CzyKoordynatyDiagonalne == true)
                throw new ArrayTypeMismatchException();

            if (polozenieWTabeli.CzyKoordynatyGorntrojkatne == false)
                naleznosc = naleznosc.Odwrotnosc();

            this[polozenieWTabeli] = naleznosc.Suma(this[polozenieWTabeli]);

            KryteriumWyboruTabeliNaleznosci = WezUaktalnioneKryteriumWyboruOZmiane(polozenieWTabeli, naleznosc);
        }
    }
}