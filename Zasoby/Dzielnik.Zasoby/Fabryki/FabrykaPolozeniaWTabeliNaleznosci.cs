using Dzielnik.Zasoby.Interfejsy.Fabryki;
using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;
using Dzielnik.Zasoby.TabeleNaleznosci;

namespace Dzielnik.Zasoby.Fabryki
{
    /// <summary>
    /// Fabryka do tworzenia struktury zawierajacej koordynaty w tabeli naleznosci.
    /// </summary>
    public class FabrykaPolozeniaWTabeliNaleznosci : IFabrykaPolozeniaWTabeliNaleznosci
    {
        public IPolozenieWTabeliNaleznosci StworzPolozeniaWTabeliNaleznosci(byte indeks_X, byte indeks_Y)
        {
            return new PolozenieWTabeliNaleznosci(indeks_X, indeks_Y);
        }
    }
}
