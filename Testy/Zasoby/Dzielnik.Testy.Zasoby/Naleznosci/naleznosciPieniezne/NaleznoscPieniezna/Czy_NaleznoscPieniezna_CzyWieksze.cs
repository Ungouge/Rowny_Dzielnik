using System;

using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci.NaleznoscPieniezna
{
    public class Czy_NaleznoscPieniezna_CzyWieksze
    {
        [Theory]
        [InlineData(0, 0, false)]
        [InlineData(1, 1, false)]
        [InlineData(3, 2, false)]
        [InlineData(5, 0, false)]
        [InlineData(0, 2, true)]
        [InlineData(-1, -1, false)]
        [InlineData(-2, -2, false)]
        [InlineData(-5, 5, true)]
        [InlineData(128, 64, false)]
        [InlineData(128, -64, false)]
        [InlineData(358, 320, false)]
        [InlineData(Int32.MaxValue, Int32.MinValue, false)]
        [InlineData(Int32.MinValue, Int32.MaxValue, true)]
        public void Czy_NaleznoscPieniezna_CzyWieksze_ObliczaPoprawnie(int groszeSkładnik1, int groszeSkładnik2, bool czyPowinnoBycWieksze)
        {
            //Ustal
            INaleznoscPieniezna naleznosc1 = Stworz_NaleznoscPieniezna.Stworz(groszeSkładnik1);

            INaleznoscPieniezna naleznosc2 = Stworz_NaleznoscPieniezna.Stworz(groszeSkładnik2);

            //Dzialaj i Asercja
            Czy_NaleznoscPienieznaBaza_CzyWieksze.Czy_Naleznosc_CzyWieksze_ObliczaPoprawnie(naleznosc1, naleznosc2, czyPowinnoBycWieksze);
        }
    }
}