using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Zasoby.KryteriumWyboru
{
    partial class KryteriumIlosciWymian
    {
        public override bool CzyPorownywaneKyrteriumLepsze(IKryteriumWyboruTabeliNaleznosciPienieznej porownywaneKryterium)
        {
            if (porownywaneKryterium is IKryteriumIlosciWymian kryteriumWyboru)
                if (this.WezIlosciWymian < kryteriumWyboru.WezIlosciWymian)
                    return true;

            return false;
        }
    }
}