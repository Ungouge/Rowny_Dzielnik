using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru.KryteriumSumyWymienionejNaleznosciPienieznej
{
    public class Czy_KryteriumSumyWymienionejNaleznosciPienieznej_DodajNaleznoscDoSumyWymienionejNaleznosci
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 0, 1)]
        [InlineData(0, 1, 1)]
        [InlineData(1, 1, 2)]
        [InlineData(2, 1, 3)]
        [InlineData(5, 1, 6)]
        [InlineData(1, 357, 358)]
        [InlineData(357, 1, 358)]
        public void Czy_KryteriumSumyWymienionejNaleznosciPienieznej_DodajNaleznoscDoSumyWymienionejNaleznosci_Prawidlowo_Dodaje
            (int wplata, int Naleznosc_DoDodania, int Naleznosc_Suma)
        {
            //Ustal
            INaleznoscPieniezna naleznoscPieniezna = Stworz_NaleznoscPieniezna.Stworz(wplata);

            IKryteriumSumyWymienionejNaleznosciPienieznej kryteriumSumyWymienionejNaleznosci_Sprawdzana =
                Stworz_KryteriumWymienionejNaleznosciPienieznej.Stworz_KryteriumSumyWymienionejNaleznosci(naleznoscPieniezna);

            INaleznoscPieniezna naleznoscPieniezna_DoDodania = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Swiadczenie_Mock( Naleznosc_DoDodania);

            //Dzialaj
            kryteriumSumyWymienionejNaleznosci_Sprawdzana =
                kryteriumSumyWymienionejNaleznosci_Sprawdzana.DodajNaleznoscDoSumyWymienionejNaleznosci(naleznoscPieniezna_DoDodania);

            //Asercja
            Assert.Equal(Naleznosc_Suma, kryteriumSumyWymienionejNaleznosci_Sprawdzana.WezWymienionaNaleznosc.Swiadczenie);
        }
    }
}