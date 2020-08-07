using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs dla komorki osoby wejsciowej.
    /// </summary>
    internal interface IKomorkaOsobyWejsciowej : IKomorkaWejsciowaKwoty
    {
        IOsobaTypSwiadczenia WezOsoba(IKonwerterKomorkaNaOsobaWizytator wizytor);
    }
}