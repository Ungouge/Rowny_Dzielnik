using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Moq;

namespace Dzielnik.Testy.Zasoby.Naleznosci
{
    public static partial class Stworz_NaleznoscPieniezna_Mock
    {
        public static INaleznoscPieniezna Stworz_Naleznosc_Swiadczenie_Mock(int grosze)
        {
            Mock<INaleznoscPieniezna> naleznosc_Mock = new Mock<INaleznoscPieniezna>();

            naleznosc_Mock.
                Setup(n => n.Swiadczenie).
                Returns(grosze);

            return naleznosc_Mock.Object;
        }
    }
}