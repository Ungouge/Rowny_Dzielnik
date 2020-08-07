using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Testy.ModelWidoku.Konwertery.NaleznoscNaString;
using Dzielnik.Testy.Zasoby.Naleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Moq;
using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.Adaptowalne
{
    public class Czy_KomorkaKwotyNaleznej_UstalNaleznosc
    {
        [Fact]
        public void Czy_UstalNaleznosc_UstalaPrawidlowo()
        {
            //Ustal
            string naString = "Tekst zwracany dla .NaString()";

            string naStringOdwrotnosc = "Tekst zwracany dla .NaStringOdwrotnosc()";

            INaleznoscSwiadczenieBaza oczekiwanaNaleznosc = Stworz_NaleznoscSwiadczenieBaza_Mock.Stworz_Mock();

            Mock<IKonwerterNaleznoscNaStringProkurent> prokurent_Mock = Stworz_KonwerterNaleznoscNaStringProkurent_Mock.Stworz_NaString_WeryfikowalnyMock(oczekiwanaNaleznosc, naString, naStringOdwrotnosc);

            IKomorkaKwotyNaleznej komorka = Stworz_KomorkaKwotyNaleznej.Stworz(prokurent_Mock.Object);

            //Dzialaj
            komorka.UstalNaleznosc(oczekiwanaNaleznosc);

            //Asercja
            AsertujKomorka.AsertujTekst(naString, (komorka as IKomorkaGornotrojkatnaKwotyNaleznej).Tekst);

            prokurent_Mock.Verify(prokurent => prokurent.NaString(It.IsAny<INaleznoscSwiadczenieBaza>()), Times.Exactly(2));

            AsertujKomorka.AsertujTekst(naStringOdwrotnosc, (komorka as IKomorkaDolnotrojkatnaKwotyNaleznej).Tekst);

            prokurent_Mock.Verify(prokurent => prokurent.NaStringOdwrotnosc(It.IsAny<INaleznoscSwiadczenieBaza>()), Times.Exactly(2));
        }
    }
}