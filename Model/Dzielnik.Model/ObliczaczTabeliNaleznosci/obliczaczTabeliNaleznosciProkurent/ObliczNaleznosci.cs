using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;
using Dzielnik.Zasoby.Wyjatki;
using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.Model.ObliczaczTabeliNaleznosci
{
    partial class ObliczaczTabeliNaleznosciProkurent
    {
        public ITabelaNaleznosciZwrotna ObliczNaleznosci(ITablicaOsob tablicaOsob)
        {
            switch (RodzajNaleznosci)
            {
                case RodzajNaleznosciWylicznik.NaleznoscPieniezna:
                    return WezObliczaczTabeliNaleznosciPienieznych.ObliczNaleznosci(tablicaOsob as ITablicaOsobPienieznych);
                default:
                    throw new ZlyTypNaleznosciWyjatek(this, RodzajNaleznosci);
            }

        }

        private RodzajNaleznosciWylicznik RodzajNaleznosci
        {
            get
            {
                return ustawienia.RodzajNaleznosciWylicznik;
            }
        }
    }
}