using System;

using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci.NaleznoscPieniezna
{
    public class Czy_Naleznosc_Odwrotnosc
    {
        [Theory]
        [InlineData(0, -0)]
        [InlineData(1, -1)]
        [InlineData(2, -2)]
        [InlineData(5, -5)]
        [InlineData(-1, 1)]
        [InlineData(-2, 2)]
        [InlineData(-5, 5)]
        [InlineData(64, -64)]
        [InlineData(128, -128)]
        [InlineData(357, -357)]
        [InlineData(Int32.MaxValue, Int32.MinValue + 1)]
        public void Czy_Naleznosc_Odwrotnosc_ObliczaPoprawnie(int grosze, int groszeOczekiwane)
        {
            //Ustal
            INaleznoscPieniezna naleznosc = Stworz_NaleznoscPieniezna.Stworz(grosze);

            //Dzialaj i Asercja
            Czy_NaleznoscPienieznaBaza_Odwrotnosc.Czy_Naleznosc_Odwrotnosc_ObliczaPoprawnie(naleznosc, groszeOczekiwane);
        }
    }
}