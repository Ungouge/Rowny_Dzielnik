using System;

using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

using Xunit;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru.KryteriumIlosciWymian
{
    public class Czy_KryteriumIlosciWymian_CzyPorownywaneKyrteriumLepsze
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(5, 5)]
        [InlineData(357, 357)]
        [InlineData(UInt16.MaxValue, Int32.MaxValue)]
        public void Czy_Zrwaca_Falsz_ZPocztkowegoKryterium(ushort ilosciWymianPorownywana, int naleznoscWGroszach)
        {
            //Ustal
            IKryteriumIlosciWymian kryteriumIlosciWymian_Sprawdzana = Stworz_KryteriumWymienionejNaleznosciPienieznej.Stworz_KryteriumIlosciWymian();

            IKryteriumIlosciWymian kryteriumIlosciWymian_Porownywana =
                Stworz_KryteriumIlosciWymian_Mock.Stworz_KryteriumIlosciWymian_WezIlosciWymian_WezWymienionaNaleznosc_Mock(
                    ilosciWymianPorownywana, naleznoscWGroszach);

            //Dzialaj
            bool Czy_KryteriumWieksze =
                kryteriumIlosciWymian_Sprawdzana.CzyPorownywaneKyrteriumLepsze(kryteriumIlosciWymian_Porownywana);

            //Asercja
            Assert.False(Czy_KryteriumWieksze);
        }

        [Theory]
        [InlineData(1, 1, 2, 5)]
        [InlineData(2, 1, 2, 5)]
        [InlineData(5, 1, 5, 357)]
        [InlineData(357, 1, 357, Int32.MaxValue)]
        [InlineData(2, 2, 5, 357)]
        [InlineData(5, 2, 5, 357)]
        [InlineData(357, 2, 357, Int32.MaxValue)]
        [InlineData(5, 5, 357, Int32.MaxValue)]
        [InlineData(357, 5, 357, Int32.MaxValue)]
        public void Czy_ZwracaPrawde_GdyPorownywanyWieksze(ushort ilosciWymianSprawdzana, ushort ilosciWymianPorownywana,
            int swiadczenieWGroszachSprawdzana, int swiadczenieWGroszachPorownywana)
        {
            bool czy_KryteriumWieksze = 
                Czy_Kryterium_Wieksze(ilosciWymianSprawdzana, ilosciWymianPorownywana, swiadczenieWGroszachSprawdzana, swiadczenieWGroszachPorownywana);

            //Asercja
            Assert.True(czy_KryteriumWieksze);
        }

        [Theory]
        [InlineData(0, 1, 0, 1)]
        [InlineData(1, 1, 2, 1)]
        [InlineData(1, 2, 1, 2)]
        [InlineData(1, 5, 1, 5)]
        [InlineData(1, 357, 1, 357)]
        [InlineData(2, 2, 5, 2)]
        [InlineData(2, 5, 2, 5)]
        [InlineData(2, 357, 5, 357)]
        [InlineData(5, 5, 357, 5)]
        [InlineData(5, 357, 5, 357)]
        [InlineData(2, 1, 5, 2)]
        [InlineData(5, 1, 357, 5)]
        [InlineData(357, 1, Int32.MaxValue, 357)]
        [InlineData(5, 2, 357, 5)]
        [InlineData(357, 2, Int32.MaxValue, 357)]
        [InlineData(357, 5, Int32.MaxValue, 357)]
        public void Czy_ZwracanieFalsz_GdyPorownywanyMniejsze(ushort ilosciWymianSprawdzana, ushort ilosciWymianPorownywana,
            int swiadczenieWGroszachSprawdzana, int swiadczenieWGroszachPorownywana)
        {
            //Ustal i dzialaj
            bool czy_KryteriumWieksze = 
                Czy_Kryterium_Wieksze(ilosciWymianSprawdzana, ilosciWymianPorownywana, swiadczenieWGroszachSprawdzana, swiadczenieWGroszachPorownywana);

            //Asercja
            Assert.False(czy_KryteriumWieksze);
        }

        private static bool Czy_Kryterium_Wieksze(ushort ilosciWymianSprawdzana, ushort ilosciWymianPorownywana, int swiadczenieWGroszachSprawdzana, int swiadczenieWGroszachPorownywana)
        {
            //Ustal
            INaleznoscPieniezna naleznoscPienieznaSprawdzana = Stworz_NaleznoscPieniezna.Stworz(swiadczenieWGroszachSprawdzana);

            IKryteriumIlosciWymian kryteriumIlosciWymian_Sprawdzana =
                Stworz_KryteriumWymienionejNaleznosciPienieznej.Stworz_KryteriumIlosciWymian(ilosciWymianSprawdzana, naleznoscPienieznaSprawdzana);

            IKryteriumIlosciWymian kryteriumIlosciWymian_Porownywana =
                Stworz_KryteriumIlosciWymian_Mock.Stworz_KryteriumIlosciWymian_WezIlosciWymian_WezWymienionaNaleznosc_Mock(ilosciWymianPorownywana, swiadczenieWGroszachPorownywana);

            //Dzialaj
            return kryteriumIlosciWymian_Sprawdzana.CzyPorownywaneKyrteriumLepsze(kryteriumIlosciWymian_Porownywana);
        }

        [Fact]
        public void Czy_ZwracaFalsz_GdyPorownywanyZeZlymTypem()
        {
            //Ustal
            INaleznoscPieniezna naleznoscPienieznaSprawdzana = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Mock();

            IKryteriumIlosciWymian kryteriumIlosciWymian_Sprawdzana =
                Stworz_KryteriumWymienionejNaleznosciPienieznej.Stworz_KryteriumIlosciWymian(1, naleznoscPienieznaSprawdzana);

            IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumyWymienionejNaleznosci =
                Stworz_KryteriumWymienionejNaleznosciPienieznej.Stworz_KryteriumSumyWymienionejNaleznosci();

            //Dzialaj
            bool Czy_KryteriumWieksze =
                kryteriumIlosciWymian_Sprawdzana.CzyPorownywaneKyrteriumLepsze(kryteriumSumyWymienionejNaleznosci);

            //Asercja
            Assert.False(Czy_KryteriumWieksze);
        }
    }
}