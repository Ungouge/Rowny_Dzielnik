using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Moq;

namespace Dzielnik.Testy.Zasoby.Naleznosci
{
    public static partial class Stworz_NaleznoscPieniezna_Mock
    {
        public static INaleznoscPieniezna Stworz_Naleznosc_Mock()
        {
            return new Mock<INaleznoscPieniezna>().Object;
        }
    }
}