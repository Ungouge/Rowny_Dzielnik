using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci
{
    internal static class Czy_NaleznoscPienieznaBaza_Roznica
    {
        internal static void Czy_Naleznosc_Roznica_ObliczaPoprawnie(INaleznoscPieniezna naleznosc1, INaleznoscPieniezna naleznosc2, int swiadczenieOczekiwane)
        {
            //Dzialaj
            INaleznoscPieniezna naleznoscRoznica = naleznosc1.Roznica(naleznosc2);

            //Asercja
            Assert.Equal(swiadczenieOczekiwane, naleznoscRoznica.Swiadczenie);
        }
    }
}