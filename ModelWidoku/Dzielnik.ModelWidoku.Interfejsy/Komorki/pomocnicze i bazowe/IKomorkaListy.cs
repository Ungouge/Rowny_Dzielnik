
namespace Dzielnik.ModelWidoku.Interfejsy.Komorki
{
    /// <summary>
    /// Interfejs dla komorek z polem wyboru.
    /// </summary>
    public interface IKomorkaListy: IKomorka
    {
        /// <summary>
        /// Zwraca iterator rzedu tabeli w którym powinna znajdować się komorka pola wyboru. 
        /// </summary>
        new byte Rzad { get; }
    }
}