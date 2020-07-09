using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Moq;

namespace Dzielnik.Testy.Model.ObliczaczTabeliNaleznosci
{
    public static class Stworz_TabelaNaleznosciPienieznychObliczacz_Mock
    {
        internal static Mock<ITabelaNaleznosciPienieznychObliczacz> Stworz_Weryfikator_Mock()
        {
            Mock<ITabelaNaleznosciPienieznychObliczacz> obliczacz_Mock = new Mock<ITabelaNaleznosciPienieznychObliczacz>();

            obliczacz_Mock.
                Setup(obliczacz => obliczacz.ObliczNaleznosci(It.IsAny<ITablicaOsobPienieznych>(), It.IsAny<KryteriumWyboruTabeliNaleznosciWylicznik>() )).
                Verifiable();

            return obliczacz_Mock;
        }
    }
}
