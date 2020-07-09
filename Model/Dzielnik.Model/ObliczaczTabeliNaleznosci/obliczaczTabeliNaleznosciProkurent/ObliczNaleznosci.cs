using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;
using Dzielnik.Zasoby.Wyjatki;

namespace Dzielnik.Model.ObliczaczTabeliNaleznosci
{
    partial class ObliczaczTabeliNaleznosciProkurent
    {
        public ITabelaNaleznosciZwrotna ObliczNaleznosci(ITablicaOsobBaza tablicaOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci)
        {
            switch (tablicaOsob)        
            {
                case ITablicaOsobPienieznych tablicaOsobPienieznych:
                    return ObliczaczTabeliNaleznosciPienieznych.ObliczNaleznosci(tablicaOsobPienieznych, kryteriumWyboruTabeliNaleznosci);
            }
            
            throw new ZlyTypNaleznosciWyjatek(this, tablicaOsob.GetType());
        }
    }
}