using System;

using Dzielnik.ModelWidoku.Interfejsy.Komorki;

namespace Dzielnik.ModelWidoku.Komorki
{
    partial class KomorkaImieniaINaleznosciWejscowej
    {
        private string tekstKomorkiNaleznosci = String.Empty;

        string IKomorkaWejsciowaKwoty.Tekst
        {
            get
            {
                return tekstKomorkiNaleznosci;
            }
            set
            {
                if (tekstKomorkiNaleznosci == value)
                    return;

                tekstKomorkiNaleznosci = value;

                NaZmianeTekstKomorkiNaleznosci();

                NaZmianeWlasciwosci();
            }
        }
    }
}