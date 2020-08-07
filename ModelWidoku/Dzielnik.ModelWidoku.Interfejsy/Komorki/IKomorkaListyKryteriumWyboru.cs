
namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs dla komorki z polem wyboru kryterium wyboru.
    /// </summary>
    public interface IKomorkaListyKryteriumWyboru : IKomorkaListy
    {
        /// <summary>
        /// Zwraca iterator kolumny tabeli w którym powinna znajdować się komorka pola wyboru kryterium wyboru. 
        /// </summary>
        new byte Kolumna { get; }
    }
}