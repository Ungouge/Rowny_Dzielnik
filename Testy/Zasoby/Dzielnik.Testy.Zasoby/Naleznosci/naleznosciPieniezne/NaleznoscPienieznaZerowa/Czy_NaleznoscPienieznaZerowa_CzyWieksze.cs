using System;

using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci.NaleznoscPienieznaZerowa
{
    public class Czy_NaleznoscPienieznaZerowa_CzyWieksze
    {
        [Theory]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(3, true)]
        [InlineData(5, true)]
        [InlineData(-1, false)]
        [InlineData(-2, false)]
        [InlineData(-5, false)]
        [InlineData(128, true)]
        [InlineData(358, true)]
        [InlineData(Int32.MaxValue, true)]
        [InlineData(Int32.MinValue, false)]
        public void Czy_Naleznosc_CzyWieksze_ObliczaPoprawnie_Grosze(int groszeSkladnik, bool czyPowinnoBycWieksze)
        {
            //Ustal
            INaleznoscPieniezna naleznosc1 = Stworz_NaleznoscPienieznaZerowa.Stworz();

            INaleznoscPieniezna naleznosc2 = Stworz_NaleznoscPieniezna.Stworz(groszeSkladnik);

            //Dzialaj i Asercja
            Czy_NaleznoscPienieznaBaza_CzyWieksze.Czy_Naleznosc_CzyWieksze_ObliczaPoprawnie(naleznosc1, naleznosc2, czyPowinnoBycWieksze);
        }
    }
}