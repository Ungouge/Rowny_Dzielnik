using System.Collections;
using System.Collections.Generic;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class TabelaKomorek : IEnumerable<IKomorka>
    {
        public IEnumerator<IKomorka> GetEnumerator()
        {
            foreach (IKomorkaDiagonalna komorkaDiagonalna in komorkiDiagonalna)
                yield return komorkaDiagonalna;

            foreach (IKomorkaWejsciowaKwoty komorkaKwotyWejsciowej in komorkiKwotyWejsciowej)
                yield return komorkaKwotyWejsciowej;

            foreach (IKomorkaWejsciowaImienia komorkaWejsciowaImienia in komorkiWejsciowaImienia)
                yield return komorkaWejsciowaImienia;

            foreach (IKomorkaWyjsciowaImienia komorkaWyjsciowaImienia in komorkiWyjsciowaImienia)
                yield return komorkaWyjsciowaImienia;

            foreach (IKomorkaDolnotrojkatnaKwotyNaleznej komorkaDolnotrojkatnaKwotyNaleznej in komorkiDolnotrojkatnaKwotyNaleznej)
                yield return komorkaDolnotrojkatnaKwotyNaleznej;

            foreach (IKomorkaGornotrojkatnaKwotyNaleznej komorkaGornotrojkatnaKwotyNaleznej in komorkiGornotrojkatnaKwotyNaleznej)
                yield return komorkaGornotrojkatnaKwotyNaleznej;

            yield return komorkaListyRodzajuNaleznosci;

            yield return komorkaListyKryteriumWyboru;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (this as IEnumerable<IKomorka>).GetEnumerator();
        }
    }
}
