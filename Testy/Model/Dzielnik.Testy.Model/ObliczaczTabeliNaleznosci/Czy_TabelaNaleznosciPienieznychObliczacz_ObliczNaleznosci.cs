using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.NajlepszaWymianaZnajdywacz;
using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Model.Interfejsy.TablicaOsobKoncowaPrefabrykator;
using Dzielnik.Testy.Model.NajlepszaWymianaZnajdywacz;
using Dzielnik.Testy.Model.TablicaOsobKoncowaPrefabrykator;
using Dzielnik.Testy.Zasoby.TabliceOsob;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Moq;
using Xunit;

namespace Dzielnik.Testy.Model.ObliczaczTabeliNaleznosci
{
    public class Czy_TabelaNaleznosciPienieznychObliczacz_ObliczNaleznosci
    {
        [Fact]
        public void Czy_Wywoluje_Znajdz_Prawidlowo()
        {
            //Ustal 
            Mock<INajlepszaWymianaNalezosciPienieznejZnajdywacz> znajdywacz_Mock =
                Stworz_NajlepszaWymianaNalezosciPienieznejZnajdywacz_Mock.Stworz_Weryfikator_Mock();

            IFabrykaDlaTabelaNaleznosciPienieznychObliczacz fabryka =
                Stworz_FabrykaDlaTabelaNaleznosciObliczaczPienieznych_Mock.Stworz_Weryfikator_Mock(znajdywacz_Mock);

            Mock<ITablicaOsobPienieznaKoncowaPrefabrykator> prefabrykator_Mock = Stworz_TablicaOsobKoncowaPrefabrykator_Mock.Stworz_Weryfikator_Mock();

            ITabelaNaleznosciPienieznychObliczacz Obliczacz = Stworz_TabelaNaleznosciPienieznychObliczacz.Stworz(fabryka, prefabrykator_Mock.Object);

            ITablicaOsobPienieznych tablicaOsob = Stworz_TablicaOsobPienieznych_Mock.Stworz_Mock();

            KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosciWylicznik = default(KryteriumWyboruTabeliNaleznosciWylicznik);

            //Dzialaj
            Obliczacz.ObliczNaleznosci(tablicaOsob, kryteriumWyboruTabeliNaleznosciWylicznik);

            //Asercja
            znajdywacz_Mock.Verify(znajdywacz => znajdywacz.Znajdz(It.IsAny<ITablicaOsobPienieznych>()), Times.Once );

            prefabrykator_Mock.Verify(prefabrykator => prefabrykator.StworzTablicaKoncowa(It.IsAny<ITablicaOsobPienieznych>()), Times.Once);
        }
    }
}