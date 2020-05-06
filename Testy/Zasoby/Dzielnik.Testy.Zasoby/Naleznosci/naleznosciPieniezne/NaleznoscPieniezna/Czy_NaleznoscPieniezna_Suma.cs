using System;

using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci.NaleznoscPieniezna
{
    public class Czy_Naleznosc_Suma
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(5, 5, 10)]
        [InlineData(-1, -1, -2)]
        [InlineData(-2, -2, -4)]
        [InlineData(-5, -5, -10)]
        [InlineData(128, 64, 192)]
        [InlineData(128, -64, 64)]
        [InlineData(357, 320, 677)]
        [InlineData(Int32.MaxValue, Int32.MinValue, -1)]
        public void Czy_Naleznosc_Suma_ObliczaPoprawnie(int groszeSkladnik1, int groszeSkladnik2, int groszeOczekiwane)
        {
            //Ustal
            INaleznoscPieniezna naleznosc1 = Stworz_NaleznoscPieniezna.Stworz(groszeSkladnik1);

            INaleznoscPieniezna naleznosc2 = Stworz_NaleznoscPieniezna.Stworz(groszeSkladnik2);

            //Dzialaj i Asercja
            Czy_NaleznoscPienieznaBaza_Suma.Czy_Naleznosc_Suma_ObliczaPoprawnie(naleznosc1, naleznosc2, groszeOczekiwane);
        }
    }
}