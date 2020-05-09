using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    partial class KryteriumSumyWymienionejNaleznosciPienieznej
    {
        public override bool CzyPorownywaneKyrteriumLepsze(IKryteriumWyboruTabeliNaleznosciPienieznej porownywaneKryterium)
        {
            if (porownywaneKryterium is IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumyNaleznosci)
                return this.WezWymienionaNaleznosc.CzyWieksze(kryteriumSumyNaleznosci.WezWymienionaNaleznosc);

            return false;
        }
    }
}