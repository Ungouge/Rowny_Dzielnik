using Moq;

using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Testy.Zasoby.KryteriumWyboru
{
    public static class Stworz_KryteriumIlosciWymian_Mock
    {
        public static IKryteriumIlosciWymian Stworz_KryteriumIlosciWymian_WezIlosciWymian_WezWymienionaNaleznosc_Mock(ushort iloscWymian, int swiadczenieWGroszach)
        {
            Mock<IKryteriumIlosciWymian> kryteriumIlosciWymian_Mock = new Mock<IKryteriumIlosciWymian>();

            kryteriumIlosciWymian_Mock.
                Setup(kryterium => kryterium.WezIlosciWymian).
                Returns(iloscWymian);

            INaleznoscPieniezna naleznoscPieniezna = Stworz_NaleznoscPieniezna.Stworz(swiadczenieWGroszach);

            kryteriumIlosciWymian_Mock.
                Setup(kryterium => kryterium.WezWymienionaNaleznosc).
                Returns(naleznoscPieniezna);

            return kryteriumIlosciWymian_Mock.Object;
        }
    }
}