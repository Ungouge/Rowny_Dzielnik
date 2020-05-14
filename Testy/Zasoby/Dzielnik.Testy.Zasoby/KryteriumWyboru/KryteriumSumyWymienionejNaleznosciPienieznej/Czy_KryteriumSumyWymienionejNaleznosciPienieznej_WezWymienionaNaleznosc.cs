using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru.KryteriumSumyWymienionejNaleznosciPienieznej
{
    public class Czy_KryteriumSumyWymienionejNaleznosciPienieznej_WezWymienionaNaleznosc
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(357)]
        [InlineData(byte.MaxValue)]
        public void Czy_KryteriumSumyWymienionejNaleznosciPienieznej_WezWymienionaNaleznosc_Zwraca_PrawidlowaNaleznosc (int wpalata)
        {
            //Ustal i Dzialaj
            INaleznoscPieniezna naleznoscPieniezna = Stworz_NaleznoscPieniezna.Stworz(wpalata);

            IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumyWymienionejNaleznosci_Sprawdzana =
                Stworz_KryteriumWymienionejNaleznosciPienieznej.Stworz_KryteriumSumyWymienionejNaleznosci(naleznoscPieniezna);

            //Asercja
            Assert.Equal(wpalata, kryteriumSumyWymienionejNaleznosci_Sprawdzana.WezWymienionaNaleznosc.Swiadczenie);
        }
    }
}