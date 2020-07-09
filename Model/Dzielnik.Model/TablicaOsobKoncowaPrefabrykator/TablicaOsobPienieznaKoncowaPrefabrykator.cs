using System.Linq;

using Dzielnik.Model.Interfejsy.TablicaOsobKoncowaPrefabrykator;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.TablicaOsobKoncowaPrefabrykator
{
    /// <summary>
    /// Prefabrykator tworzacego tablice osob jaka jest oczekiwana pod koniec wyrownywania naleznosci.
    /// </summary>
    internal class TablicaOsobPienieznaKoncowaPrefabrykator : ITablicaOsobPienieznaKoncowaPrefabrykator
    {
        readonly IFabrykaTablicaOsobPienieznych fabrykaTablicaOsobPienieznych;

        readonly IFabrykaNaleznoscPieniezna fabrykaNaleznosci;

        internal TablicaOsobPienieznaKoncowaPrefabrykator(IFabrykaTablicaOsobPienieznych fabrykaTablicaOsobPienieznych,
            IFabrykaNaleznoscPieniezna fabrykaNaleznosci)
        {
            this.fabrykaTablicaOsobPienieznych = fabrykaTablicaOsobPienieznych;

            this.fabrykaNaleznosci = fabrykaNaleznosci;
        }

        public ITablicaOsobPienieznych StworzTablicaKoncowa(ITablicaOsobPienieznych tablicaOsob)
        {
            long sumaNaleznosci = 0;

            foreach (IOsobaSwiadczeniePieniezne osoba in tablicaOsob)
                sumaNaleznosci += osoba.Wplata.Swiadczenie;

            byte naIleCzesci = tablicaOsob.WezIloscOsob;

            IOsobaPieniezna[] szeragOsob = new IOsobaPieniezna[naIleCzesci];

            int swiadczenieKawalka = (int)(sumaNaleznosci / naIleCzesci);

            if (sumaNaleznosci < 0)
                swiadczenieKawalka--;

            byte iloscCoDostaneiWiecej = (byte)(sumaNaleznosci - (long)(swiadczenieKawalka * naIleCzesci));

            bool czyObniznoneFlaga = false;

            foreach (IOsobaPieniezna osoba in tablicaOsob.Reverse())
            {
                if (!czyObniznoneFlaga && iloscCoDostaneiWiecej++ >= naIleCzesci)
                {
                    swiadczenieKawalka++;

                    czyObniznoneFlaga = true;
                }

                szeragOsob[osoba.ID] = osoba.ZmienWplate(fabrykaNaleznosci.StworzNaleznosc(swiadczenieKawalka));
            }

            return fabrykaTablicaOsobPienieznych.StworzTablicaOsob(szeragOsob);
        }
    }
}