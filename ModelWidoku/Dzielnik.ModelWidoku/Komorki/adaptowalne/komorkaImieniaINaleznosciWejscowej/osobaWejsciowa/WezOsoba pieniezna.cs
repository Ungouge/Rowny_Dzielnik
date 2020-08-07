using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaImieniaINaleznosciWejscowej : IKomorkaOsobyWejsciowej
    {
        public IOsobaTypSwiadczenia WezOsoba(IKonwerterKomorkaNaOsobaWizytator wizytor)
        {
            return wizytor.StworzOsoba(indeks, naleznoscKomorki);
        }
    }
}