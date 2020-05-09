using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    partial class KryteriumSumyWymienionejNaleznosciPienieznej
    {
        public IKryteriumSumyWymienionejNaleznosciPienieznej DodajNaleznoscDoSumyWymienionejNaleznosci(INaleznoscPieniezna naleznoscPieniezna)
        {
            return new KryteriumSumyWymienionejNaleznosciPienieznej(WezWymienionaNaleznosc.Suma(naleznoscPieniezna));
        }
    }
}