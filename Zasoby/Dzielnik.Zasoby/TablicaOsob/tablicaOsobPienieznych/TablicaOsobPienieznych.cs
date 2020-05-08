using System;
using System.Collections.Generic;
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
        private readonly IOsobaPienieznaWymienna[] osoby;

        internal TablicaOsobPienieznych(IEnumerable<IOsobaPienieznaWymienna> wyliczoneOsoby)
        {
            if (wyliczoneOsoby.Count() > Byte.MaxValue)
                wyliczoneOsoby = wyliczoneOsoby.Take<IOsobaPienieznaWymienna>(Byte.MaxValue);

            osoby = wyliczoneOsoby.ToArray<IOsobaPienieznaWymienna>();
        }
    }
}