using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Osoby.OsobaPieniezna
{
    public class Czy_OsobaPieniezna_OdejmnijNaleznoscOsobie
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
        [InlineData(357, 320, 37)]
        public void Czy_OsobaPieniezna_OdejmnijNaleznoscOsobie_ObliczaPoprawnie
            (int wplata, int dodawanaNaleznosc, int oczekiwanaNaleznosc)
        {
            //Ustal
            INaleznoscPieniezna naleznosc = Stworz_NaleznoscPieniezna.Stworz(wplata);

            IOsobaPieniezna osoba = Stworz_OsobaPieniezna.Stworz(naleznosc);

            INaleznoscPieniezna dodawanaNaleznosc_Mock = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Swiadczenie_Mock(dodawanaNaleznosc);

            //Dzialaj
            IOsobaPieniezna osobaPoDodaniuNaleznosci = osoba.OdejmnijNaleznoscPienieznaOsobie(dodawanaNaleznosc_Mock);

            //Asercja
            Assert.Equal(oczekiwanaNaleznosc, osobaPoDodaniuNaleznosci.Wplata.Swiadczenie);
        }
    }
}