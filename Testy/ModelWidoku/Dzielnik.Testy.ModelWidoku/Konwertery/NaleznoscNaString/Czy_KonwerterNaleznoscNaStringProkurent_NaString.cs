using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Moq;
using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.NaleznoscNaString
{
    public class Czy_KonwerterNaleznoscNaStringProkurent_NaString
    {
        private string SformatujKomunikatOBledzie => KomunikatOBledzie.SformatujKomunikat("NaStringOdwrotnosc");

        [Fact]
        public void Czy_NaString_Konwertuje_PoczatkowymKonwerterem()
        {
            //Ustal
            Mock<INaleznoscNaStringKonwerter> konwerter_Mock = 
                Stworz_NaleznoscNaStringKonwerter_Mock.Stworz_NaString_WeryfikowlnyMock();

            IKonwerterNaleznoscNaStringProkurent prokurent = Stworz_KonwerterNaleznoscNaStringProkurent.Stworz(konwerter_Mock.Object);

            //Dzialaj
            prokurent.NaString(default(INaleznoscSwiadczenieBaza));

            //Asercja
            konwerter_Mock.Verify(konwerter => konwerter.NaString(It.IsAny<INaleznoscSwiadczenieBaza>()), Times.Once, SformatujKomunikatOBledzie);
        }

        [Fact]
        public void Czy_NaString_Konwertuje_UaktualnionymKonwerterem()
        {
            //Ustal
            INaleznoscNaStringKonwerter poczatkowyKonwerter_Mock = Stworz_NaleznoscNaStringKonwerter_Mock.Stworz_Mock();

            IKonwerterNaleznoscNaStringProkurent prokurent = Stworz_KonwerterNaleznoscNaStringProkurent.Stworz(poczatkowyKonwerter_Mock);

            Mock<INaleznoscNaStringKonwerter> konwerter_Mock = 
                Stworz_NaleznoscNaStringKonwerter_Mock.Stworz_NaString_WeryfikowlnyMock();

            prokurent.NaString(default(INaleznoscSwiadczenieBaza));

            prokurent.UaktualnijProkurent(konwerter_Mock.Object);

            //Dzialaj
            prokurent.NaString(default(INaleznoscSwiadczenieBaza));

            //Asercja
            konwerter_Mock.Verify(konwerter => konwerter.NaString(It.IsAny<INaleznoscSwiadczenieBaza>()), Times.Once, SformatujKomunikatOBledzie);
        }
    }
}