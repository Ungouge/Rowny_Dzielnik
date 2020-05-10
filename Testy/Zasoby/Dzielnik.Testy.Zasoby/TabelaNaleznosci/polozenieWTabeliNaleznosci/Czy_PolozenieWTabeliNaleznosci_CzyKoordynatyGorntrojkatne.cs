using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.TabelaNaleznosci
{
    public class Czy_PolozenieWTabeliNaleznosci_CzyKoordynatyGorntrojkatne
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 0)]
        [InlineData(5, 0)]
        [InlineData(230, 0)]
        [InlineData(2, 1)]
        [InlineData(5, 1)]
        [InlineData(230, 1)]
        [InlineData(5, 2)]
        [InlineData(230, 2)]
        public void Czy_ZwracaPrawde_GdyDiagonalne(byte indeks_X, byte indeks_Y)
        {
            //Ustal
            IPolozenieWTabeliNaleznosci polozenieWTabeliNaleznosci = Stworz_PolozenieWTabeliNaleznosci.Stworz(indeks_X, indeks_Y);

            //Dzialaj
            bool czyKoordynatyGorntrojkatne = polozenieWTabeliNaleznosci.CzyKoordynatyGorntrojkatne;

            //Asercja
            Assert.True(czyKoordynatyGorntrojkatne);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(0, 2)]
        [InlineData(1, 2)]
        [InlineData(2, 2)]
        [InlineData(0, 5)]
        [InlineData(1, 5)]
        [InlineData(2, 5)]
        [InlineData(5, 5)]
        [InlineData(0, 230)]
        [InlineData(1, 230)]
        [InlineData(2, 230)]
        [InlineData(5, 230)]
        [InlineData(230, 230)]
        public void Czy_ZwracaNiePrawde_GdyNieDiagonalne(byte indeks_X, byte indeks_Y)
        {
            //Ustal
            IPolozenieWTabeliNaleznosci polozenieWTabeliNaleznosci = Stworz_PolozenieWTabeliNaleznosci.Stworz(indeks_X, indeks_Y);

            //Dzialaj
            bool czyKoordynatyGorntrojkatne = polozenieWTabeliNaleznosci.CzyKoordynatyGorntrojkatne;

            //Asercja
            Assert.False(czyKoordynatyGorntrojkatne);
        }
    }
}