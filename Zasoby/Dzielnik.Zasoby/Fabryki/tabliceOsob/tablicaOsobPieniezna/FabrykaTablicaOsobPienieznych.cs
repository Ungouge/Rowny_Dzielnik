using System.Collections.Generic;

using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;
using Dzielnik.Zasoby.TablicaOsob;

namespace Dzielnik.Zasoby.Fabryki
{
    /// <summary>
    /// Fabryka do tworzena ITablicaOsobPienieznych.
    /// </summary>
    public class FabrykaTablicaOsobPienieznych : IFabrykaTablicaOsobPienieznych
    {
        private readonly IFabrykaOsobaPieniezna fabrykaOsoba;

        public FabrykaTablicaOsobPienieznych(IFabrykaOsobaPieniezna fabrykaOsoba)
        {
            this.fabrykaOsoba = fabrykaOsoba;
        }

        public ITablicaOsobPienieznych StworzTablicaOsob(INaleznoscPieniezna[] wplaty)
        {
            return StworzTablicaOsob(WyliczStworzoneOsoby(wplaty));
        }

        private ITablicaOsobPienieznych StworzTablicaOsob(IEnumerable<IOsobaPienieznaWymienna> osoby)
        {
            return new TablicaOsobPienieznych(osoby);
        }

        private IEnumerable<IOsobaPienieznaWymienna> WyliczStworzoneOsoby(INaleznoscPieniezna[] wplaty)
        {
            for (byte iD = 0; iD < wplaty.Length; iD++)
                yield return fabrykaOsoba.StworzOsoba(iD, wplaty[iD]);
        }
    }
}