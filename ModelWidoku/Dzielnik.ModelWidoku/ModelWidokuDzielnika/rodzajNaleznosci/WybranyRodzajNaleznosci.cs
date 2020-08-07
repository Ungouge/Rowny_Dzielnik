using System;

using Dzielnik.Zasoby.Wyliczniki;

namespace Dzielnik.ModelWidoku
{
    partial class ModelWidokuDzielnika
    {
        public RodzajNaleznosciWylicznik WybranyRodzajNaleznosci
        {
            get
            {
                return ustawienia.RodzajNaleznosciWylicznik;
            }
            set
            {
                if (ustawienia.RodzajNaleznosciWylicznik == value)
                    return;

                ustawienia.RodzajNaleznosciWylicznik = value;

                NaZmianeRodzajuNaleznosci();
            }
        }

        private void NaZmianeRodzajuNaleznosci()
        {
            //brak akcji.
        }
    }
}