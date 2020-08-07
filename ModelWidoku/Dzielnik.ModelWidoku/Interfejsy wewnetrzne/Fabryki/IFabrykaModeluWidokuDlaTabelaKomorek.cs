using Dzielnik.ModelWidoku.Interfejsy.Komorki;
using Dzielnik.ModelWidoku.Interfejsy.Konwertery;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.ModelWidoku.Interfejsy.Fabryki
{
    internal interface IFabrykaModeluWidokuDlaTabelaKomorek
    {
        IKomorkaListyRodzajuNaleznosci StworzKomorkaListyRodzajuNaleznosci();

        IKonwerterTekstKwotyWejsciowejProkurent StworzKonwerterTekstKwotyWejsciowejProkurent(RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik);

        ITekstKwotyWejsciowejKonwerter StworzTekstKwotyWejsciowejKonwerter(RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik);

        IKonwerterNaleznoscNaStringProkurent StworzNaleznoscNaStringProkurentProkurent(RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik);

        INaleznoscNaStringKonwerter StworzNaleznoscNaStringKonwerter(RodzajNaleznosciWylicznik rodzajNaleznosciWylicznik);

        IKomorkaKwotyNaleznej StworzKomorkaKwotyNaleznej(byte kolumna, byte rzad, IKonwerterNaleznoscNaStringProkurent naleznoscNaStringProkurent);

        IKomorkaImieniaINaleznosciWejscowej StworzKomorkiImieniaINaleznosciWejscowej(byte indeks, IKonwerterTekstKwotyWejsciowejProkurent konwerterTekstKwotyWejsciowej);

        IPolozenieWTabeliNaleznosci StworzPolozenieWTabeliNaleznosci(byte index_X, byte index_Y);
        
        IKomorkaDolnotrojkatnaKwotyNaleznej StworzKomorkaDolnotrojkatnaKwotyNaleznej(IKomorkaKwotyNaleznej komorka);

        IKomorkaGornotrojkatnaKwotyNaleznej StworzKomorkaGornotrojkatnaKwotyNaleznej(IKomorkaKwotyNaleznej komorka);

        IKomorkaDiagonalna StworzKomorkaDiagonalna(IKomorkaImieniaINaleznosciWejscowej komorka);

        IKomorkaWejsciowaKwoty StworzKomorkaWejsciowaKwoty(IKomorkaImieniaINaleznosciWejscowej komorka);

        IKomorkaWejsciowaImienia StworzKomorkaWejsciowaImienia(IKomorkaImieniaINaleznosciWejscowej komorka);

        IKomorkaWyjsciowaImienia StworzKomorkaWyjsciowaImienia(IKomorkaImieniaINaleznosciWejscowej komorka);

        IKomorkaListyKryteriumWyboru StworzKomorkaListyKryteriumWyboru();
    }
}
