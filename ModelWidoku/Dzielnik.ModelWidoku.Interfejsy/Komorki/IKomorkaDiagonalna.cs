
namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs bazowy dla komorek zawierajacych wlasciwosc z tekstem naleznoscia znajdujaca sie na diagonalnej tabeli naleznosci.
    /// </summary>
    public interface IKomorkaDiagonalna : IKomorkaZNaleznoscia
    {
        /// <summary>
        /// Zwraca tekst komorki diagonalnej.
        /// </summary>
        new string Tekst { get; }

        /// <summary>
        /// Zwraca iterator kolumny tabeli w którym powinna znajdować się komorka diagonalna.
        /// </summary>
        new byte Kolumna { get; }

        /// <summary>
        /// Zwraca iterator rzedu tabeli w którym powinna znajdować się komorka diagonalna.
        /// </summary>
        new byte Rzad { get; }
    }
}