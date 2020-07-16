using Dzielnik.Model.Interfejsy;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Testy.Model.Fabryki;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Testy.Model.ModelDzielnika
{
    internal static class Stworz_ModelDzielnika
    {
        internal static IModelDzielnika Stworz(ITabelaNaleznosciZwrotna tabelaNaleznosciZwrotna)
        {
            IFabrykaModelu fabrykaModelu = Stworz_FabrykaModelu_Mock.Stworz_StworzObliczaczTabeliNaleznosciProkurent_Mock(tabelaNaleznosciZwrotna);

            return new Dzielnik.Model.ModelDzielnika(fabrykaModelu);
        }

        internal static IModelDzielnika Stworz(IFabrykaModelu fabrykaModelu)
        {
            return new Dzielnik.Model.ModelDzielnika(fabrykaModelu);
        }
    }
}