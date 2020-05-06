using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci.NaleznoscPienieznaZerowa
{
    public class Czy_NaleznoscPienieznaZerowa_Odwrotnosc
    {
        [Fact]
        public void Czy_Naleznosc_Odwrotnosc_ObliczaPoprawnie()
        {
            //Ustal
            INaleznoscPieniezna naleznosc = Stworz_NaleznoscPienieznaZerowa.Stworz();

            //Dzialaj i Asercja
            Czy_NaleznoscPienieznaBaza_Odwrotnosc.Czy_Naleznosc_Odwrotnosc_ObliczaPoprawnie(naleznosc, 0);
        }
    }
}