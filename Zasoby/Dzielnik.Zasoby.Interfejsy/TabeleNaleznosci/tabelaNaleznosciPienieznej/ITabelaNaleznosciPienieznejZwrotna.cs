using Dzielnik.Zasoby.Interfejsy.Naleznosci;

namespace Dzielnik.Zasoby.Interfejsy.TabeleNaleznosci
{
    /// <summary>
    /// Interfejs dla zwrotu do modelu widoku dwuwymiarowych tabel zawierajacych naleznosci pienieznej osobom względem siebie.
    /// </summary>
    public interface ITabelaNaleznosciPienieznejZwrotna : ITabelaNaleznosciBaza, ITabelaNaleznosciZwrotna
    {
        /// <summary>
        /// Zwroc wartossc dwuwymiarowej tabeli zawierajaca naleznosci pienieznej podanego polozenia.
        /// </summary>
        new INaleznoscPienieznaSwiadczenie this[IPolozenieWTabeliNaleznosci polozenieWTabeli] { get; }
    }
}