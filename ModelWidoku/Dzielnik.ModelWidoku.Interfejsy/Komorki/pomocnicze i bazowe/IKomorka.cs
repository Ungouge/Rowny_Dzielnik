
namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs bazowa dla komorek tabeli komorek.
    /// </summary>
    public interface IKomorka
    {
        /// <summary>
        /// Zwraca iterator rzedu tabeli w którym powinna znajdować się komorka. 
        /// </summary>
        byte Rzad { get; }

        /// <summary>
        /// Zwraca iterator kolumny tabeli w którym powinna znajdować się komorka. 
        /// </summary>
        byte Kolumna { get; }
    }
}