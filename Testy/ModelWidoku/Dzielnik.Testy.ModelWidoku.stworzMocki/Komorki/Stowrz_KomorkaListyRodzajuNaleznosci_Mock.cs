using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    class Stowrz_KomorkaListyRodzajuNaleznosci_Mock
    {
        public static IKomorkaListyRodzajuNaleznosci Stworz_Mock()
        {
            return new Mock<IKomorkaListyRodzajuNaleznosci>().Object;
        }
    }
}
