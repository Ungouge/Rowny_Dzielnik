using System;

using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Testy.Model.TabeleNaleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.TabelaNaleznosci
{
    public class Czy_TabelaNaleznosciPienieznej_ZwrocLepszeKryterium
    {
        [Theory]
        [InlineData(2, 1, 0)]
        [InlineData(2, 357, 1)]
        [InlineData(4, 0, 0)]
        [InlineData(4, 1, 0)]
        [InlineData(4, 2, 0)]
        [InlineData(4, 5, 0)]
        [InlineData(4, 357, 0)]
        [InlineData(4, Int32.MaxValue, 0)]
        [InlineData(4, 1, 1)]
        [InlineData(4, 2, 1)]
        [InlineData(4, 5, 1)]
        [InlineData(4, 357, 1)]
        [InlineData(4, Int32.MaxValue, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(4, 5, 2)]
        [InlineData(4, 357, 2)]
        [InlineData(4, Int32.MaxValue, 2)]
        [InlineData(4, 5, 5)]
        [InlineData(4, 357, 5)]
        [InlineData(4, Int32.MaxValue, 5)]
        [InlineData(4, 357, 357)]
        [InlineData(4, Int32.MaxValue, 357)]
        [InlineData(4, Int32.MaxValue, Int32.MaxValue)]
        [InlineData(8, 357, 320)]
        [InlineData(16, 357, 320)]
        [InlineData(32, 357, 320)]
        [InlineData(64, 357, 320)]
        [InlineData(128, 357, 320)]
        [InlineData(byte.MaxValue, 357, 320)]
        [InlineData(byte.MaxValue, int.MaxValue, 357)]
        public void Czy_Zwraca_TaSamaTabele(byte iloscOsob, int wymienionaNaleznosc, int wymienionaNaleznoscPorownywanej)
        {
            //Ustal
            ITabelaNaleznosciPienieznej tabelaNaleznosciPienieznej =
                Stworz_TabelaNaleznosciPienieznej.Stworz(wymienionaNaleznosc, iloscOsob);

            ITabelaNaleznosciPienieznej tabelaNaleznosciPienieznejPorownywana =
                Stworz_TabelaNaleznosciPienieznej_Mock.
                Stworz_TabelaNaleznosciPienieznej_KryteriumWyboruTabeliNaleznosci_WezWymienionaNaleznosc_Mock(wymienionaNaleznoscPorownywanej);

            //Dzialaj
            ITabelaNaleznosciPienieznej tabelaNaleznosciPienieznejZwrocona =
                tabelaNaleznosciPienieznej.ZwrocLepszeKryterium(tabelaNaleznosciPienieznejPorownywana);

            //Asercja
            Assert.Same(tabelaNaleznosciPienieznej, tabelaNaleznosciPienieznejZwrocona);
        }
    }
}