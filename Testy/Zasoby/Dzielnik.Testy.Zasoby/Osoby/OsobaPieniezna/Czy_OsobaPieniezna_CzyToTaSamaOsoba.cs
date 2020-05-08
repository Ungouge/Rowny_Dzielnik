using System;

using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;

using Xunit;

namespace Dzielnik.Testy.Zasoby.Osoby.OsobaPieniezna
{
    public class Czy_OsobaPieniezna_CzyToTaSamaOsoba
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 0)]
        [InlineData(2, 0)]
        [InlineData(5, 0)]
        [InlineData(Byte.MaxValue, 0)]
        [InlineData(0, 1)]
        [InlineData(0, 2)]
        [InlineData(0, 5)]
        [InlineData(0, Byte.MaxValue)]
        [InlineData(1, 1)]
        [InlineData(2, 2 )]
        [InlineData(2, 5)]
        [InlineData(5,5)]
        [InlineData(Byte.MaxValue, Byte.MaxValue)]
        public void Czy_OsobaPieniezna_CzyToTaSamaOsoba_Zwraca_Prawde(byte iDOryginalne, byte iDPorownywane)
        {
            //Ustal
            INaleznoscPieniezna naleznosc = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Mock();

            IOsobaID osobaOryginalna = Stworz_OsobaPieniezna.Stworz(naleznosc, iDOryginalne);

            IOsobaID osobaPorownywana = Stworz_OsobaID_Moq.Stworz_ID_Moq(iDPorownywane);

            bool czyPowinnaBycToTaSamaOsoba = (iDOryginalne == iDPorownywane);

            //Dzialaj i Asercja
            Czy_OsobaID_CzyToTaSamaOsoba_Baza.Czy_OsobaID_CzyToTaSamaOsoba_Baza_Zwraca_Prawde(osobaOryginalna, osobaPorownywana, czyPowinnaBycToTaSamaOsoba);
        }
    }
}