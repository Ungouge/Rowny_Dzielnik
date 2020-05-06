using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci.NaleznoscPienieznaZerowa
{
    public class Czy_NaleznoscPienieznaZerowa_Swiadczenie
    {
        [Fact]
        public void Czy_NaleznoscPienieznaZerowa_Swiadczenie_Zwraca_PrawidlowaWartosc()
        {
            INaleznoscPieniezna naleznosc = Stworz_NaleznoscPienieznaZerowa.Stworz();

            Czy_NaleznoscPienieznaBaza_SwiadczenieWPolgroszach.Czy_Naleznosc_SwiadczenieWPolgroszach_Zwraca_PrawidlowaWartosc(naleznosc, 0);
        }
    }
}