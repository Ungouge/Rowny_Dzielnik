using Dzielnik.Zasoby.Interfejsy.TablicaOsob;
using Dzielnik.Model.DoStanuKwitaSumator;
using Dzielnik.Model.Interfejsy.DoStanuKwitaSumator;

namespace Dzielnik.Testy.Model.DoStanuKwitaSumator
{
    public static class Stworz_RozniceDoStanuKwitaNaleznosciPienieznychSumator
    {
        internal static IRozniceDoStanuKwitaNaleznosciPienieznychSumator Stworz(ITablicaOsobPienieznychIterowalna koncowaTablicaOsob)
        {
            return new RozniceDoStanuKwitaNaleznosciPienieznychSumator(koncowaTablicaOsob);
        }
    }
}