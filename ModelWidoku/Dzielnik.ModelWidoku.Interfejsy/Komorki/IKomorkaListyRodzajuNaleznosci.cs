
namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs dla komorek z polem wyboru rodzaju naleznosci.
    /// </summary>
    public interface IKomorkaListyRodzajuNaleznosci : IKomorkaListy
    {
        /// <summary>
        /// Zwraca iterator kolumny tabeli w którym powinna znajdować się komorka pola wyboru rodzaju naleznosci. 
        /// </summary>
        new byte Kolumna { get; }
    }
}