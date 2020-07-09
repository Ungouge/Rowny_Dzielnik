using System.Collections.Generic;
using System.Linq;

using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Testy.TablicaOsob
{
    public static class Stworz_TablicaOsobPienieznych
    {
        private static readonly IFabrykaOsobaPieniezna fabrykaOsobaPieniezna = new FabrykaOsobaPieniezna();

        private static readonly IFabrykaTablicaOsobPienieznych fabrykaTablicaOsob = new FabrykaTablicaOsobPienieznych();

        public static ITablicaOsobPienieznych Stworz(int[] wpaltyWGroszach)
        {
            return fabrykaTablicaOsob.StworzTablicaOsob(StworzSzeregOsob(wpaltyWGroszach));
        }

        private static IOsobaPieniezna[] StworzSzeregOsob(int[] wpaltyWGroszach)
        {
            return WyliczOsoby(wpaltyWGroszach).ToArray();
        }

        private static IEnumerable<IOsobaPieniezna> WyliczOsoby(int[] wplatyWGroszach)
        {
            for (byte iD = 0; iD < wplatyWGroszach.Length; iD++)
            {
                INaleznoscPieniezna naleznoscPieniezna = Stworz_NaleznoscPieniezna.Stworz(wplatyWGroszach[iD]);

                yield return fabrykaOsobaPieniezna.StworzOsoba(iD, naleznoscPieniezna);
            }
        }
    }
}