using System.Collections.Generic;

using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.Fabryki;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.Testy.ModelWidoku.Fabryki;
using Dzielnik.Testy.Inicjalizator.Ustawienia;
using Dzielnik.Zasoby.Interfejsy.Osoby;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

using Xunit;
using Dzielnik.Testy.Model.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.Naleznosci;
using System;

namespace Dzielnik.Testy.ModelWidoku.Komorki.TabelaKomorek
{
    public class Czy_TabelaKomorek_UaktualnijTabelaNaleznocsci
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
        public void Czy_UaktualnijTabelaNaleznocsci_Uaktualnia_Prawidlowo(byte iloscOsob)
        {
            //Ustal
            IFabrykaModeluWidokuDlaTabelaKomorek fabryka_Mock =
                Stworz_FabrykaModeluWidokuDlaTabelaKomorek_Mock.
                    Stworz_NaleznosciKomorekKwotyWejsciowej_Mock(out IDictionary<IPolozenieWTabeliNaleznosci, INaleznoscSwiadczenieBaza> naleznosciWlasciweSlownik);

            IUstawieniaDlaTabelaKomorek ustawienia = Stworz_UstawieniaDlaTabelaKomorek.Stworz(iloscOsob);

            ITabelaKomorek tabelaKomorek = Stworz_TabelaKomorek.Stworz(fabryka_Mock, ustawienia);

            ITabelaNaleznosciZwrotna tabelaNaleznosci =
                Stworz_TabelaNaleznosciZwrotna_Mock.Stworz_IndeksatorNaleznosci_Mock(out IDictionary<IPolozenieWTabeliNaleznosci, INaleznoscSwiadczenieBaza> naleznosciOczekiwaneSlownik);

            short iloscKomorekPozadiagonalnych = (short)((iloscOsob * (iloscOsob - 1)) / 2);

            //Dzialaj
            tabelaKomorek.UaktualnijTabelaNaleznocsci(tabelaNaleznosci);

            foreach (KeyValuePair<IPolozenieWTabeliNaleznosci, INaleznoscSwiadczenieBaza> paraKluczWartosc in naleznosciOczekiwaneSlownik)
            {
                IPolozenieWTabeliNaleznosci polozenie = paraKluczWartosc.Key;

                if (naleznosciWlasciweSlownik.TryGetValue(polozenie, out INaleznoscSwiadczenieBaza naleznoscWlasciwa))
                {
                    Assert.Same(paraKluczWartosc.Value, naleznoscWlasciwa);

                    naleznosciWlasciweSlownik.Remove(polozenie);
                    
                }
                else
                    throw new Exception(String.Format("Nie ma przypisanej naleznosci dla polozenia [{0},{1}].", polozenie.Indeks_X, polozenie.Indeks_Y));
            }

            if (naleznosciWlasciweSlownik.Count > 0)
                throw new Exception(String.Format("{0} naleznosci wlasciwych nie ma przypisanych oczekiwanych naleznosci", naleznosciWlasciweSlownik.Count));
        }
    }
}