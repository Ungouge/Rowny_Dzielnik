using System;

using Dzielnik.ModelWidoku.Interfejsy.CzyMoznaObliczac;
using Dzielnik.ModelWidoku.Interfejsy.Komendy;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.Testy.ModelWidoku.CzyMoznaObliczac;

using Moq;
using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komendy
{
    public static class Czy_ObliczKomenda_CanExecute_ZmianaWartosci
    {
        [Fact]
        public static void Czy_CanExecute_ZmianaWartosci_ZmieniaWartoscNa_Prawde()
        {
            //Ustal, Dzialaj i Asercja
            Czy_CanExecute_ZmianaWartosci_ZmieniaWartoscNa(true);
        }

        [Fact]
        public static void Czy_CanExecute_ZmianaWartosci_ZmieniaWartoscNa_Falsz()
        {
            //Ustal, Dzialaj i Asercja
            Czy_CanExecute_ZmianaWartosci_ZmieniaWartoscNa(false);
        }

        private static void Czy_CanExecute_ZmianaWartosci_ZmieniaWartoscNa(bool czyPozwalam)
        {
            //Ustal
            ICzyMoznaObliczacWkaznik czyMoznaObliczacWkaznik = Stworz_CzyMoznaObliczacWkaznik.Stworz();

            IObliczKomenda komenda = Stworz_ObliczKomenda.Stworz(czyMoznaObliczacWkaznik);

            //Dzialaj
            czyMoznaObliczacWkaznik.ZmienMozliwoscOblicznia(default(IKomorkaWejsciowaKwoty), czyPozwalam);

            //Asercja
            Assert.Equal(czyPozwalam, komenda.CanExecute(default(object)));
        }
    }
}