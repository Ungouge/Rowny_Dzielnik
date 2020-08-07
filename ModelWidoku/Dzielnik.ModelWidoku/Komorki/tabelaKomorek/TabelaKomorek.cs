using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Fabryki;
using System.Collections.Generic;

namespace Dzielnik.ModelWidoku.Komorki
{
    internal partial class TabelaKomorek : ITabelaKomorek
    {
        public TabelaKomorek(IFabrykaModeluWidokuDlaTabelaKomorek fabrykaDlaTabelaKomorek, IUstawieniaDlaTabelaKomorek ustawienia)
        {
            this.fabrykaDlaTabelaKomorek = fabrykaDlaTabelaKomorek;

            tekstKwotyWejsciowejProkurent = fabrykaDlaTabelaKomorek.StworzKonwerterTekstKwotyWejsciowejProkurent(ustawienia.RodzajNaleznosciWylicznik);

            naleznoscNaStringProkurent = fabrykaDlaTabelaKomorek.StworzNaleznoscNaStringProkurentProkurent(ustawienia.RodzajNaleznosciWylicznik);

            ustawienia.ZmianaRodzajuNaleznosci_ObslugaZdarzenia += NaZmianeRodzajNaleznosciWylicznik;

            komorkiKwotyNaleznej = new Stack<IKomorkaKwotyNaleznej[]>();

            komorkiImieniaINaleznosciWejscowej = new Stack<IKomorkaImieniaINaleznosciWejscowej>();

            komorkiDiagonalna = new Stack<IKomorkaDiagonalna>();

            komorkiDolnotrojkatnaKwotyNaleznej = new Stack<IKomorkaDolnotrojkatnaKwotyNaleznej>();

            komorkiGornotrojkatnaKwotyNaleznej = new Stack<IKomorkaGornotrojkatnaKwotyNaleznej>();

            komorkiKwotyWejsciowej = new Stack<IKomorkaWejsciowaKwoty>();

            komorkiWejsciowaImienia = new Stack<IKomorkaWejsciowaImienia>();

            komorkiWyjsciowaImienia = new Stack<IKomorkaWyjsciowaImienia>();

            InicjalizujKomorki(ustawienia);

            komorkaListyRodzajuNaleznosci = fabrykaDlaTabelaKomorek.StworzKomorkaListyRodzajuNaleznosci();

            komorkaListyKryteriumWyboru = fabrykaDlaTabelaKomorek.StworzKomorkaListyKryteriumWyboru();
        }

        private void NaZmianeRodzajNaleznosciWylicznik(object sender, Zasoby.Zdarzenia.ZmianaUstawieniaRodzajNaleznosciWylicznik_ArgumentyZdarzenia e)
        {
            tekstKwotyWejsciowejProkurent.UaktualnijProkurent(fabrykaDlaTabelaKomorek.StworzTekstKwotyWejsciowejKonwerter(e.RodzajNaleznosci));

            naleznoscNaStringProkurent.UaktualnijProkurent(fabrykaDlaTabelaKomorek.StworzNaleznoscNaStringKonwerter(e.RodzajNaleznosci));
        }

        private void InicjalizujKomorki(IUstawieniaIloscOsob ustawienia)
        {
            for (byte indeks = 0; indeks < ustawienia.IloscOsob; indeks++)
                DodajOsobe(indeks);
        }
    }
}