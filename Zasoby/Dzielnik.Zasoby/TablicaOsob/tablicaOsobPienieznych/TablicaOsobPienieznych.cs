using System;
using System.Linq;

using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Zasoby.TablicaOsob
{
    /// <summary>
    /// Tablica osob posiadajcych wplate swiadczenia pienieznego.
    /// </summary>
    internal partial class TablicaOsobPienieznych : ITablicaOsobPienieznych
    {
        private readonly IOsobaPieniezna[] osoby;

        internal TablicaOsobPienieznych(IOsobaPieniezna[] szeregOsob)
        {
            if (szeregOsob.Count() >= Byte.MaxValue)
                Array.Resize(ref szeregOsob, Byte.MaxValue - 1);

            osoby = szeregOsob;
        }
    }
}