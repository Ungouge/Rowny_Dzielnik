using Dzielnik.Model.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.TabelaNaleznosci
{
    partial class TabelaNaleznosciPienieznej : ITabelaNaleznosciPienieznej
    {
        public ITabelaNaleznosciPienieznej ZwrocLepszeKryterium(ITabelaNaleznosciPienieznej porownywanaTabela)
        {
            if ( false == porownywanaTabela is ITabelaNaleznosciPienieznejNull)
                if (this.KryteriumWyboruTabeliNaleznosci.CzyPorownywaneKyrteriumLepsze(porownywanaTabela.KryteriumWyboruTabeliNaleznosci))
                    return porownywanaTabela;

            return this;
        }
    }
}