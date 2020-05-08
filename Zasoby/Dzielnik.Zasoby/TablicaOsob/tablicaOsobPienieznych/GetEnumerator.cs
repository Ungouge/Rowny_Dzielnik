using System.Collections;
using System.Collections.Generic;

using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.Zasoby.TablicaOsob
{
    partial class TablicaOsobPienieznych : IEnumerable<IOsobaPieniezna>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<IOsobaPieniezna>).GetEnumerator();
        }

        IEnumerator<IOsobaPieniezna> IEnumerable<IOsobaPieniezna>.GetEnumerator()
        {
            foreach (IOsobaPieniezna osoba in osoby)
                yield return osoba;
        }
    }
}