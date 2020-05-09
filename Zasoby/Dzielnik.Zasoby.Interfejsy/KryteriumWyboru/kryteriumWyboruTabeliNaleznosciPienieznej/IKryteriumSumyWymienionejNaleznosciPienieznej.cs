using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Interfejsy.KryteriumWyboru
{
    /// <summary>
    /// Interfejs dla kryteriow wyboru tabel naleznosci najmniejszej sumy wymienionych naleznosci.
    /// </summary>
    public interface IKryteriumSumyWymienionejNaleznosciPienieznej : IKryteriumWyboruTabeliNaleznosciPienieznej
    {
        /// <summary>
        /// Zwraca naleznosc pieniezna odpowiadajaca sumie wymienionych naleznosci.
        /// </summary>
        INaleznoscPieniezna WezWymienionaNaleznosc { get; }

        /// <summary>
        /// Zwraca nowe kryterium z suma wymienionych naleznosci pienieznych powiekszoną o podana naleznosc.
        /// </summary>
        IKryteriumSumyWymienionejNaleznosciPienieznej DodajNaleznoscDoSumyWymienionejNaleznosci(INaleznoscPieniezna naleznoscPieniezna);
    }
}