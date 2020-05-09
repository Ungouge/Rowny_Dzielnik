using Xunit;

using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

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
            //Ustal i Dzialaj
            IKryteriumIlosciWymian kryteriumIlosciWymian = Stworz_KryteriumWyboruTabeliNaleznosciPienieznych.Stworz_KryteriumIlosciWymian(iloscWymian);

            //Asercja
            Assert.Equal(iloscWymian, kryteriumIlosciWymian.WezIlosciWymian);
        }
    }
}
