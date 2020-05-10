using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.TabelaNaleznosci
{
    public class Czy_PolozenieWTabeliNaleznosci_CzyKoordynatyDiagonalne
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(5, 5)]
        [InlineData(230, 230)]
        public void Czy_ZwracaPrawde_GdyDiagonalne(byte indeks_X, byte indeks_Y)
        {
            //Ustal
            IPolozenieWTabeliNaleznosci polozenieWTabeliNaleznosci = Stworz_PolozenieWTabeliNaleznosci.Stworz(indeks_X, indeks_Y);

            //Dzialaj
            bool czyKoordynatyDiagonalne = polozenieWTabeliNaleznosci.CzyKoordynatyDiagonalne;

            //Asercja
            Assert.True(czyKoordynatyDiagonalne);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(0, 2)]
        [InlineData(0, 5)]
        [InlineData(0, 230)]
        [InlineData(1, 0)]
        [InlineData(1, 2)]
        [InlineData(1, 5)]
        [InlineData(1, 230)]
        [InlineData(5, 0)]
        [InlineData(5, 1)]
        [InlineData(5, 2)]
        [InlineData(5, 230)]
        [InlineData(230, 0)]
        [InlineData(230, 1)]
        [InlineData(230, 2)]
        [InlineData(230, 5)]
        public void Czy_ZwracaNiePrawde_GdyNieDiagonalne(byte indeks_X, byte indeks_Y)
        {
            //Ustal
            IPolozenieWTabeliNaleznosci polozenieWTabeliNaleznosci = Stworz_PolozenieWTabeliNaleznosci.Stworz(indeks_X, indeks_Y);

            //Dzialaj
            bool czyKoordynatyDiagonalne = polozenieWTabeliNaleznosci.CzyKoordynatyDiagonalne;

            //Asercja
            Assert.False(czyKoordynatyDiagonalne);
        }
    }
}