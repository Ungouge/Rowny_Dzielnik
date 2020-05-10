using Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci;

namespace Dzielnik.Zasoby.Interfejsy.Fabryki
{
    /// <summary>
    /// Interfejs fabryka do tworzenia struktury zawierajacej koordynaty w tabeli naleznosci.
    /// </summary>
    public interface IFabrykaPolozeniaWTabeliNaleznosci
    {
        /// <summary>
        /// Stworz instancje struktury zawierajacej koordynaty w tabeli naleznosci.
        /// </summary>
        IPolozenieWTabeliNaleznosci StworzPolozeniaWTabeliNaleznosci(byte indeks_X, byte indeks_Y);
    }
}