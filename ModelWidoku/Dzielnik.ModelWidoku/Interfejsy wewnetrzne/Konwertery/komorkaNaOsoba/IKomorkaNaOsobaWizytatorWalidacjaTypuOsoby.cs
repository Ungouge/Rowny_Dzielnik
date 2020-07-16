using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.ModelWidoku.Interfejsy.Konwertery
{
    /// <summary>
    /// Interfejs dla wizytatora konwertujacego przeslana komorke na odpowiedni typ osoby. 
    /// </summary>
    internal interface IKomorkaNaOsobaWizytatorWalidacjaTypuOsoby
    {
        /// <summary>
        /// Stwierdza czy przeslany rodzaj naleznosci odpowiada zaimplementowanemu wizytatorowi. 
        /// </summary>
        bool CzyOdpowiadaRodzajowiNaleznosci(RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik);
    }
}