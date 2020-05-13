using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    /// <summary>
    /// Kryterium wyboru tabel naleznosci najmniejszej sumy wymienionych naleznosci.
    /// </summary>
    internal partial class KryteriumSumyWymienionejNaleznosciPienieznej : KryteriumWezWymienionejNaleznosciPienieznejBaza, IKryteriumSumyWymienionejNaleznosciPienieznej
    {
        public KryteriumSumyWymienionejNaleznosciPienieznej(INaleznoscPieniezna wymienionaNaleznosc ) : base(wymienionaNaleznosc)
        {
        }
    }
}