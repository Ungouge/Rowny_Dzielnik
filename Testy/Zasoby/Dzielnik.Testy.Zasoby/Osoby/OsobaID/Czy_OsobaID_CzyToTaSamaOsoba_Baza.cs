using Dzielnik.Zasoby.Interfejsy.Osoby;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Osoby
{
    internal static class Czy_OsobaID_CzyToTaSamaOsoba_Baza
    {
        internal static void Czy_OsobaID_CzyToTaSamaOsoba_Baza_Zwraca_Prawde(IOsobaID osobaOryginalna, IOsobaID osobaPorownywana, bool czyPowinnaBycToTaSamaOsoba)
        {
            //Dzialaj
            bool czyToTaSamaOsoba = osobaOryginalna.CzyToTaSamaOsoba(osobaPorownywana);

            //Asercja
            Assert.Equal(czyPowinnaBycToTaSamaOsoba, czyToTaSamaOsoba);
        }
    }
}