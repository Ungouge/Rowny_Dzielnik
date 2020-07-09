using Dzielnik.Inicjalizator.Interfejsy;
using Dzielnik.Model.Interfejsy.Fabryki;
using Dzielnik.Model.Interfejsy.ObliczaczTabeliNaleznosci;
using Dzielnik.Model.ObliczaczTabeliNaleznosci;

namespace Dzielnik.Testy.Model.ObliczaczTabeliNaleznosci
{
    public static class Stworz_ObliczaczTabeliNaleznosciProkurent
    {
        internal static IObliczaczTabeliNaleznosciProkurent Stworz(IFabrykaDlaObliczaczTabeliNaleznosciProkurent fabryka)
        {
            return new ObliczaczTabeliNaleznosciProkurent(fabryka);
        }
    }
}