using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.NaleznoscNaString
{
    internal static class Stworz_NaleznoscNaStringKonwerter_Mock
    {
        internal static INaleznoscNaStringKonwerter Stworz_Mock()
        {
            Mock<INaleznoscNaStringKonwerter> konwerter_Mock = Stworz();

            return konwerter_Mock.Object;
        }
        
        internal static Mock<INaleznoscNaStringKonwerter> Stworz_NaString_WeryfikowlnyMock()
        {
            Mock<INaleznoscNaStringKonwerter> konwerter_Mock = Stworz();

            konwerter_Mock.
                Setup(konwerter => konwerter.NaString(It.IsAny<INaleznoscPieniezna>())).
                Returns(default(string)).
                Verifiable();

            return konwerter_Mock;
        }

        internal static Mock<INaleznoscNaStringKonwerter> Stworz()
        {
            return new Mock<INaleznoscNaStringKonwerter>();
        }
    }
}
