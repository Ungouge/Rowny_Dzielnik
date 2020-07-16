using Dzielnik.ModelWidoku.Interfejsy.Komendy;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komendy
{
    public static class Czy_ObliczKomenda_CanExecute
    {
        [Fact]
        public static void Czy_CanExecute_Inicjalizuje_Dobrze()
        {
            //Ustal
            IObliczKomenda komenda = Stworz_ObliczKomenda.Stworz();

            //Dzialaj
            bool czyMozeWykonywac = komenda.CanExecute(default(object));

            //Asercja
            Assert.True(czyMozeWykonywac);
        }
    }
}