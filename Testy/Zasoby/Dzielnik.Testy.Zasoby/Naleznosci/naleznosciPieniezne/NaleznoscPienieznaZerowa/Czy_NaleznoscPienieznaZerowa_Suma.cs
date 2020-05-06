using System;

using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci.NaleznoscPienieznaZerowa
{
    public class Czy_NaleznoscPienieznaZerowa_Suma
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(5, 5)]
        [InlineData(-1, -1)]
        [InlineData(-2, -2)]
        [InlineData(-5, -5)]
        [InlineData(128, 128)]
        [InlineData(357, 357)]
        [InlineData(Int32.MaxValue, Int32.MaxValue)]
        [InlineData(Int32.MinValue, Int32.MinValue)]
        public void Czy_Naleznosc_Suma_ObliczaPoprawnie_Grosze(int groszeSkladnik, int polgroszeOczekiwane)
        {
            //Ustal
            INaleznoscPieniezna naleznosc1 = Stworz_NaleznoscPienieznaZerowa.Stworz();

            INaleznoscPieniezna naleznosc2 = Stworz_NaleznoscPieniezna.Stworz(groszeSkladnik);

            //Dzialaj i Asercja
            Czy_NaleznoscPienieznaBaza_Suma.Czy_Naleznosc_Suma_ObliczaPoprawnie(naleznosc1, naleznosc2, polgroszeOczekiwane);
        }
    }
}