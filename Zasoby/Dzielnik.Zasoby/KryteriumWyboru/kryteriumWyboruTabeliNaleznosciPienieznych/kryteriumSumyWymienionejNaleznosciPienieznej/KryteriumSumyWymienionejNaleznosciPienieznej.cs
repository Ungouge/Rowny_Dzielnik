using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    /// <summary>
    /// Kryterium wyboru tabel naleznosci najmniejszej sumy wymienionych naleznosci.
    /// </summary>
    internal partial class KryteriumSumyWymienionejNaleznosciPienieznej : KryteriumWyboruTabeliNaleznosciPienieznychBaza, IKryteriumSumyWymienionejNaleznosciPienieznej
    {
        public INaleznoscPieniezna WezWymienionaNaleznosc { get; }

        public KryteriumSumyWymienionejNaleznosciPienieznej(INaleznoscPieniezna wymienionaNaleznosc )
        {
            WezWymienionaNaleznosc = wymienionaNaleznosc;
        }
    }
}