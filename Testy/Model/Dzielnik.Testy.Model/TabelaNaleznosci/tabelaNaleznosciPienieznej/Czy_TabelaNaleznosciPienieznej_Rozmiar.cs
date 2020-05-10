using Dzielnik.Model.Interfejsy.TabeleNaleznosci;
using Dzielnik.Testy.Model.TabeleNaleznosci;

using Xunit;

namespace Dzielnik.Testy.Model.TabelaNaleznosci
{
    public class Czy_TabelaNaleznosciPienieznej_Rozmiar
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(35)]
        [InlineData(42)]
        [InlineData(byte.MaxValue)]
        public void Czy_Zwraca_PrawidlowaWartosc (byte rozmiar)
        {
            //Ustal i Dzialaj
            ITabelaNaleznosciPienieznej tabelaNaleznosci = Stworz_TabelaNaleznosciPienieznej.Stworz_Pusty(rozmiar);

            //Asercja
            Assert.Equal(rozmiar, tabelaNaleznosci.Rozmiar);
        }
    }
}
