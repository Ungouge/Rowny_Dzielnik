using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci
{
    internal static class Czy_NaleznoscPienieznaBaza_Odwrotnosc
    {
        internal static void Czy_Naleznosc_Odwrotnosc_ObliczaPoprawnie(INaleznoscPieniezna naleznosc, int swiadczenieOczekiwane)
        {
            //Dzialaj
            INaleznoscPieniezna naleznoscOdwrotnosc = naleznosc.Odwrotnosc();

            //Asercja
            Assert.Equal(swiadczenieOczekiwane, naleznoscOdwrotnosc.Swiadczenie);
        }
    }
}