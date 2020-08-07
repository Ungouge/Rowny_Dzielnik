using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class TabelaKomorek
    {
        private void DodajOsobe(byte indeksDodawany)
        {
            DodajNowyRzadKomorekKwotyNaleznej(indeksDodawany);

            DodajKomorkeImieniaINaleznosciWejscowej(fabrykaDlaTabelaKomorek.StworzKomorkiImieniaINaleznosciWejscowej(indeksDodawany, tekstKwotyWejsciowejProkurent));
        }

        private void DodajNowyRzadKomorekKwotyNaleznej(byte indeksDodawany)
        {
            IKomorkaKwotyNaleznej[] nowyRzadKomorekKwotyNaleznej = new IKomorkaKwotyNaleznej[indeksDodawany];

            for (byte indeks = 0; indeks < indeksDodawany; indeks++)
            {
                IKomorkaKwotyNaleznej komorkaKwotyNaleznej =
                    fabrykaDlaTabelaKomorek.StworzKomorkaKwotyNaleznej(indeksDodawany, indeks, naleznoscNaStringProkurent);

                nowyRzadKomorekKwotyNaleznej[indeks] = komorkaKwotyNaleznej;

                komorkiDolnotrojkatnaKwotyNaleznej.Push(fabrykaDlaTabelaKomorek.StworzKomorkaDolnotrojkatnaKwotyNaleznej(komorkaKwotyNaleznej));

                komorkiGornotrojkatnaKwotyNaleznej.Push(fabrykaDlaTabelaKomorek.StworzKomorkaGornotrojkatnaKwotyNaleznej(komorkaKwotyNaleznej));
            }

            komorkiKwotyNaleznej.Push(nowyRzadKomorekKwotyNaleznej);
        }

        private void DodajKomorkeImieniaINaleznosciWejscowej(IKomorkaImieniaINaleznosciWejscowej komorkaImieniaINaleznosciWejscowej)
        {
            komorkiImieniaINaleznosciWejscowej.Push(komorkaImieniaINaleznosciWejscowej);

            komorkiDiagonalna.Push(fabrykaDlaTabelaKomorek.StworzKomorkaDiagonalna(komorkaImieniaINaleznosciWejscowej));

            komorkiKwotyWejsciowej.Push(fabrykaDlaTabelaKomorek.StworzKomorkaWejsciowaKwoty(komorkaImieniaINaleznosciWejscowej));

            komorkiWejsciowaImienia.Push(fabrykaDlaTabelaKomorek.StworzKomorkaWejsciowaImienia(komorkaImieniaINaleznosciWejscowej));

            komorkiWyjsciowaImienia.Push(fabrykaDlaTabelaKomorek.StworzKomorkaWyjsciowaImienia(komorkaImieniaINaleznosciWejscowej));
        }
    }
}