using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci
{
    internal static class Czy_NaleznoscPienieznaBaza_SwiadczenieWPolgroszach
    {
        internal static void Czy_Naleznosc_SwiadczenieWPolgroszach_Zwraca_PrawidlowaWartosc(INaleznoscPienieznaSwiadczenie naleznosc, int swiadczenie)
        {
            //Asercje
            Assert.Equal(naleznosc.Swiadczenie, swiadczenie);
        }
    }
}