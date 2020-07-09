using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;

namespace Dzielnik.Model.ObliczaczTabeliNaleznosci
{
    partial class ObliczaczTabeliNaleznosciProkurent
    {
        private ITabelaNaleznosciPienieznychObliczacz obliczaczTabeliNaleznosciPienieznych = null;

        private ITabelaNaleznosciPienieznychObliczacz ObliczaczTabeliNaleznosciPienieznych
        {
            get
            {
                if (obliczaczTabeliNaleznosciPienieznych == null)
                    obliczaczTabeliNaleznosciPienieznych = fabryka.StworzObliczaczTabeliNaleznosciPienieznych();

                return obliczaczTabeliNaleznosciPienieznych;
            }
        }
    }
}