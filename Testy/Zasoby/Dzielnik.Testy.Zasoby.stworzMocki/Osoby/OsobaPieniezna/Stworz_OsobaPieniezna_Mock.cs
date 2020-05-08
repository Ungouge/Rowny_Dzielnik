using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Moq;

namespace Dzielnik.Testy.Zasoby.Osoby.OsobaPieniezna
{
    public static partial class Stworz_OsobaPieniezna_Mock
    {
        public static IOsobaPieniezna Stworz_Wpalta_ID_Mock(INaleznoscPieniezna naleznosc, byte iD)
        {
            Mock<IOsobaPieniezna> osoba_Mock = new Mock<IOsobaPieniezna>();

            osoba_Mock.Setup(osoba => osoba.Wplata).Returns(naleznosc);

            osoba_Mock.Setup(osoba => osoba.ID).Returns(iD);

            return osoba_Mock.Object;
        }
    }
}
