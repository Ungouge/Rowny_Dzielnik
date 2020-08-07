using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Testy.ModelWidoku.Konwertery.TekstKwotyWejsciowej;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Moq;
using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptowalne
{
    public partial class Czy_KomorkaWejsciowaKwoty_Adaptowalna
    {
        [Fact]
        public void Czy_Tekst_Uaktualnia_Akcje()
        {
            //Ustal
            Mock<IKonwerterTekstKwotyWejsciowejProkurentDlaKomorka> konwerterTekstKwotyWejsciowejProkurent_Mock =
                Stworz_KonwerterTekstKwotyWejsciowejProkurentDlaKomorka_Mock.Stworz_Konwertuj_WeryfikowalnyMock();

            IKomorkaWejsciowaKwoty komorka = Stworz_KomorkaImieniaINaleznosciWejscowej.Stworz
            (
                konwerterTekstKwotyWejsciowejProkurent_Mock.Object
            ) as IKomorkaWejsciowaKwoty;

            string nowyTekst = default(string);

            //Dzialaj
            komorka.Tekst = nowyTekst;

            //Asercja
            konwerterTekstKwotyWejsciowejProkurent_Mock.Verify(prokurent => prokurent.Konwertuj(It.IsAny<string>(), out It.Ref<INaleznoscSwiadczenieBaza>.IsAny), Times.Once);
        }
    }
}
