using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Moq;
using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.TekstKwotyWejsciowej
{
    public class Czy_KonwerterTekstKwotyWejsciowejProkurent_Konwertuj
    {
        [Fact]
        public void Czy_Konwertuj_Uzywa_WlasciwegoKonwertera()
        {
            //Ustal
            Mock<ITekstKwotyWejsciowejKonwerter> konwerter_Mock = Stworz_TekstKwotyWejsciowejKonwerter_Mock.Stworz_Konwertuj_WeryfikalnyMock();

            IKonwerterTekstKwotyWejsciowejProkurent prokurent = Stworz_KonwerterTekstKwotyWejsciowejProkurent.Stworz(konwerter_Mock.Object);

            //Dzialaj
            prokurent.Konwertuj(default(string), out INaleznoscSwiadczenieBaza naleznosc);

            //Asercja
            konwerter_Mock.Verify
            (
                konwerter => konwerter.Konwertuj(It.IsAny<string>(),
                out It.Ref<INaleznoscSwiadczenieBaza>.IsAny),
                Times.Once,
                "Prokurent nie wykonal konwersji klasa \"" + konwerter_Mock.Object.GetType().ToString() + "\""
            );
        }
    }
}