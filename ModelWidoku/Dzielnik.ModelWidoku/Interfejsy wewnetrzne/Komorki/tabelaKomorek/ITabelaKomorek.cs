using System.Collections.Generic;

using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    internal interface ITabelaKomorek : ITabelaKomorekZwrotna
    {
        void UaktualnijTabelaNaleznocsci(ITabelaNaleznosciZwrotna tabelaNaleznosci);

        IEnumerable<TOsoba> IterujOsobyKomorekKwotyWejsciowej<TOsoba>(IKonwerterKomorkaNaOsobaWizytator wizytor) where TOsoba : IOsobaTypSwiadczenia;
    }
}
