using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Naleznosci
{
    internal static class Czy_NaleznoscPienieznaBaza_CzyWieksze
    {
        internal static void Czy_Naleznosc_CzyWieksze_ObliczaPoprawnie(INaleznoscPieniezna naleznosc1, INaleznoscPieniezna naleznosc2, bool czyPowinnoBycWieksze)
        {
            //Dzialaj
            bool czyWieksze = naleznosc1.CzyWieksze(naleznosc2);

            //Asercja
            Assert.Equal(czyPowinnoBycWieksze, czyWieksze);
        }
    }
}