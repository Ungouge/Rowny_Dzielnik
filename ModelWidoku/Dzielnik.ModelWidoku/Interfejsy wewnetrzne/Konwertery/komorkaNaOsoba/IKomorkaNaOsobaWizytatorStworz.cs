using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

namespace Dzielnik.ModelWidoku.Interfejsy.Konwertery
{
    /// <summary>
    /// Interfejs dla wizytatora tworzacego przeslane dane komorki na odpowiedni typ osoby. 
    /// </summary>
    internal interface IKomorkaNaOsobaWizytatorStworz
    {
        /// <summary>
        /// Stworz osobe odpowiedniego typu wedlug implementacji wizytatora oraz typowi naleznosci.
        /// </summary>
        IOsobaTypSwiadczenia StworzOsoba(byte indeks, INaleznoscSwiadczenieBaza naleznosc);
    }
}