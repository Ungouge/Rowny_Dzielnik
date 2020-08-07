using System;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.Testy.ModelWidoku.Komorki.TabelaKomorek
{
    public partial class Czy_TabelaKomorek_GetEnumerator
    {
        private class KomorkiOdlicznik
        {
            byte iloscKomorkaDiagonalna;

            byte iloscKomorkaWejsciowaKwoty;

            byte iloscKomorkaWejsciowaImienia;

            byte iloscKomorkaWyjsciowaImienia;

            short iloscKomorkaDolnotrojkatnaKwotyNaleznej;

            short iloscKomorkaGornotrojkatnaKwotyNaleznej;

            bool czyKomorkaListyRodzajuNaleznosci = false;

            bool czyKomorkaListyKryteriumWyboru = false;

            public KomorkiOdlicznik(byte iloscOsob)
            {
                iloscKomorkaDiagonalna = iloscOsob;

                iloscKomorkaWejsciowaKwoty = iloscOsob;

                iloscKomorkaWejsciowaImienia = iloscOsob;

                iloscKomorkaWyjsciowaImienia = iloscOsob;

                short iloscKomorekPozadiagonalnych = (short)((iloscOsob * (iloscOsob - 1)) / 2);

                iloscKomorkaDolnotrojkatnaKwotyNaleznej = iloscKomorekPozadiagonalnych;

                iloscKomorkaGornotrojkatnaKwotyNaleznej = iloscKomorekPozadiagonalnych;
            }

            internal void AssertujPodliczoneKomorki()
            {
                if (CzyWszystkieKomorkiZostalyWyliczone() == false)
                    throw new Exception("Niezgodna ilosc komorek.");
            }

            private bool CzyWszystkieKomorkiZostalyWyliczone()
            {
                if (iloscKomorkaDiagonalna != 0)
                    return false;

                if (iloscKomorkaWejsciowaKwoty != 0)
                    return false;

                if (iloscKomorkaWejsciowaImienia != 0)
                    return false;

                if (iloscKomorkaDolnotrojkatnaKwotyNaleznej != 0)
                    return false;

                if (iloscKomorkaGornotrojkatnaKwotyNaleznej != 0)
                    return false;

                return czyKomorkaListyRodzajuNaleznosci && czyKomorkaListyKryteriumWyboru;
            }

            internal void PoliczKomorke<TKomorka>(TKomorka komorka) where TKomorka : IKomorka
            {
                switch (komorka)
                {
                    case IKomorkaDiagonalna komorkaDiagonalna:
                        iloscKomorkaDiagonalna--;
                        break;
                    case IKomorkaWejsciowaKwoty komorkaDiagonalna:
                        iloscKomorkaWejsciowaKwoty--;
                        break;
                    case IKomorkaWejsciowaImienia komorkaDiagonalna:
                        iloscKomorkaWejsciowaImienia--;
                        break;
                    case IKomorkaWyjsciowaImienia komorkaDiagonalna:
                        iloscKomorkaWyjsciowaImienia--;
                        break;
                    case IKomorkaDolnotrojkatnaKwotyNaleznej komorkaDiagonalna:
                        iloscKomorkaDolnotrojkatnaKwotyNaleznej--;
                        break;
                    case IKomorkaGornotrojkatnaKwotyNaleznej komorkaDiagonalna:
                        iloscKomorkaGornotrojkatnaKwotyNaleznej--;
                        break;
                    case IKomorkaListyRodzajuNaleznosci komorkaListyRodzajuNaleznosci:
                        PrzypadeKomorkaListyRodzajuNaleznosci();
                        break;
                    case IKomorkaListyKryteriumWyboru komorkaListyKryteriumWyboru:
                        PrzypadekKomorkaListyKryteriumWyboru();
                        break;
                    default:
                        throw new Exception("Nieoczekiwany typ komorki");
                }
            }

            private void PrzypadekKomorkaListyKryteriumWyboru()
            {
                if (czyKomorkaListyKryteriumWyboru == true)
                    throw new Exception("Wyliczona powtornie \"IKomorkaListyKryteriumWyboru\".");

                czyKomorkaListyKryteriumWyboru = true;
            }

            private void PrzypadeKomorkaListyRodzajuNaleznosci()
            {
                if (czyKomorkaListyRodzajuNaleznosci == true)
                    throw new Exception("Wyliczona powtornie \"IKomorkaListyRodzajuNaleznosci\".");

                czyKomorkaListyRodzajuNaleznosci = true;
            }
        }
    }
}
