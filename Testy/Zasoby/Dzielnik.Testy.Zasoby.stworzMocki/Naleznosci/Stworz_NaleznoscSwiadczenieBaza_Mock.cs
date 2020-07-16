using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Moq;

namespace Dzielnik.Testy.Zasoby.Naleznosci
{
    public static class Stworz_NaleznoscSwiadczenieBaza_Mock
    {
        public static INaleznoscSwiadczenieBaza Stworz_Mock()
        {
            return new Mock<INaleznoscSwiadczenieBaza>().Object;
        }
    }
}