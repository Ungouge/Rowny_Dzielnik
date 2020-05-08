using System.Collections.Generic;

using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Zasoby.TablicaOsob
{
    partial class TablicaOsobPienieznych: ITablicaOsobPienieznychIterowalna
    {
        public ITablicaOsobPienieznych PrzekazNaleznosciPomiedzyOsobami(IOsobaID osobaKorzen, IOsobaID osobaPotomek, INaleznoscPieniezna naleznoscPieniezna)
        {
            return new TablicaOsobPienieznych(WyliczOsobyZWymienionymiNaleznosciami(osobaKorzen, osobaPotomek, naleznoscPieniezna));
        }

        private IEnumerable<IOsobaPienieznaWymienna> WyliczOsobyZWymienionymiNaleznosciami(IOsobaID osobaKorzen, IOsobaID osobaPotomek,
            INaleznoscPieniezna naleznoscPieniezna)
        {
            foreach (IOsobaPienieznaWymienna osoba in osoby)
            {
                if (osoba.CzyToTaSamaOsoba(osobaKorzen))
                    yield return osoba.OdejmnijNaleznoscPienieznaOsobie(naleznoscPieniezna);
                else if (osoba.CzyToTaSamaOsoba(osobaPotomek))
                    yield return osoba.DodajNaleznoscPienieznaOsobie(naleznoscPieniezna);
                else
                    yield return osoba;
            }
        }
    }
}