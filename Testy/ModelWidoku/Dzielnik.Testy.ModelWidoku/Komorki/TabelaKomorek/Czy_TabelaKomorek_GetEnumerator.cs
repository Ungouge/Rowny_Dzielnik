using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Fabryki;
using Dzielnik.Testy.ModelWidoku.Fabryki;
using Dzielnik.Testy.Inicjalizator.Ustawienia;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.TabelaKomorek
{
    public partial class Czy_TabelaKomorek_GetEnumerator
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(31)]
        [InlineData(63)]
        public void Czy_GetEnumerator_Wylicza_Prawidlowo(byte iloscOsob)
        {
            //Ustal
            IFabrykaModeluWidokuDlaTabelaKomorek fabryka_Mock = Stworz_FabrykaModeluWidokuDlaTabelaKomorek_Mock.Stworz_StworzKomorki_Mock();

            IUstawieniaDlaTabelaKomorek ustawienia = Stworz_UstawieniaDlaTabelaKomorek.Stworz(iloscOsob);

            ITabelaKomorek tabelaKomorek = Stworz_TabelaKomorek.Stworz(fabryka_Mock, ustawienia);

            short iloscKomorekPozadiagonalnych = (short)((iloscOsob * (iloscOsob - 1)) / 2);

            KomorkiOdlicznik komorkiOdlicznik = new KomorkiOdlicznik(iloscOsob);

            // Dzialaj
            foreach (IKomorka komorka in tabelaKomorek)
                //Asercja
                komorkiOdlicznik.PoliczKomorke(komorka);

            komorkiOdlicznik.AssertujPodliczoneKomorki();
        }
    }
}