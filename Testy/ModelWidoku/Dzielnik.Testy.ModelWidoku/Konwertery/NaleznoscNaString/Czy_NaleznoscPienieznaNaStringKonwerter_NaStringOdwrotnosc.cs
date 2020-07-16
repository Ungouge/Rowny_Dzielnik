using System;

using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using Dzielnik.Testy.Zasoby.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.NaleznoscNaString
{
    public class Czy_NaleznoscPienieznaNaStringKonwerter_NaStringOdwrotnosc
    {
        [Theory]
        [InlineData(0, "")]
        [InlineData(100, "-1")]
        [InlineData(200, "-2")]
        [InlineData(500, "-5")]
        [InlineData(35700, "-357")]
        [InlineData(Int32.MaxValue, "-21474836,47")]
        [InlineData(1, "-0,01")]
        [InlineData(2, "-0,02")]
        [InlineData(5, "-0,05")]
        [InlineData(357, "-3,57")]
        [InlineData(-100, "1")]
        [InlineData(-200, "2")]
        [InlineData(-500, "5")]
        [InlineData(-35700, "357")]
        public void Czy_NaStringOdwrotnosc_Konwertuje_Prawidlowo(int grosze, string tekstOczekiwany)
        {
            //Ustal
            INaleznoscNaStringKonwerter konwerter = Stworz_NaleznoscPienieznaNaStringKonwerter.Stworz();

            INaleznoscPieniezna naleznosc = Stworz_NaleznoscPieniezna_Mock.Stworz_Naleznosc_Swiadczenie_Mock(grosze);

            //Dzialaj i Asercja
            PorownajTekstAktualnyzKonwersjaNaStringOdwrotnosc(konwerter, naleznosc, tekstOczekiwany);
        }

        [Fact]
        public void Czy_NaStringOdwrotnosc_WyrzucaWyjatek_NaZlyTyp()
        {
            //Ustal
            INaleznoscNaStringKonwerter konwerter = Stworz_NaleznoscPienieznaNaStringKonwerter.Stworz();

            INaleznoscSwiadczenieBaza naleznosc = Stworz_NaleznoscSwiadczenieBaza_Mock.Stworz_Mock();

            //Dzialaj i Asercja
            PorownajTekstAktualnyzKonwersjaNaStringOdwrotnosc(konwerter, naleznosc, String.Empty);
        }

        private static void PorownajTekstAktualnyzKonwersjaNaStringOdwrotnosc(INaleznoscNaStringKonwerter konwerter, INaleznoscSwiadczenieBaza naleznosc, string tekstOczekiwany)
        {
            //Dzialaj
            string tekstAktualny = konwerter.NaStringOdwrotnosc(naleznosc);

            //Asercja
            Assert.Equal(tekstOczekiwany, tekstAktualny);
        }
    }
}