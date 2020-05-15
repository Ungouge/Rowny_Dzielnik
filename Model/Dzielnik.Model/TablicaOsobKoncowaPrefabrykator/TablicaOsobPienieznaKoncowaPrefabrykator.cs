using System.Collections.Generic;

using Dzielnik.Model.Interfejsy.TablicaOsobKoncowaPrefabrykator;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.TablicaOsobKoncowaPrefabrykator
{
    /// <summary>
    /// Prefabrykator tworzacego tablice osob jaka jest oczekiwana pod koniec wyrownywania naleznosci.
    /// </summary>
    internal class TablicaOsobPienieznaKoncowaPrefabrykator: ITablicaOsobPienieznaKoncowaPrefabrykator
    {
        readonly IFabrykaTablicaOsobPienieznych fabrykaTablicaOsobPienieznych;

        readonly IFabrykaNaleznoscPieniezna fabrykaNaleznosci;

        internal TablicaOsobPienieznaKoncowaPrefabrykator(IFabrykaTablicaOsobPienieznych fabrykaTablicaOsobPienieznych,
            IFabrykaNaleznoscPieniezna fabrykaNaleznosci)
        {
            this.fabrykaTablicaOsobPienieznych = fabrykaTablicaOsobPienieznych;

            this.fabrykaNaleznosci = fabrykaNaleznosci;
        }

        public ITablicaOsobPienieznych StworzTablicaKoncowa(ITablicaOsobPienieznychZwrotna tablicaOsob)
        {
            IEnumerator<IOsobaPieniezna> enumerator = (tablicaOsob as IEnumerable<IOsobaPieniezna>).GetEnumerator();

            long sumaNaleznosci = 0;

            while (enumerator.MoveNext())
                sumaNaleznosci += enumerator.Current.Wplata.Swiadczenie;

            byte naIleCzesci = tablicaOsob.WezIloscOsob;

            INaleznoscPieniezna[] tablicaNaleznosci = new INaleznoscPieniezna[naIleCzesci];

            int swiadczenieKawalka = (int)(sumaNaleznosci / naIleCzesci);

            if (sumaNaleznosci < 0)
                swiadczenieKawalka--;

            byte iloscCoDostaneiWiecej = (byte)(sumaNaleznosci - (long)(swiadczenieKawalka * naIleCzesci));

            int i = naIleCzesci - 1;

            for (; i >= iloscCoDostaneiWiecej; i--)
                tablicaNaleznosci[i] = fabrykaNaleznosci.StworzNaleznosc(swiadczenieKawalka);

            swiadczenieKawalka++;

            for (; i >= 0; i--)
                tablicaNaleznosci[i] = fabrykaNaleznosci.StworzNaleznosc(swiadczenieKawalka);

            return fabrykaTablicaOsobPienieznych.StworzTablicaOsob(tablicaNaleznosci);
        }
    }
}