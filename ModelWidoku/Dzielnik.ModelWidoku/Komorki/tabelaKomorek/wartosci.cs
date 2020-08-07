using Dzielnik.ModelWidoku.Interfejsy.Fabryki;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using System.Collections.Generic;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class TabelaKomorek
    {
        private readonly IFabrykaModeluWidokuDlaTabelaKomorek fabrykaDlaTabelaKomorek;

        private readonly IKonwerterTekstKwotyWejsciowejProkurent tekstKwotyWejsciowejProkurent;

        private readonly IKonwerterNaleznoscNaStringProkurent naleznoscNaStringProkurent;
        
        private readonly Stack<IKomorkaKwotyNaleznej[]> komorkiKwotyNaleznej;

        private readonly Stack<IKomorkaImieniaINaleznosciWejscowej> komorkiImieniaINaleznosciWejscowej;

        private readonly Stack<IKomorkaDiagonalna> komorkiDiagonalna;

        private readonly Stack<IKomorkaDolnotrojkatnaKwotyNaleznej> komorkiDolnotrojkatnaKwotyNaleznej;

        private readonly Stack<IKomorkaGornotrojkatnaKwotyNaleznej> komorkiGornotrojkatnaKwotyNaleznej;

        private readonly Stack<IKomorkaWejsciowaKwoty> komorkiKwotyWejsciowej;

        private readonly Stack<IKomorkaWejsciowaImienia> komorkiWejsciowaImienia;

        private readonly Stack<IKomorkaWyjsciowaImienia> komorkiWyjsciowaImienia;

        private readonly IKomorkaListyRodzajuNaleznosci komorkaListyRodzajuNaleznosci;

        private readonly IKomorkaListyKryteriumWyboru komorkaListyKryteriumWyboru;
    }
}
