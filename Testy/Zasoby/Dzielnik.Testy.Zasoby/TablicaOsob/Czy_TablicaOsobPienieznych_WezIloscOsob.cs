using Dzielnik.Testy.TablicaOsob;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Xunit;

namespace Dzielnik.Testy.Zasoby.TablicaOsob
{
    public class Czy_TablicaOsobPienieznych_WezIloscOsob
    {
        [Theory]
        [InlineData(new int[] { 1, 1 }, 2)]
        [InlineData(new int[] { 2, 2, 1 }, 3)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 4)]
        [InlineData(new int[] { 10, 1, 1, 0 , 5 }, 5)]
        [InlineData(new int[] { 6, 2, 1, 0 , 1, 3 }, 6)]
        [InlineData(new int[] { 1, 10, 1, 2 ,1, 6, 1, 6 }, 8)]
        public void Czy_TablicaOsobPienieznych_WezIloscOsob_ZwracaPrawidlowo
            (int[] wplatyPoczatkowe,  byte oczekiwanaIloscOsob)
        {
            //Ustal
            ITablicaOsobPienieznychPrzekazywalna tablicaOsobPoczatkowe = Stworz_TablicaOsobPienieznych.Stworz(wplatyPoczatkowe);

            //Dzialaj
            byte iloscosobWtablicy = tablicaOsobPoczatkowe.WezIloscOsob;

            //Asercja
            Assert.Equal(oczekiwanaIloscOsob, iloscosobWtablicy);
        }
    }
}