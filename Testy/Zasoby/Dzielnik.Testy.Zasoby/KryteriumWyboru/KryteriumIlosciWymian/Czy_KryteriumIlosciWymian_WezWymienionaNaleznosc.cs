using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru.KryteriumIlosciWymian
{
    public class Czy_KryteriumIlosciWymian_WezWymienionaNaleznosc
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(357)]
        public void Czy_Zwaraca_PrawidlowaWartosc(int swiadczenieWGroszach)
        {
            //Ustal
            INaleznoscPieniezna naleznoscPieniezna = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Swiadczenie_Mock(swiadczenieWGroszach);

            //Dzialaj
            IKryteriumIlosciWymian kryteriumIlosciWymian =
                Stworz_KryteriumWymienionejNaleznosciPienieznej.Stworz_KryteriumIlosciWymian(1, naleznoscPieniezna);

            //Asercja
            Assert.Equal(swiadczenieWGroszach, kryteriumIlosciWymian.WezWymienionaNaleznosc.Swiadczenie);
        }
    }
}