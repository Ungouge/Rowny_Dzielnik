using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Osoby.OsobaPieniezna
{
    public class Czy_OsobaPieniezna_DodajNaleznoscOsobie
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
        public void Czy_OsobaPieniezna_DodajNaleznoscOsobie_ObliczaPoprawnie
            (int wplata, int dodawanaNaleznosc, int oczekiwanaNaleznosc)
        {
            //Ustal
            INaleznoscPieniezna naleznosc = Stworz_NaleznoscPieniezna.Stworz(wplata);

            IOsobaPieniezna osoba = Stworz_OsobaPieniezna.Stworz(naleznosc);

            INaleznoscPieniezna dodawanaNaleznosc_Mock = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Swiadczenie_Mock(dodawanaNaleznosc);

            //Dzialaj
            IOsobaPieniezna osobaPoDodaniuNaleznosci = osoba.DodajNaleznoscPienieznaOsobie(dodawanaNaleznosc_Mock);

            //Asercja
            Assert.Equal(oczekiwanaNaleznosc, osobaPoDodaniuNaleznosci.Wplata.Swiadczenie);
        }
    }
}