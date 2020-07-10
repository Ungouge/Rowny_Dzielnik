using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Model
{
    partial class ModelDzielnika
    {
        private ITabelaNaleznosciZwrotna tabelaNaleznosci = null;

        public ITabelaNaleznosciZwrotna TabelaNaleznosci
        {
            get
            {
                return tabelaNaleznosci;
            }
            set
            {
                if (value == null)
                    return;

                if (value == tabelaNaleznosci)
                    return;

                tabelaNaleznosci = value;

                NaObliczenieTabeliNaleznosci();
            }
        }

        private void NaObliczenieTabeliNaleznosci()
        {
            ObliczonaTabelNaleznocsci?.Invoke(this, tabelaNaleznosci);
        }
    }
}