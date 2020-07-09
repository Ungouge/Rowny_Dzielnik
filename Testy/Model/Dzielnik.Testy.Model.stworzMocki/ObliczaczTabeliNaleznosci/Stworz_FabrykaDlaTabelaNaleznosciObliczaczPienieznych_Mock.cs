using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Moq;

namespace Dzielnik.Testy.Model.ObliczaczTabeliNaleznosci
{
    public static class Stworz_FabrykaDlaTabelaNaleznosciObliczaczPienieznych_Mock
    {
        internal static IFabrykaDlaTabelaNaleznosciPienieznychObliczacz Stworz_Weryfikator_Mock(Mock<INajlepszaWymianaNalezosciPienieznejZnajdywacz> Znajdywacz_Mock)
        {
            Mock<IFabrykaDlaTabelaNaleznosciPienieznychObliczacz> fabryka_Mock = new Mock<IFabrykaDlaTabelaNaleznosciPienieznychObliczacz>();

            fabryka_Mock.
                Setup(fabryka => fabryka.StworzNajlepszaWymianaNalezosciPienieznejZnajdywacz(It.IsAny<ITablicaOsobPienieznych>(), It.IsAny<KryteriumWyboruTabeliNaleznosciWylicznik>())).
                Returns(Znajdywacz_Mock.Object);

            return fabryka_Mock.Object;
        }
    }
}