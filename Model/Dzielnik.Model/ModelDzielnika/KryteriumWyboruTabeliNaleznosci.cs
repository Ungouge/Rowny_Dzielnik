using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;

namespace Dzielnik.Model
{
    partial class ModelDzielnika
    {
        private KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci;

        public KryteriumWyboruTabeliNaleznosciWylicznik KryteriumWyboruTabeliNaleznosci
        {
            get
            {
                return kryteriumWyboruTabeliNaleznosci;
            }
            set
            {
                if (value != kryteriumWyboruTabeliNaleznosci)
                {
                    kryteriumWyboruTabeliNaleznosci = value;

                    czyModelZostalUaktualniony = true;
                }
            }
        }
    }
}