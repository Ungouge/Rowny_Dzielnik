using Dzielnik.ModelWidoku.Interfejsy.Komorki;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Komorka
{
    public static class Stworz_KomorkaWejsciowaKwoty_Mock
    {
        public static IKomorkaWejsciowaKwoty Stworz_Mock()
        {
            Mock<IKomorkaWejsciowaKwoty> komorka_Mock = new Mock<IKomorkaWejsciowaKwoty>();

            return komorka_Mock.Object;
        }
    }
}
