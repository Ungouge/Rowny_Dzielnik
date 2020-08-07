using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.ModelWidoku.Fabryki
{
    partial class FabrykaModelWidoku
    {
        public IPolozenieWTabeliNaleznosci StworzPolozenieWTabeliNaleznosci(byte index_X, byte index_Y)
        {
            return fabrykaPolozeniaWTabeliNaleznosci.StworzPolozeniaWTabeliNaleznosci(index_X, index_Y);
        }
    }
}
