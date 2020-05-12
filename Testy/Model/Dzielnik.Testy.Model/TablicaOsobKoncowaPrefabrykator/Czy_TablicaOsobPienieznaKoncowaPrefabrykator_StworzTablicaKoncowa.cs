using System;

using Dzielnik.Model.Interfejsy.TablicaOsobKoncowaPrefabrykator;
using Dzielnik.Testy.Zasoby.TabliceOsob;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

using Xunit;

namespace Dzielnik.Testy.Model.TablicaOsobKoncowaPrefabrykator
{
    public class Czy_TablicaOsobPienieznaKoncowaPrefabrykator_StworzTablicaKoncowa
    {
        [Theory]
        [InlineData(new int[] { 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0 })]
        [InlineData(new int[] { 128, 64, -128, -64 }, new int[] { 0, 0, 0, 0 })]
        [InlineData(new int[] { 4, 0, 0, 0 }, new int[] { 1, 1, 1, 1 })]
        [InlineData(new int[] { 8, 0, 0, 0 }, new int[] { 2, 2, 2, 2 })]
        [InlineData(new int[] { 20, 0, 0, 0 }, new int[] { 5, 5, 5, 5 })]
        [InlineData(new int[] { 0, 0, 0, 20 }, new int[] { 5, 5, 5, 5 })]
        [InlineData(new int[] { 20, 20, 0, 0 }, new int[] { 10, 10, 10, 10 })]
        [InlineData(new int[] { 21, 0, 0, 0 }, new int[] { 6, 5, 5, 5 })]
        [InlineData(new int[] { 22, 0, 0, 0 }, new int[] { 6, 6, 5, 5 })]
        [InlineData(new int[] { 23, 0, 0, 0 }, new int[] { 6, 6, 6, 5 })]
        [InlineData(new int[] { 24, 0, 0, 0 }, new int[] { 6, 6, 6, 6 })]
        [InlineData(new int[] { 10, 0, -10, -20 }, new int[] { -5, -5, -5, -5 })]
        [InlineData(new int[] { 256, 128, 512, 0 }, new int[] { 224, 224, 224, 224 })]
        [InlineData(new int[] { -4, 0, 0, 0 }, new int[] { -1, -1, -1, -1 })]
        [InlineData(new int[] { -8, 0, 0, 0 }, new int[] { -2, -2, -2, -2 })]
        [InlineData(new int[] { -20, 0, 0, 0 }, new int[] { -5, -5, -5, -5 })]
        [InlineData(new int[] { 0, 0, 0, -20 }, new int[] { -5, -5, -5, -5 })]
        [InlineData(new int[] { -20, -20, 0, 0 }, new int[] { -10, -10, -10, -10 })]
        [InlineData(new int[] { -21, 0, 0, 0 }, new int[] { -5, -5, -5, -6 })]
        [InlineData(new int[] { -22, 0, 0, 0 }, new int[] { -5, -5, -6, -6 })]
        [InlineData(new int[] { -23, 0, 0, 0 }, new int[] { -5, -6, -6, -6 })]
        [InlineData(new int[] { -24, 0, 0, 0 }, new int[] { -6, -6, -6, -6 })]
        [InlineData(new int[] { -10, 0, 10, 20 }, new int[] { 5, 5, 5, 5 })]
        [InlineData(new int[] { -256, -128, -512, 0 }, new int[] { -224, -224, -224, -224 })]
        [InlineData(new int[] { Int32.MaxValue, Int32.MaxValue, Int32.MinValue, Int32.MinValue }, new int[] { 0, 0, -1, -1 })]
        public void Czy_StworzTablicaKoncowa_Stworza_Prawidlowo(int[] tabelaSwiadczenPoczatkowa, int[] tabelaSwiadczenOczekiwana)
        {
            //Ustal
            ITablicaOsobPienieznaKoncowaPrefabrykator tablicaosobKoncowaPrefabrykator = Stworz_TablicaOsobPienieznaKoncowaPrefabrykator.Stworz();

            ITablicaOsobPienieznychZwrotna tablicaOsobPienieznychPoczatkowa = 
                Stworz_TablicaOsobPienieznych_Mock.Stworz_GetEnumerator_WezIloscOsob_Mock(tabelaSwiadczenPoczatkowa);

            //Dzialaj
            ITablicaOsobPienieznychZwrotna tablicaOsobPienieznychKoncowa = tablicaosobKoncowaPrefabrykator.StworzTablicaKoncowa(tablicaOsobPienieznychPoczatkowa);

            //Asercja
            for (byte iD = 0; iD < tablicaOsobPienieznychKoncowa.WezIloscOsob; iD++)
                Assert.Equal(tabelaSwiadczenOczekiwana[iD], tablicaOsobPienieznychKoncowa[iD].Wplata.Swiadczenie);
        }
    }
}