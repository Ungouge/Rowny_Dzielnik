using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Testy.Inicjalizator.stworzMocki.IUstawienia;
using Dzielnik.Testy.Zasoby.TabliceOsob;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;
using Dzielnik.Zasoby.Wyliczniki;

using Moq;
using Xunit;

namespace Dzielnik.Testy.Model.ObliczaczTabeliNaleznosci
{
    public class Czy_ObliczaczTabeliNaleznosciProkurent_ObliczNaleznosci
    {
        [Fact]
        public void Czy_Wywoluje_Znajdz_Prawidlowo()
        {
            //Ustal 
            Mock<ITabelaNaleznosciPienieznychObliczacz> obliczacz_Mock = Stworz_TabelaNaleznosciPienieznychObliczacz_Mock.Stworz_Weryfikator_Mock();

            Mock<IFabrykaDlaObliczaczTabeliNaleznosciProkurent> fabryka =
                Stworz_FabrykaDlaObliczaczTabeliNaleznosciProkurent_Mock.Stworz_Weryfikator_Mock(obliczacz_Mock);

            Mock<IUstawieniaRodzajNaleznosciWylicznik> ustawienia_Mock =
                Stworz_IUstawieniaRodzajNaleznosciWylicznik_Mock.Stworz_Weryfikator_Mock(RodzajNaleznosciWylicznik.NaleznoscPieniezna);
                
            IObliczaczTabeliNaleznosciProkurent Obliczacz = Stworz_ObliczaczTabeliNaleznosciProkurent.Stworz(fabryka.Object, ustawienia_Mock.Object);

            ITablicaOsobPienieznych tablicaOsob = Stworz_TablicaOsobPienieznych_Mock.Stworz_Mock();

            //Dzialaj
            Obliczacz.ObliczNaleznosci(tablicaOsob);

            //Asercja
            obliczacz_Mock.Verify(obliczacz => obliczacz.ObliczNaleznosci(It.IsAny<ITablicaOsobPienieznych>()), Times.Once);
            fabryka.Verify(_fabryka => _fabryka.StworzObliczaczTabeliNaleznosciPienieznych(), Times.Once);
        }
    }
}