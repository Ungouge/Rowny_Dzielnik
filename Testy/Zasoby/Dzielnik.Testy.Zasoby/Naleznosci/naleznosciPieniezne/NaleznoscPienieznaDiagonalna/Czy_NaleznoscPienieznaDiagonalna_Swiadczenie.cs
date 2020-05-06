using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci.NaleznoscPienieznaDiagonalna
{
    public class Czy_NaleznoscPienieznaDiagonalna_Swiadczenie
    {
        [Fact]
        public void Czy_NaleznoscPienieznaDiagonalna_Swiadczenie_Zwraca_PrawidlowaWartosc()
        {
            INaleznoscPienieznaSwiadczenie naleznosc = Stworz_NaleznoscPienieznaDiagonalna.Stworz();

            Czy_NaleznoscPienieznaBaza_SwiadczenieWPolgroszach.Czy_Naleznosc_SwiadczenieWPolgroszach_Zwraca_PrawidlowaWartosc(naleznosc, 0);
        }
    }
}