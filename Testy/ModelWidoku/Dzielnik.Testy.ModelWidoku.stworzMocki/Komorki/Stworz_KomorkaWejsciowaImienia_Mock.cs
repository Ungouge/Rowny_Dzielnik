using System.Windows.Media;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static partial class Stworz_KomorkaWejsciowaImienia_Mock
    {
        public static IKomorkaWejsciowaImienia Stworz_Mock()
        {
            return GetKomorkaWejsciowaImienia_Mock().Object;
        }

        private static Mock<IKomorkaWejsciowaImienia> GetKomorkaWejsciowaImienia_Mock()
        {
            return new Mock<IKomorkaWejsciowaImienia>();
        }
    }
}