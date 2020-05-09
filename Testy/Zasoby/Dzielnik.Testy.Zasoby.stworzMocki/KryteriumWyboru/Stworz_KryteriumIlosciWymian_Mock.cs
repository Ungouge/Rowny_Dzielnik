using Moq;

using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru
{
    public static class Stworz_KryteriumIlosciWymian_Mock
    {
        public static IKryteriumIlosciWymian Stworz_KryteriumIlosciWymian_WezIlosciWymian_Mock(ushort iloscWymain)
        {
            Mock<IKryteriumIlosciWymian> kryteriumIlosciWymian_Mock = new Mock<IKryteriumIlosciWymian>();

            kryteriumIlosciWymian_Mock.
                Setup(kryterium => kryterium.WezIlosciWymian).
                Returns(iloscWymain);

            return kryteriumIlosciWymian_Mock.Object;
        }
    }
}
