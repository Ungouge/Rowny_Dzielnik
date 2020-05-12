using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model.Interfejsy.DoStanuKwitaSumator
{
    /// <summary>
    /// Interfejs dla sumatora roznic naleznosci pienieznej tablic osob od stanu kwita.
    /// </summary>
    internal interface IRozniceDoStanuKwitaNaleznosciPienieznychSumator
    {
        /// <summary>
        /// Zwraca sume roznic naleznosci pienieznej podanej  tablic osob od stanu kwita.
        /// </summary>
        long SumujRoznice(ITablicaOsobPienieznychIterowalna tablicaOsob);
    }
}