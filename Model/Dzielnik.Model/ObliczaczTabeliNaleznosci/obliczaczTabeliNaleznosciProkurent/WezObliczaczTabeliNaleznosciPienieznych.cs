using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;

namespace Dzielnik.Model.ObliczaczTabeliNaleznosci
{
    partial class ObliczaczTabeliNaleznosciProkurent
    {
        private ITabelaNaleznosciObliczacz obliczaczTabeliNaleznosci = null;

        private ITabelaNaleznosciPienieznychObliczacz WezObliczaczTabeliNaleznosciPienieznych
        {
            get
            {
                if (obliczaczTabeliNaleznosci is ITabelaNaleznosciPienieznychObliczacz ObliczaczTabeliNaleznosciPienieznych)
                    return ObliczaczTabeliNaleznosciPienieznych;

                obliczaczTabeliNaleznosci = fabryka.StworzObliczaczTabeliNaleznosciPienieznych();

                return obliczaczTabeliNaleznosci as ITabelaNaleznosciPienieznychObliczacz;
            }
        }
    }
}