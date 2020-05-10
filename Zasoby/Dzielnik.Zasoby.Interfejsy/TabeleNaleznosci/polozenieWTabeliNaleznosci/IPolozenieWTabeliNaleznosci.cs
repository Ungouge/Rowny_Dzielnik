
namespace Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci
{
    /// <summary>
    /// Interfejs do struktury zawierajacej koordynaty w tabeli naleznosci.
    /// </summary>
    public interface IPolozenieWTabeliNaleznosci: IPolozenieGornotrojkatneWTabeliNaleznosci
    {
        new byte Indeks_X { get; }

        new byte Indeks_Y { get; }
    }
}