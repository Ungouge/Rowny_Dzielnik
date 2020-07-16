using Moq;

using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Testy.Model.Fabryki
{
    internal static class Stworz_FabrykaModelu_Mock
    {
        internal static IFabrykaModelu Stworz_WeryfikowalnyObliczaczMock(out Mock<IObliczaczTabeliNaleznosciProkurent> obliczaczTabeliNaleznosciProkurent_Mock)
        {
            Mock<IFabrykaModelu> fabryka_mock = new Mock<IFabrykaModelu>();

            obliczaczTabeliNaleznosciProkurent_Mock = new Mock<IObliczaczTabeliNaleznosciProkurent>();

            obliczaczTabeliNaleznosciProkurent_Mock.
                Setup(prokurent => prokurent.ObliczNaleznosci(It.IsAny<ITablicaOsobBaza>(), It.IsAny<KryteriumWyboruTabeliNaleznosciWylicznik>())).
                Verifiable();

            fabryka_mock.Setup(fabryka => fabryka.StworzObliczaczTabeliNaleznosciProkurent()).
                Returns(obliczaczTabeliNaleznosciProkurent_Mock.Object);

            return fabryka_mock.Object;
        }
    }
}