using Dzielnik.Model.Interfejsy.DoStanuKwitaSumator;
using Dzielnik.Testy.TablicaOsob;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Xunit;

namespace Dzielnik.Testy.Model.DoStanuKwitaSumator
{
    public class Czy_RozniceDoStanuKwitaNaleznosciPienieznychSumator_SumujRoznice
    {
        [Theory]
        [InlineData(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 }, 0)]
        [InlineData(new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 }, 0)]
        [InlineData(new int[] { 2, 2, 2, 2 }, new int[] { 2, 2, 2, 2 }, 0)]
        [InlineData(new int[] { 5, 5, 5, 5 }, new int[] { 5, 5, 5, 5 }, 0)]
        [InlineData(new int[] { 5, 5, 5, 5 }, new int[] { 10, 0, 10, 0 }, 20)]
        [InlineData(new int[] { 5, 5, 5, 5 }, new int[] { 20, 0, 0, 0 }, 30)]
        [InlineData(new int[] { 5, 5, 5, 5 }, new int[] { 6, 4, 5, 5 }, 2)]
        [InlineData(new int[] { int.MaxValue / 2, int.MaxValue / 2, int.MaxValue / 2, int.MaxValue / 2 }, new int[] { int.MaxValue, 0, int.MaxValue, 0 }, (long)2 * int.MaxValue)]
        [InlineData(new int[] { 256, 256, 256, 256 }, new int[] { 512, 0, 0, 512 }, 1024)]
        [InlineData(new int[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 }, new int[] { 64, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 120)]
        public void Czy_CzyOsobyPieniezneKwitaWeryfikator__StwierdzaStan_Kwita(int[] naleznosciPieniezneWGroszachPoczatkwa,
            int[] naleznosciPieniezneWGroszach , long oczekiwanaRoznica)
        {
            //Ustal 
            ITablicaOsobPienieznychIterowalna tablicaOsob = Stworz_TablicaOsobPienieznych.Stworz(naleznosciPieniezneWGroszach);

            ITablicaOsobPienieznychIterowalna tablicaOsobPoczatkowa = Stworz_TablicaOsobPienieznych.Stworz(naleznosciPieniezneWGroszachPoczatkwa);

            IRozniceDoStanuKwitaNaleznosciPienieznychSumator rozniceDoStanuKwitaSumator = Stworz_RozniceDoStanuKwitaNaleznosciPienieznychSumator.Stworz(tablicaOsobPoczatkowa);

            //Dzialaj
            long roznicaObliczona = rozniceDoStanuKwitaSumator.SumujRoznice(tablicaOsob);

            //Asercja
            Assert.Equal(oczekiwanaRoznica, roznicaObliczona);
        }
    }
}