using System;
using System.Collections.Generic;
using System.Linq;

using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.Fabryki;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.Testy.ModelWidoku.Fabryki;
using Dzielnik.Testy.ModelWidoku.Konwertery.KomorkaNaOsoba;
using Dzielnik.Testy.Inicjalizator.Ustawienia;
using Dzielnik.Zasoby.Interfejsy.Osoby;

using Xunit;

namespace Dzielnik.Testy.ModelWidoku.Komorki.TabelaKomorek
{
    public class Czy_TabelaKomorek_IterujOsobyKomorekKwotyWejsciowej
    {
        private Exception NierowneWylicznikiWyjatek => new Exception("Ilosc element w wylicznikach stworzonych i oczekiwanych osob nie jest rowna.");

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(31)]
        [InlineData(63)]
        public void Czy_IterujOsobyKomorekKwotyWejsciowej_Wylicza_Prawidlowo(byte iloscOsob)
        {
            //Ustal
            IFabrykaModeluWidokuDlaTabelaKomorek fabryka_Mock = Stworz_FabrykaModeluWidokuDlaTabelaKomorek_Mock.Stworz_OsobyKomorekKwotyWejsciowej_Mock(out IList<IOsobaTypSwiadczenia> osobyLista);

            IUstawieniaDlaTabelaKomorek ustawienia = Stworz_UstawieniaDlaTabelaKomorek.Stworz(iloscOsob);

            ITabelaKomorek tabelaKomorek = Stworz_TabelaKomorek.Stworz(fabryka_Mock, ustawienia);

            //Dzialaj
            IEnumerable<IOsobaTypSwiadczenia> osobyZwroconeWyliczane =
                tabelaKomorek.IterujOsobyKomorekKwotyWejsciowej<IOsobaTypSwiadczenia>(Stworz_KonwerterKomorkaNaOsobaWizytator_Mock.Stworz_Mock()).Reverse();

            IEnumerator<IOsobaTypSwiadczenia> osobyZwroconeWylicznik = osobyZwroconeWyliczane.GetEnumerator();

            IEnumerator<IOsobaTypSwiadczenia> osobyOczekiwaneWylicznik = osobyLista.GetEnumerator();

            //Asercja
            while (osobyOczekiwaneWylicznik.MoveNext() == true)
            {
                if (osobyZwroconeWylicznik.MoveNext() == false)
                    throw NierowneWylicznikiWyjatek;

                Assert.Same(osobyOczekiwaneWylicznik.Current, osobyZwroconeWylicznik.Current);
            }

            if (osobyZwroconeWylicznik.MoveNext() == true)
                throw NierowneWylicznikiWyjatek;
        }
    }
}
