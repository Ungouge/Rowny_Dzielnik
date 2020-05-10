
namespace Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci
{
    /// <summary>
    /// Interfejs bazowy dla dwuwymiarowych tabel zawierajacych naleznosci odpowiedniego typu osobom względem siebie.
    /// </summary>
    public interface ITabelaNaleznosciBaza
    {
        /// <summary>
        /// Zwraca ilosc komorek w jednym wymiarze tabeli.
        /// </summary>
        byte Rozmiar { get; }
    }
}