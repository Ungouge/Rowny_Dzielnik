
namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs dla komorek z tekstem imienia.
    /// </summary>
    public interface IKomorkaWyjsciowaImienia: IKomorkaImienia, IKomorkaZTekstem
    {
        /// <summary>
        /// Zwraca iterator rzedu tabeli w którym powinna znajdować się komorka imienia
        /// </summary>
        new byte Rzad { get; }

        /// <summary>
        /// Zwraca iterator kolumny tabeli w którym powinna znajdować się komorka imienia.
        /// </summary>
        new byte Kolumna { get; }
    }
}