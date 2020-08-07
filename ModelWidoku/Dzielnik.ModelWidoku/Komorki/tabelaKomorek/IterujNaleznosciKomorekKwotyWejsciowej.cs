using System.Collections.Generic;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class TabelaKomorek
    {
        public IEnumerable<TOsoba> IterujOsobyKomorekKwotyWejsciowej<TOsoba>(IKonwerterKomorkaNaOsobaWizytator wizytor) where TOsoba : IOsobaTypSwiadczenia
        {
            foreach (IKomorkaOsobyWejsciowej komorka in komorkiImieniaINaleznosciWejscowej)
            {
                yield return (TOsoba)(komorka.WezOsoba(wizytor));
            }
        }
    }
}
