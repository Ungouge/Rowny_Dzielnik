using System;

using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.ModelWidoku
{
    partial class ModelWidokuDzielnika
    {
        public KryteriumWyboruTabeliNaleznosciWylicznik WybraneKryteriumWyboru
        {
            get
            {
                return ustawienia.KryteriumWyboruTabeliNaleznosci;
            }
            set
            {
                if (ustawienia.KryteriumWyboruTabeliNaleznosci == value)
                    return;

                ustawienia.KryteriumWyboruTabeliNaleznosci = value;

                NaZmianeKryteriumWyboru();
            }
        }

        private void NaZmianeKryteriumWyboru()
        {
            //brak akcji.
        }
    }
}