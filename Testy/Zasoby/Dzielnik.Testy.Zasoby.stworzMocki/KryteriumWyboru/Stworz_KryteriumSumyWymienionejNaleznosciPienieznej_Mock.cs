using Moq;

using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru
{
    public static class Stworz_KryteriumSumyWymienionejNaleznosciPienieznej_Mock
    {
        public static IKryteriumSumyWymienionejNaleznosciPienieznej Stworz_Kryterium_Naleznosc_Polgrsze_Mock(int naleznoscKryteriumWPolgroszach = 0)
        {
            Mock<IKryteriumSumyWymienionejNaleznosciPienieznej> kryteriumSumyWymienionejNaleznosci_Mock =
                new Mock<IKryteriumSumyWymienionejNaleznosciPienieznej>();

            INaleznoscPieniezna naleznoscKryterium_Mock = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Swiadczenie_Mock(naleznoscKryteriumWPolgroszach);

            kryteriumSumyWymienionejNaleznosci_Mock.
                SetupGet(tabela => tabela.WezWymienionaNaleznosc).
                Returns(naleznoscKryterium_Mock);
            
            return kryteriumSumyWymienionejNaleznosci_Mock.Object;
        }
    }
}