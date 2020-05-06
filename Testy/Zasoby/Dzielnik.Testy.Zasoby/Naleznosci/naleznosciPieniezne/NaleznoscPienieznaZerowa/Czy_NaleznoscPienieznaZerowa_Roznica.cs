using System;

using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci.NaleznoscPienieznaZerowa
{
    public class Czy_NaleznoscPienieznaZerowa_Roznica
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, -1)]
        [InlineData(2, -2)]
        [InlineData(3, -3)]
        [InlineData(5, -5)]
        [InlineData(32, -32)]
        [InlineData(-1, 1)]
        [InlineData(-2, 2)]
        [InlineData(-5, 5)]
        [InlineData(128, -128)]
        [InlineData(-357, 357)]
        [InlineData(Int32.MaxValue, Int32.MinValue + 1)]
        public void Czy_Naleznosc_Roznica_ObliczaPoprawnie( int groszeSkładnik, int groszeOczekiwane)
        {
            //Ustal
            INaleznoscPieniezna naleznosc1 = Stworz_NaleznoscPienieznaZerowa.Stworz();

            INaleznoscPieniezna naleznosc2 = Stworz_NaleznoscPieniezna.Stworz(groszeSkładnik);

            //Dzialaj
            Czy_NaleznoscPienieznaBaza_Roznica.Czy_Naleznosc_Roznica_ObliczaPoprawnie(naleznosc1, naleznosc2, groszeOczekiwane);
        }
    }
}