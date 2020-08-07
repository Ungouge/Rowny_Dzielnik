using System.Windows.Media;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorki
{
    public static partial class Stworz_KomorkaWejsciowaKwoty_Mock
    {
        public static IKomorkaWejsciowaKwoty Stworz_Mock()
        {
            return GetKomorkaWejsciowaKwoty_Mock().Object;
        }

        private static Mock<IKomorkaWejsciowaKwoty> GetKomorkaWejsciowaKwoty_Mock()
        {
            return new Mock<IKomorkaWejsciowaKwoty>();
        }
    }
}