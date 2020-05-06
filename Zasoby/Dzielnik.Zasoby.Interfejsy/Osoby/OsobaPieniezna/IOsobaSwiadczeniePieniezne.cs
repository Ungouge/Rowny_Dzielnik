using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Interfejsy.Osoby
{
    /// <summary>
    /// Interfejs dla osob posiadajacych wplate w swiadczeniu pienieznym.
    /// </summary>
    public interface IOsobaSwiadczeniePieniezne : IOsobaTypSwiadczenia
    {
        /// <summary>
        /// Zwraca wpalte swiadczenia pienieznego dokonana przez osobe.
        /// </summary>
        INaleznoscPieniezna Wplata { get; }
    }
}