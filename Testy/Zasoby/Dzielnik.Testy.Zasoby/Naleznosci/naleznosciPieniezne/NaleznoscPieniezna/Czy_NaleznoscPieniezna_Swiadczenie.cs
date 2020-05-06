using System;

using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci.NaleznoscPieniezna
{
    public class Czy_NaleznoscPieniezna_Swiadczenie
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(-1)]
        [InlineData(128)]
        [InlineData(Int32.MaxValue)]
        [InlineData(Int32.MinValue)]
        public void Czy_NaleznoscPieniezna_Swiadczenie_Zwraca_PrawidlowaWartosc(int grosze)
        {
            INaleznoscPieniezna naleznosc = Stworz_NaleznoscPieniezna.Stworz(grosze);

            Czy_NaleznoscPienieznaBaza_SwiadczenieWPolgroszach.Czy_Naleznosc_SwiadczenieWPolgroszach_Zwraca_PrawidlowaWartosc(naleznosc, grosze);
        }
    }
}