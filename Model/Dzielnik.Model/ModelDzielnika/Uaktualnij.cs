using Dzielnik.Zasoby.Interfejsy.KryteriumWyboru;
using Dzielnik.Zasoby.Interfejsy.TablicaOsob;

namespace Dzielnik.Model
{
    partial class ModelDzielnika
    {
        public void Uaktualnij(ITablicaOsobBaza tablicaOsob, KryteriumWyboruTabeliNaleznosciWylicznik kryteriumWyboruTabeliNaleznosci)
        {
            TablicaOsob = tablicaOsob;

            KryteriumWyboruTabeliNaleznosci = kryteriumWyboruTabeliNaleznosci;

            NaUaktualnienieModelu();
        }

        private void NaUaktualnienieModelu()
        {
            if (czyModelZostalUaktualniony == false)
                return;

            ObliczTabeleNaleznosci();

            czyModelZostalUaktualniony = false;
        }

        private void ObliczTabeleNaleznosci()
        {
            TabelaNaleznosci = obliczaczTabeliNaleznosci.ObliczNaleznosci(tablicaOsob, KryteriumWyboruTabeliNaleznosci);
        }
    }
}