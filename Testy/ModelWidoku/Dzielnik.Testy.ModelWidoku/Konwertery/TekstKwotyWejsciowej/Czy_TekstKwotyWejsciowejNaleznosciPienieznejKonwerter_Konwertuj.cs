using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Konwertery.TekstKwotyWejsciowej
{
    public class Czy_TekstKwotyWejsciowejNaleznosciPienieznejKonwerter_Konwertuj
    {
        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 100)]
        [InlineData("2", 200)]
        [InlineData("5", 500)]
        [InlineData("0,00", 0)]
        [InlineData("0,01", 1)]
        [InlineData("0,02", 2)]
        [InlineData("0,05", 5)]
        [InlineData("1,00", 100)]
        [InlineData("1,01", 101)]
        [InlineData("1,02", 102)]
        [InlineData("1,05", 105)]
        public void Czy_Konwertuj_Zwraca_Prawidlowo(string tekstKwotyWejsciowej, int oczekiwaneSwiadzceniePieniezne)
        {
            //Ustal
            ITekstKwotyWejsciowejKonwerter konwerter = Stworz_TekstKwotyWejsciowejNaleznosciPienieznejKonwerter.Stworz();

            //Dzialaj
            konwerter.Konwertuj(tekstKwotyWejsciowej, out INaleznoscSwiadczenieBaza naleznosc);

            //Asercja
            if (naleznosc is INaleznoscPieniezna naleznoscPieniezna)
                Assert.Equal(oczekiwaneSwiadzceniePieniezne, naleznoscPieniezna.Swiadczenie);
            else
                Assert.IsAssignableFrom<INaleznoscPieniezna>(naleznosc);
        }
    }
}
