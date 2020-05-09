using System;

using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

using Xunit;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru.KryteriumIlosciWymian
{
    public class Czy_KryteriumIlosciWymian_CzyPorownywaneKyrteriumLepsze
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(357)]
        [InlineData(UInt16.MaxValue)]
        public void Czy_Zrwaca_LepszeKryterium_ZPoczatkowegoKryterium(ushort ilosciWymian_Kryterium_Porownywana)
        {
            //Ustal
            IKryteriumIlosciWymian kryteriumIlosciWymian_Sprawdzana = Stworz_KryteriumWyboruTabeliNaleznosciPienieznych.Stworz_KryteriumIlosciWymian();

            IKryteriumIlosciWymian kryteriumIlosciWymian_Porownywana =
                Stworz_KryteriumIlosciWymian_Mock.Stworz_KryteriumIlosciWymian_WezIlosciWymian_Mock(ilosciWymian_Kryterium_Porownywana);

            //Dzialaj
            bool Czy_KryteriumWieksze =
                kryteriumIlosciWymian_Sprawdzana.CzyPorownywaneKyrteriumLepsze(kryteriumIlosciWymian_Porownywana);

            //Asercja
            Assert.True(Czy_KryteriumWieksze);
        }

        [Theory]
        [InlineData(1, 357)]
        [InlineData(2, 357)]
        [InlineData(5, 357)]
        [InlineData(0, UInt16.MaxValue)]
        [InlineData(357, UInt16.MaxValue)]
        public void Czy_ZwracaPrawde_GdyPorownywanyWieksze(ushort ilosciWymian_Kryterium_Sprawdzane, ushort ilosciWymian_Kryterium_Porownywana)
        {
            //Ustal
            IKryteriumIlosciWymian kryteriumIlosciWymian_Sprawdzana =
                Stworz_KryteriumWyboruTabeliNaleznosciPienieznych.Stworz_KryteriumIlosciWymian(ilosciWymian_Kryterium_Sprawdzane);

            IKryteriumIlosciWymian kryteriumIlosciWymian_Porownywana = 
                Stworz_KryteriumIlosciWymian_Mock.Stworz_KryteriumIlosciWymian_WezIlosciWymian_Mock(ilosciWymian_Kryterium_Porownywana);

            //Dzialaj
            bool Czy_KryteriumWieksze =
                kryteriumIlosciWymian_Sprawdzana.CzyPorownywaneKyrteriumLepsze(kryteriumIlosciWymian_Porownywana);

            //Asercja
            Assert.True(Czy_KryteriumWieksze);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(5, 0)]
        [InlineData(357, 0)]
        [InlineData(357, 357)]
        [InlineData(1, 1)]
        public void Czy_ZwracaniePrawde_GdyPorownywanyMniejsze(ushort ilosciWymian_Kryterium_Sprawdzane, ushort ilosciWymian_Kryterium_Porownywana)
        {
            //Ustal
            IKryteriumIlosciWymian kryteriumIlosciWymian_Sprawdzana = 
                Stworz_KryteriumWyboruTabeliNaleznosciPienieznych.Stworz_KryteriumIlosciWymian(ilosciWymian_Kryterium_Sprawdzane);

            IKryteriumIlosciWymian kryteriumIlosciWymian_Porownywana = 
                Stworz_KryteriumIlosciWymian_Mock.Stworz_KryteriumIlosciWymian_WezIlosciWymian_Mock(ilosciWymian_Kryterium_Porownywana);

            //Dzialaj
            bool Czy_KryteriumWieksze =
                kryteriumIlosciWymian_Sprawdzana.CzyPorownywaneKyrteriumLepsze(kryteriumIlosciWymian_Porownywana);

            //Asercja
            Assert.False(Czy_KryteriumWieksze);
        }

        [Fact]
        public void Czy_ZwracaSiebie_GdyPorownywanyZeZlymTypem()
        {
            //Ustal
            IKryteriumIlosciWymian kryteriumIlosciWymian_Sprawdzana =
                Stworz_KryteriumIlosciWymian_Mock.Stworz_KryteriumIlosciWymian_WezIlosciWymian_Mock(ushort.MaxValue);

            IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumyWymienionejNaleznosci =
                Stworz_KryteriumWyboruTabeliNaleznosciPienieznych.Stworz_KryteriumSumyWymienionejNaleznosci();

            //Dzialaj
            bool Czy_KryteriumWieksze =
                kryteriumIlosciWymian_Sprawdzana.CzyPorownywaneKyrteriumLepsze(kryteriumSumyWymienionejNaleznosci);

            //Asercja
            Assert.False(Czy_KryteriumWieksze);
        }
    }
}