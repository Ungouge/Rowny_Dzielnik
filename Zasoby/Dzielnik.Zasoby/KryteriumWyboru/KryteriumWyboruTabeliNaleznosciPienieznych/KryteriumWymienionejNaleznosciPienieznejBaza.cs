using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    internal abstract class KryteriumWezWymienionejNaleznosciPienieznejBaza: KryteriumWyboruTabeliNaleznosciPienieznychBaza,
        IKryteriumWezWymienionejNaleznosciPienieznejBaza
    {
        public INaleznoscPieniezna WezWymienionaNaleznosc { get; }

        protected KryteriumWezWymienionejNaleznosciPienieznejBaza(INaleznoscPieniezna wymienionaNaleznosc)
        {
            WezWymienionaNaleznosc = wymienionaNaleznosc;
        }

        public override bool CzyPorownywaneKyrteriumLepsze(IKryteriumWyboruTabeliNaleznosciPienieznej porownywaneKryterium)
        {
            if (porownywaneKryterium is IKryteriumWezWymienionejNaleznosciPienieznejBaza kryteriumSumyNaleznosci)
                return this.WezWymienionaNaleznosc.CzyWieksze(kryteriumSumyNaleznosci.WezWymienionaNaleznosc);

            return false;
        }
    }
}
