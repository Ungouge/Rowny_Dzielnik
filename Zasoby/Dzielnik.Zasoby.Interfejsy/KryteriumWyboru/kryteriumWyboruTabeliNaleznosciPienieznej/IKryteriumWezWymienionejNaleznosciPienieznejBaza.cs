using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Interfejsy.KryteriumWyboru
{
    /// <summary>
    /// Interfejs bazowy dla kryteriow wybory tabel naleznosci zawierajacych sume wymienionej naleznosci pienieznej.
    /// </summary>
    public interface IKryteriumWezWymienionejNaleznosciPienieznejBaza: IKryteriumWyboruTabeliNaleznosciPienieznej
    {
        /// <summary>
        /// Zwraca naleznosc pieniezna odpowiadajaca sumie wymienionych naleznosci.
        /// </summary>
        INaleznoscPieniezna WezWymienionaNaleznosc { get; }
    }
}