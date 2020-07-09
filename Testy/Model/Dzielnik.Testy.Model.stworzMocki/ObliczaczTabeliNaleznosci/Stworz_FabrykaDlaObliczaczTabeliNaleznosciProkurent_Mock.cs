using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;

using Moq;

namespace Dzielnik.Testy.Model.ObliczaczTabeliNaleznosci
{
    public static class Stworz_FabrykaDlaObliczaczTabeliNaleznosciProkurent_Mock
    {
        internal static Mock<IFabrykaDlaObliczaczTabeliNaleznosciProkurent> Stworz_Weryfikator_Mock(Mock<ITabelaNaleznosciPienieznychObliczacz> Obliczacz_Mock)
        {
            Mock<IFabrykaDlaObliczaczTabeliNaleznosciProkurent> fabryka_Mock = new Mock<IFabrykaDlaObliczaczTabeliNaleznosciProkurent>();

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzObliczaczTabeliNaleznosciPienieznych()).
                Returns(Obliczacz_Mock.Object).
                Verifiable();

            return fabryka_Mock;
        }
    }
}