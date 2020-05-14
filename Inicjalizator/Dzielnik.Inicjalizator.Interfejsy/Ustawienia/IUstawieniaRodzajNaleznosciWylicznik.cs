using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.Inicjalizator.Interfejsy
{
    /// <summary>
    /// Interfejs dla klasy z ustawieniami programu z rodzajem naleznosci.
    /// </summary>
    public interface IUstawieniaRodzajNaleznosciWylicznik
    {
        /// <summary>
        /// Wez roddzaj naleznosci obesnie ustawiony w programie.
        /// </summary>
        RodzajNaleznosciWylicznik RodzajNaleznosciWylicznik { get; }
    }
}