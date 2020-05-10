using Dzielnik.Model.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model.TabelaNaleznosci
{
    partial class TabelaNaleznosciPienieznejNull : TabelaNaleznosciPienieznejBaza, ITabelaNaleznosciPienieznejNull
    {
        public ITabelaNaleznosciPienieznej ZwrocLepszeKryterium(ITabelaNaleznosciPienieznej porownywanaTabela)
        {
            return porownywanaTabela;
        }
    }
}
