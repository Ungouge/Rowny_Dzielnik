using System;

using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru.KryteriumSumyWymienionejNaleznosciPienieznej
{
    public class Czy_KryteriumSumyWymienionejNaleznoscipienieznej_CzyPorownywaneKyrteriumLepsze
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(357)]
        [InlineData(Int32.MaxValue)]
        public void Czy_Zrwaca_LepszeKryterium_ZPoczatkowegoKryterium
            ( int NaleznoscWPolgroszach_Kryterium_Porownywana)
        {
            //Ustal
            IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumyWymienionejNaleznosci_Sprawdzana = Stworz_KryteriumWyboruTabeliNaleznosciPienieznych.Stworz_KryteriumSumyWymienionejNaleznosci();

            IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumyWymienionejNaleznosci_Porownywana =
                Stworz_KryteriumSumyWymienionejNaleznosciPienieznej_Mock.Stworz_Kryterium_Naleznosc_Polgrsze_Mock(NaleznoscWPolgroszach_Kryterium_Porownywana);

            //Dzialaj
            bool Czy_KryteriumWieksze = 
                kryteriumSumyWymienionejNaleznosci_Sprawdzana.CzyPorownywaneKyrteriumLepsze(kryteriumSumyWymienionejNaleznosci_Porownywana);

            //Asercja
            Assert.True(Czy_KryteriumWieksze);
        }

        [Theory]
        [InlineData(1, 357)]
        [InlineData(2, 357)]
        [InlineData(5, 357)]
        [InlineData(0, Int32.MaxValue)]
        public void Czy_ZwracaPrawde_GdyPorownywanyWieksze
            (int NaleznoscWPolgroszach_Kryterium_Sprawdzane, int NaleznoscWPolgroszach_Kryterium_Porownywana)
        {
            //Ustal
            INaleznoscPieniezna naleznosc_Sprawdzana = Stworz_NaleznoscPieniezna.Stworz(NaleznoscWPolgroszach_Kryterium_Sprawdzane);

            IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumyWymienionejNaleznosci_Sprawdzana =
                Stworz_KryteriumWyboruTabeliNaleznosciPienieznych.Stworz_KryteriumSumyWymienionejNaleznosci(naleznosc_Sprawdzana);

            IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumyWymienionejNaleznosci_Porownywana =
                Stworz_KryteriumSumyWymienionejNaleznosciPienieznej_Mock.Stworz_Kryterium_Naleznosc_Polgrsze_Mock(NaleznoscWPolgroszach_Kryterium_Porownywana);

            //Dzialaj
            bool Czy_KryteriumWieksze =
                kryteriumSumyWymienionejNaleznosci_Sprawdzana.CzyPorownywaneKyrteriumLepsze(kryteriumSumyWymienionejNaleznosci_Porownywana);

            //Asercja
            Assert.True(Czy_KryteriumWieksze);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(2, 0)]
        [InlineData(5, 0)]
        [InlineData(357, 0)]
        [InlineData(Byte.MaxValue, 0)]
        [InlineData(357, 357)]
        [InlineData(1, 1)]
        public void Czy_ZwracaniePrawde_GdyPorownywanyMniejsze
            (int NaleznoscWPolgroszach_Kryterium_Sprawdzane, int NaleznoscWPolgroszach_Kryterium_Porownywana)
        {
            //Ustal
            INaleznoscPieniezna naleznosc_Sprawdzana = Stworz_NaleznoscPieniezna.Stworz(NaleznoscWPolgroszach_Kryterium_Sprawdzane);

            IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumyWymienionejNaleznosci_Sprawdzana =
                Stworz_KryteriumWyboruTabeliNaleznosciPienieznych.Stworz_KryteriumSumyWymienionejNaleznosci(naleznosc_Sprawdzana);

            IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumyWymienionejNaleznosci_Porownywana =
                Stworz_KryteriumSumyWymienionejNaleznosciPienieznej_Mock.Stworz_Kryterium_Naleznosc_Polgrsze_Mock(NaleznoscWPolgroszach_Kryterium_Porownywana);

            //Dzialaj
            bool Czy_KryteriumWieksze =
                kryteriumSumyWymienionejNaleznosci_Sprawdzana.CzyPorownywaneKyrteriumLepsze(kryteriumSumyWymienionejNaleznosci_Porownywana);

            //Asercja
            Assert.False(Czy_KryteriumWieksze);
        }

        [Fact]
        public void Czy_ZwracaSiebie_GdyPorownywanyZeZlymTypem()
        {
            //Ustal
            IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumyWymienionejNaleznosci_Sprawdzana =
                Stworz_KryteriumWyboruTabeliNaleznosciPienieznych.Stworz_KryteriumSumyWymienionejNaleznosci();

            IKryteriumIlosciWymian kryteriumIlosciWymian = Stworz_KryteriumIlosciWymian_Mock.Stworz_KryteriumIlosciWymian_WezIlosciWymian_Mock(ushort.MaxValue);

            //Dzialaj
            bool Czy_KryteriumWieksze =
                kryteriumSumyWymienionejNaleznosci_Sprawdzana.CzyPorownywaneKyrteriumLepsze(kryteriumIlosciWymian);

            //Asercja
            Assert.False(Czy_KryteriumWieksze);
        }
    }
}