using Dzielnik.Model.Interfejsy;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Moq;

namespace Dzielnik.Testy.Model.stworzMocki.Model
{
    internal static class Stworz_Model_Mock
    {
        internal static Mock<IModelDzielnikaDlaUaktualniaczModelu> Stworz_Uaktualnij_WeryfikowalnyMock()
        {
            Mock<IModelDzielnikaDlaUaktualniaczModelu> model_Mock = new Mock<IModelDzielnikaDlaUaktualniaczModelu>();

            model_Mock.
                Setup(model => model.Uaktualnij(It.IsAny<ITablicaOsobBaza>(), It.IsAny<KryteriumWyboruTabeliNaleznosciWylicznik>()))
                .Verifiable();

            return model_Mock;
        }
    }
}
