using Xunit;

using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru.KryteriumIlosciWymian
{
    public class Czy_KryteriumIlosciWymian_WezIloscWymian
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(357)]
        public void Czy_Zwaraca_PrawidlowaWartosc(ushort iloscWymian)
        {
            //Ustal
            INaleznoscPieniezna naleznoscPieniezna = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Mock();

            //Dzialaj
            IKryteriumIlosciWymian kryteriumIlosciWymian =
                Stworz_KryteriumWymienionejNaleznosciPienieznej.Stworz_KryteriumIlosciWymian(iloscWymian, naleznoscPieniezna);

            //Asercja
            Assert.Equal(iloscWymian, kryteriumIlosciWymian.WezIlosciWymian);
        }
    }
}