using System;

using Dzielnik.Model.Interfejsy;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;
using Dzielnik.Testy.Model.Fabryki;
using Dzielnik.Testy.Zasoby.TabliceOsob;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Zdarzenia;

using Xunit;
using Moq;

namespace Dzielnik.Testy.Model.ModelDzielnika
{
    public class Czy_ModelDzielnika_ObliczonaTabelNaleznocsci
    {
        [Fact]
        public void Czy_Uaktualnij_Uaktulnia_Poprawnie()
        {
            // Ustal
            IFabrykaModelu fabrykaModelu =
                Stworz_FabrykaModelu_Mock.Stworz_WeryfikowalnyObliczaczMock(out Mock<IObliczaczTabeliNaleznosciProkurent> obliczaczTabeliNaleznosciProkurent_Mock);
            
            IModelDzielnika model = Stworz_ModelDzielnika.Stworz(fabrykaModelu);

            ITabelaNaleznosciZwrotna tabelaNaleznoscOtrzymana = null;

            Mock<Action<object, ObliczonaTabelaNaleznosci_ArgumentZdarzenia>> action = new Mock<Action<object, ObliczonaTabelaNaleznosci_ArgumentZdarzenia>>();

            model.ObliczonaTabelNaleznocsci += (sender, e) =>
            {
                tabelaNaleznoscOtrzymana = e.TabelaNaleznosciZwrotna;
            };

            ITablicaOsobBaza tablicaOsob = Stworz_TablicaOsobPienieznych_Mock.Stworz_Mock();

            KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci = default(KryteriumWyboruTabeliNaleznosciWylicznik);

            //Dzialaj
            model.Uaktualnij(tablicaOsob, kryteriumWyboruTabeliNaleznosci);

            // Asercja
            obliczaczTabeliNaleznosciProkurent_Mock.
                Verify(obliczacz => obliczacz.ObliczNaleznosci
                (
                    It.Is<ITablicaOsobBaza>( tablica => tablica.Equals(tablicaOsob)),
                    It.Is<KryteriumWyboruTabeliNaleznosciWylicznik>( kryterium => kryterium.Equals(kryteriumWyboruTabeliNaleznosci))
                ), Times.Once);
        }
    }
}