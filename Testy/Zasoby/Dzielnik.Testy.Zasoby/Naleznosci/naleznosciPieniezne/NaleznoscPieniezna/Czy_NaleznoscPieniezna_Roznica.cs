using System;

using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci.NaleznoscPieniezna
{
    public class Czy_NaleznoscPieniezna_Roznica
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 0)]
        [InlineData(2, 2, 0)]
        [InlineData(2, 3, -1)]
        [InlineData(3, 3, 0)]
        [InlineData(3, 2, 1)]
        [InlineData(10, 5, 5)]
        [InlineData(32, 16, 16)]
        [InlineData(-1, -1, 0)]
        [InlineData(-2, 2, -4)]
        [InlineData(-5, 5, -10)]
        [InlineData(128, -64, 192)]
        [InlineData(128, 64, 64)]
        [InlineData(358, 320, 38)]
        [InlineData(Int32.MaxValue, Int32.MinValue, -1)]
        public void Czy_NaleznoscPieniezna_Roznica_ObliczaPoprawnie(int groszeSkladnik1, int groszeSkladnik2, int groszeOczekiwane)
        {
            //Ustal
            INaleznoscPieniezna naleznosc1 = Stworz_NaleznoscPieniezna.Stworz(groszeSkladnik1);

            INaleznoscPieniezna naleznosc2 = Stworz_NaleznoscPieniezna.Stworz(groszeSkladnik2);

            //Dzialaj
            Czy_NaleznoscPienieznaBaza_Roznica.Czy_Naleznosc_Roznica_ObliczaPoprawnie(naleznosc1, naleznosc2, groszeOczekiwane);
        }
    }
}