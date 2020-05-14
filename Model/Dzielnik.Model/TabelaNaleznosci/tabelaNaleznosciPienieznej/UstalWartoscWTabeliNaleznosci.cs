using System;

using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.TabelaNaleznosci
{
    partial class TabelaNaleznosciPienieznej : ITabelaNaleznosciPienieznej
    {
        private IKryteriumWyboruTabeliNaleznosciPienieznej WezUaktalnioneKryteriumWyboruOZmiane
            (IPolozenieGornotrojkatneWTabeliNaleznosci polozenieWTabeli, INaleznoscPieniezna roznicaNaleznosci)
        {
            switch (KryteriumWyboruTabeliNaleznosci)
            {
                case IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumy:
                    return kryteriumSumy.DodajNaleznoscDoSumyWymienionejNaleznosci(roznicaNaleznosci);
                case IKryteriumIlosciWymian kryteriumIlosciWymian:
                    // Celowo jest pomiety przypadek gdzie przypadkowo spowrotem zeruje sie naleznosc komorki w tabeli 
                    //i teoretycznie kryterium powinno usunac te polozenie. W drzewie binarmyn modelu znajdzie sie inne rozwiazanie bez
                    //niepotrzebnych wymian, wiec taka galaz predzej czy pozniej "przegra" z prostrzym rozwiazaniem,
                    //wiec dla zachowania prostoty kodu zostalo pominiete usuwanie polozen z kryterium.
                    return kryteriumIlosciWymian.DodajPolozenieZmienionejNaleznosci(polozenieWTabeli, roznicaNaleznosci);
                default:
                    throw new NotImplementedException("Nie zaimplementowano tego kryterium naleznosci pienieznej w TabelaNaleznosciPienieznej.UstalWartoscWTabeliNaleznosci");
            }
        }

        private INaleznoscPieniezna WezwartoscBezwzglednaNaleznosci( INaleznoscPieniezna roznicaNaleznosci)
        {
            INaleznoscPieniezna naleznoscZero = abstrakcyjnaFabrykaNaleznosciDlaTabeliNaleznosci.StworzNaleznoscPienieznaZerowa();

            if (naleznoscZero.CzyWieksze(roznicaNaleznosci))
                return roznicaNaleznosci;

            if (roznicaNaleznosci.CzyWieksze(naleznoscZero))
                return roznicaNaleznosci.Odwrotnosc();

            return naleznoscZero;
        }
    }
}