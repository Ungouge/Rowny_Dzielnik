using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static partial class Stworz_KomorkaWyjsciowaImienia_Mock
    {
        public static IKomorkaWyjsciowaImienia Stworz_Mock()
        {
            return GetKomorkaWyjsciowaImienia_Mock().Object;
        }

        private static Mock<IKomorkaWyjsciowaImienia> GetKomorkaWyjsciowaImienia_Mock()
        {
            return new Mock<IKomorkaWyjsciowaImienia>();
        }
    }
}