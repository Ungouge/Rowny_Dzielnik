using Dzielnik.Zasoby.Fabryki;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.Interfejsy.Fabryki;

namespace Dzielnik.Testy.Zasoby.TabelaNaleznosci
{
    public static class Stworz_PolozenieWTabeliNaleznosci
    {
        private static readonly IFabrykaPolozeniaWTabeliNaleznosci fabrykaPolozeniaWTabeliNaleznosci = new FabrykaPolozeniaWTabeliNaleznosci();

        public static IPolozenieWTabeliNaleznosci Stworz(byte indeks_X, byte indeks_Y)
        {
            return fabrykaPolozeniaWTabeliNaleznosci.StworzPolozeniaWTabeliNaleznosci(indeks_X, indeks_Y);
        }
    }
}