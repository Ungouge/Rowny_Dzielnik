using System.Collections.Generic;
using System.Linq;

using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Testy.TablicaOsob
{
    public static class Stworz_TablicaOsobPienieznych
    {
        private static readonly IFabrykaTablicaOsobPienieznych fabrykaTablicaOsob = new FabrykaTablicaOsobPienieznych(new FabrykaOsobaPieniezna());

        public static ITablicaOsobPienieznych Stworz(int[] wpaltyWGroszach)
        {
            return fabrykaTablicaOsob.StworzTablicaOsob(WyliczNaleznosci(wpaltyWGroszach).ToArray());
        }

        private static IEnumerable<INaleznoscPieniezna> WyliczNaleznosci(int[] wpaltyWGroszach)
        {
            foreach (int wplataWGroszach in wpaltyWGroszach)
                yield return Stworz_NaleznoscPieniezna.Stworz(wplataWGroszach);
        }
    }
}