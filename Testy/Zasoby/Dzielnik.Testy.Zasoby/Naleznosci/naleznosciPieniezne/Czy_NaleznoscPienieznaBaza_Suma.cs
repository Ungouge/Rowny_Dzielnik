using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci
{
    internal static class Czy_NaleznoscPienieznaBaza_Suma
    {
        internal static void Czy_Naleznosc_Suma_ObliczaPoprawnie(INaleznoscPieniezna naleznosc1, INaleznoscPieniezna naleznosc2, int swiadczenieOczekiwane)
        {
            //Dzialaj
            INaleznoscPieniezna naleznoscSuma = naleznosc1.Suma(naleznosc2);

            //Asercja
            Assert.Equal(swiadczenieOczekiwane, naleznoscSuma.Swiadczenie);
        }
    }
}