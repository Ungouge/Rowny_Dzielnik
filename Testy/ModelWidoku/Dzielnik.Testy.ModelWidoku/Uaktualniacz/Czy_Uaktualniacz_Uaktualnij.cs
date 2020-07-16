using Dzielnik.Model.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.Uaktualniacz;
using Dzielnik.Testy.Model.stworzMocki.Model;
using Dzielnik.Testy.Zasoby.TabliceOsob;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Moq;
using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Uaktualniacz
{
    public class Czy_Uaktualniacz_Uaktualnij
    {
        [Fact]
        public void Czy_Uaktualnij_Uaktualnia()
        {
            //Ustal
            Mock<IModelDzielnikaDlaUaktualniaczModelu> model_Mock = Stworz_Model_Mock.Stworz_Uaktualnij_WeryfikowalnyMock();

            IModelUaktualniacz uaktualniacz = Stworz_ModelUaktualniacz.Stworz(model_Mock.Object);
            
            ITablicaOsobBaza tablicaOsob = Stworz_TablicaOsobPienieznych_Mock.Stworz_Mock();

            KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci = default(KryteriumWyboruTabeliNaleznosciWylicznik);

            //Dzialaj
            uaktualniacz.Uaktualnij(tablicaOsob, kryteriumWyboruTabeliNaleznosci);

            //Asercja
            model_Mock.Verify(model => model.Uaktualnij
            (
                It.Is<ITablicaOsobBaza>(tablica => tablica.Equals(tablicaOsob)),
                It.Is<KryteriumWyboruTabeliNaleznosciWylicznik>(kryterium => kryterium.Equals(kryteriumWyboruTabeliNaleznosci))
            ), Times.Once, "Uaktualniacz nie uaktualnil modelu.");
        }
    }
}