using System;
using System.Collections.Generic;

using Dzielnik.Model.Interfejsy.DoStanuKwitaSumator;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.DoStanuKwitaSumator
{
    /// <summary>
    /// Sumatora roznic naleznosci pienieznej tablic osob od stanu kwita.
    /// </summary>
    internal class RozniceDoStanuKwitaNaleznosciPienieznychSumator : IRozniceDoStanuKwitaNaleznosciPienieznychSumator
    {
        private readonly ITablicaOsobPienieznychIterowalna tablicaOsobPoczatkowa;

        public RozniceDoStanuKwitaNaleznosciPienieznychSumator(ITablicaOsobPienieznychIterowalna tablicaOsobPoczatkowa)
        {
            this.tablicaOsobPoczatkowa = tablicaOsobPoczatkowa;
        }

        public long SumujRoznice(ITablicaOsobPienieznychIterowalna tablicaOsob)
        {
            IEnumerator<IOsobaPieniezna> enumerator1 = tablicaOsob.GetEnumerator();

            IEnumerator<IOsobaPieniezna> enumerator2 = tablicaOsobPoczatkowa.GetEnumerator();

            long sumaRoznic = 0;

            while (enumerator1.MoveNext() && enumerator2.MoveNext())
                sumaRoznic += Math.Abs(enumerator1.Current.Wplata.Swiadczenie - enumerator2.Current.Wplata.Swiadczenie);

            return sumaRoznic;
        }
    }
}