using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Model.ObliczaczTabeliNaleznosci;

namespace Dzielnik.Testy.Model.ObliczaczTabeliNaleznosci
{
    public static class Stworz_TabelaNaleznosciPienieznychObliczacz
    {
        internal static ITabelaNaleznosciPienieznychObliczacz Stworz(IFabrykaDlaTabelaNaleznosciPienieznychObliczacz fabryka)
        {
            return new TabelaNaleznosciPienieznychObliczacz(fabryka);
        }
    }
}