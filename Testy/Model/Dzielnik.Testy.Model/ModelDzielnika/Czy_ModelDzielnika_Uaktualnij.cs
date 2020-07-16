using Dzielnik.Model.Interfejsy;
using Dzielnik.Testy.Model.TabeleNaleznosci;
using Dzielnik.Testy.Zasoby.TabliceOsob;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;
using Xunit;

namespace Dzielnik.Testy.Model.ModelDzielnika
{
    public class Czy_ModelDzielnika_Uaktualnij
    {
        [Fact]
        public void Czy_Uaktualnij_Uaktulnia_Poprawnie()
        {
            // Ustal
            ITabelaNaleznosciZwrotna tabelaNaleznosci = Stworz_TabelaNaleznosciPienieznej_Mock.Stworz_Mock();

            IModelDzielnika model = Stworz_ModelDzielnika.Stworz(tabelaNaleznosci);

            ITabelaNaleznosciZwrotna tabelaNaleznoscOtrzymana = null;
            
            model.ObliczonaTabelNaleznocsci += (sender, e) =>
            {
                tabelaNaleznoscOtrzymana = e.TabelaNaleznosciZwrotna;
            };

            ITablicaOsobBaza tablicaOsob = Stworz_TablicaOsobPienieznych_Mock.Stworz_Mock();

            //Dzialaj
            model.Uaktualnij(tablicaOsob, default(KryteriumWyboruTabeliNaleznosciWylicznik));

            // Asercja
            Assert.Same(tabelaNaleznosci, tabelaNaleznoscOtrzymana);
        }
    }
}