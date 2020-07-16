using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Moq;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.TekstKwotyWejsciowej
{
    internal class Stworz_TekstKwotyWejsciowejKonwerter_Mock
    {
        internal static Mock<ITekstKwotyWejsciowejKonwerter> Stworz_Konwertuj_WeryfikalnyMock()
        {
            Mock<ITekstKwotyWejsciowejKonwerter> konwerter_Mock = new Mock<ITekstKwotyWejsciowejKonwerter>();

            konwerter_Mock.
                Setup(konwerter => konwerter.Konwertuj(It.IsAny<string>(), out It.Ref<INaleznoscSwiadczenieBaza>.IsAny)).
                Returns(true).
                Verifiable();

            return konwerter_Mock;
        }
    }
}
